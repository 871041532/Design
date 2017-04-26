using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05Job
{
    /// <summary>
    /// 回调参数传递
    /// </summary>
    public class CallBackPara
    {
        public object m_resultData;//回调结果
        public object m_errorData;//错误结果
        public int m_progress;//进度
        public int m_id;//编号
        public object m_ext;//扩展参数

        public CallBackPara(object _result, int _id, object _error, int _progress, object _ext)
        {
            m_resultData = _result;
            m_id = _id;
            m_errorData = _error;
            m_progress = _progress;
            m_ext = _ext;
        }
    }
    //Job基类
    public class JobBase
    {
        protected Action<CallBackPara> m_success;//成功回调
        protected Action<CallBackPara> m_error;//失败回调
        protected Action<CallBackPara> m_progress;//进行中回调
        public int m_id = 0;//执行id
        public bool m_disposed = true;//是否结束

        //开跑
        public void run(Action<CallBackPara> _success = null, Action<CallBackPara> _error = null, Action<CallBackPara> _progress = null, int _runId = 0)
        {
            if (!m_disposed)
            {
                Console.WriteLine("Job is on running,do not repreat.");
                return;
            }
            m_success = _success;
            m_error = _error;
            m_progress = _progress;
            m_id = _runId;
            m_disposed = false;
            this.onRun();
        }
        //是否运行中
        public bool isRunning()
        {
            return !m_disposed;
        }
        //运行结束
        public void dispose()
        {
            if (m_disposed)
            {
                return;
            }
            m_disposed = true;
            m_success = null;
            m_progress = null;
            m_error = null;
            m_id = 0;
            onDispose();
        }
        //留给子类重写
        protected virtual void onRun()
        {

        }
        //留给子类重写
        protected virtual void onDispose()
        {

        }
        //调用以示事务结束
        protected void onSuccess(object result = null, object ext = null)
        {
            if (m_disposed)
            {
                return;
            }
            if (m_progress != null)//进度完成100
            {
                m_progress(new CallBackPara(null, m_id, null, 100, null));
            }
            if (m_success != null)
            {
                m_success(new CallBackPara(result, m_id, 0, 0, ext));
            }
            this.dispose();
            //先m_success再dispose:在AsyncJobManager中会导致子dispose调用呈栈结构，按照List<jobBase>反序调用jobDispose
            //另外同步SyncMgr哪个先调用完成不确定
            //混合mgr哪个先调用完成不确定
        }
        //调用以示事务失败
        protected void onError(object err = null, object result = null, object ext = null)
        {
            if (m_error != null)
            {
                m_error(new CallBackPara(result, m_id, err, 0, ext));
            }
            dispose();
        }
        //调用以示事务执行进度
        protected void onProgress(int progress = 0, object ext = null)
        {
            if (m_progress != null)
            {
                m_progress(new CallBackPara(null, m_id, null, progress, ext));
            }
        }
    }
}
