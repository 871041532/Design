package Job.core;

import java.util.ArrayList;
import java.util.Collection;

public class SyncJobManager extends JobBase
{
    //所有子事务
    public ArrayList<JobBase> m_jobs = new ArrayList<JobBase>();
    //总数
    public int m_count = 0;
    //成功总数
    public int m_successCount = 0;
    //失败总数
    public int m_errorCount = 0;
    //进度值
    public int m_progressCount = 0;
    //存储错误参数列表
    public ArrayList<CallBackPara> m_errors = new ArrayList<CallBackPara>();
    //存储回调进度参数列表
    public ArrayList<CallBackPara> m_items = new ArrayList<CallBackPara>();

    //构造
    public SyncJobManager(Collection<? extends JobBase> jobs)
    {
        if (jobs != null)
        {
            JobBase[] _jobs = (JobBase[]) jobs.toArray();
            for (int i = 0; i < _jobs.length; i++)
            {
                CallBackPara temp = new CallBackPara(null, i, 0, 0, null);
                m_jobs.add(_jobs[i]);
                m_items.add(temp);
            }
        }
    }

    //添加一个子事务
    public void addJob(JobBase job)
    {
        int index = m_jobs.size();
        m_jobs.add(job);
        m_items.add(new CallBackPara(null, index, 0, 0, null));
    }

    //添加许多子事务
    public void addJobs(Collection<? extends JobBase> jobs)
    {
        if (jobs != null)
        {
            for (JobBase item : jobs)
            {
                addJob(item);
            }
        }
    }

    //重写onRun
    protected void onRun()
    {
        m_count = m_jobs.size();
        if (m_count <= 0)
        {
            tryEnd();
        } else
        {
            int i = 0;
            for (JobBase item : m_jobs)
            {
                item.run((CallBackPara para) ->
                {//子事务成功回调
                    successHandler(para);
                }, (CallBackPara para) ->
                {//子事务失败回调
                    errorHandler(para);
                }, (CallBackPara para) ->
                {//子事务更新进度回调
                    progressHandler(para);
                }, i++);//赋值子事务m_id
            }
        }
    }

    //重写onDispose
    protected void onDispose()
    {
        for (JobBase item : m_jobs)
        {
            item.dispose();
        }
        m_items = null;
        m_jobs = null;
    }

    //尝试结束
    private void tryEnd()
    {
        if (m_successCount + m_errorCount == m_count)//同步mgr子job如果出错不会停止，而是等所有子job执行完再回调。异步mgr不然，某个子job错误会立即停止并返回错误信息
        {
            if (m_errorCount > 0)
            {
                onError(m_errors, m_items, null);
            } else
            {
                onSuccess(m_items, null);
            }
        }
    }

    //子事务成功调用
    private void successHandler(CallBackPara para)
    {
        if (m_disposed)
        {
            return;
        }
        m_successCount += 1;
        m_items.get(para.m_id).m_resultData = para.m_resultData;
        tryEnd();
    }

    //子事务失败调用
    private void errorHandler(CallBackPara para)
    {
        if (m_disposed)
        {
            return;
        }
        m_errors.add(para);//将错误信息加入list
        m_errorCount += 1;
        m_items.get(para.m_id).m_errorData = para.m_errorData;
        tryEnd();
    }

    //子事务进度更新调用
    private void progressHandler(CallBackPara para)
    {
        if (m_disposed)
        {
            return;
        }
        m_progressCount -= m_items.get(para.m_id).m_progress / m_count;
        m_progressCount += para.m_progress / m_count;
        m_items.get(para.m_id).m_progress = para.m_progress;
        if (m_progress != null && m_progressCount < 100)//100时在jobase积累中调用，故而不需要再调
        {
            onProgress(m_progressCount, null);//总进度
        }
    }
}