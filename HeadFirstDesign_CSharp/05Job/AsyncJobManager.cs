using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05Job
{
    public class AsyncJobManager : JobBase
    {
        public List<JobBase> m_jobs = new List<JobBase>();//所有待执行事务
        public int m_current = 0;//当前在执行事务编号
        public int m_progressCount = 0;//当前进度

        public AsyncJobManager(IEnumerable<JobBase> _jobs = null)
        {
            if (_jobs != null)
            {
                m_jobs.AddRange(_jobs);
            }
        }
        //添加一个job
        public void addJob(JobBase job)
        {
            m_jobs.Add(job);
        }
        //添加jobs
        public void addJobs(IEnumerable<JobBase> jobs)
        {
            m_jobs.AddRange(jobs);
        }
        //特定位置添加
        public void addJobAt(int pos, JobBase job)
        {
            if (pos < m_jobs.Count && pos >= 0)
            {
                m_jobs.Insert(pos, job);
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
            m_progressCount = (100 * m_current + para.m_progress) / m_jobs.Count;
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
            if (m_jobs.Count > m_current)
            {
                m_jobs[m_current].run((CallBackPara para) =>
                {//子事务执行成功
                    successHandler(para);
                }, (CallBackPara para) =>
                {//子事务执行失败
                    errorHandler(para);
                }, (CallBackPara para) =>
                {//子事务更新进度
                    progressHandler(para);
                }, m_current);
            }
            else
            {
                onSuccess(null, null);//此处成功resultdata为null，此mgr成功不返回任何子事务信息
            }
        }
        //重写
        protected override void onRun()
        {
            m_current = 0;
            nextJob();
        }
        //重写
        protected override void onDispose()
        {
            JobBase[] array = m_jobs.ToArray();
            for (int i = m_current; i < array.Length; i++)
            {
                array[i].dispose();
            }
            m_jobs = null;
        }
    }
}
