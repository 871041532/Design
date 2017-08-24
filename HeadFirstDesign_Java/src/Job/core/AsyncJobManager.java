package Job.core;

import java.util.ArrayList;
import java.util.Collection;

public class AsyncJobManager extends JobBase
{
    //所有待执行事务
    public ArrayList<JobBase> m_jobs = new ArrayList<JobBase>();
    //当前在执行事务编号
    public int m_current = 0;
    //当前进度
    public int m_progressCount = 0;

    public AsyncJobManager(Collection<? extends JobBase> _jobs)
    {
        if (_jobs != null)
        {
            m_jobs.addAll(_jobs);
        }
    }

    //添加一个job
    public void addJob(JobBase job)
    {
        m_jobs.add(job);
    }

    //添加jobs
    public void addJobs(Collection<? extends JobBase> jobs)
    {
        m_jobs.addAll(jobs);
    }

    //特定位置添加
    public void addJobAt(int pos, JobBase job)
    {
        if (pos < m_jobs.size() && pos >= 0)
        {
            m_jobs.add(pos, job);
        }
    }

    //子事务成功结束回调
    public void successHandler(CallBackPara para)
    {
        m_current += 1;
        nextJob();
    }

    //子事务失败回调
    public void errorHandler(CallBackPara para)
    {
        onError(para, null, null);
    }

    //子事务进度回调
    public void progressHandler(CallBackPara para)
    {
        m_progressCount = (100 * m_current + para.m_progress) / m_jobs.size();
        if (m_progressCount < 100)
        {
            onProgress(m_progressCount, null);
        }
    }

    //执行下一个子事务
    public void nextJob()
    {
        if (m_disposed)
        {
            return;
        }
        if (m_jobs.size() > m_current)
        {
            m_jobs.get(m_current).run((CallBackPara para) ->
            {
                //子事务执行成功
                successHandler(para);
            }, (CallBackPara para) ->
            {
                //子事务执行失败
                errorHandler(para);
            }, (CallBackPara para) ->
            {
                //子事务更新进度
                progressHandler(para);
            }, m_current);
        } else
        {
            onSuccess(null, null);//此处成功resultdata为null，此mgr成功不返回任何子事务信息
        }
    }

    //重写
    @Override
    protected void onRun()
    {
        m_current = 0;
        nextJob();
    }

    //重写
    @Override
    protected void onDispose()
    {
        if (m_jobs!=null)
        {
            JobBase[] array = (JobBase[]) m_jobs.toArray(new JobBase[m_jobs.size()]);
            for (int i = m_current; i < array.length; i++)
            {
                array[i].dispose();
            }
            m_jobs = null;
        }
    }
}