package Job.core;
import java.util.function.Consumer;

//Job基类
public class JobBase
{
    protected Consumer<CallBackPara> m_success;//成功回调
    protected Consumer<CallBackPara> m_error;//失败回调
    protected Consumer<CallBackPara> m_progress;//进行中回调
    public int m_id = 0;//执行id
    public boolean m_disposed = true;//是否结束

    //开跑
    public void run(Consumer<CallBackPara> _success, Consumer<CallBackPara> _error, Consumer<CallBackPara> _progress, int _runId)
    {
        if (!m_disposed)
        {
            System.out.println("Job is on running,do not repreat.");
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
    public boolean isRunning()
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
    protected void onRun()
    {

    }

    //留给子类重写
    protected void onDispose()
    {

    }

    //调用以示事务结束
    protected void onSuccess(Object result, Object ext)
    {
        if (m_disposed)
        {
            return;
        }
        if (m_progress != null)//进度完成100
        {
            m_progress.accept(new CallBackPara(null, m_id, null, 100, null));
        }
        if (m_success != null)
        {
            m_success.accept(new CallBackPara(result, m_id, 0, 0, ext));
        }
        this.dispose();
        //先m_success再dispose:在AsyncJobManager中会导致子dispose调用呈栈结构，按照List<jobBase>反序调用jobDispose
        //另外同步SyncMgr哪个先调用完成不确定
        //混合mgr哪个先调用完成不确定
    }

    //调用以示事务失败
    protected void onError(Object err, Object result, Object ext)
    {
        if (m_error != null)
        {
            m_error.accept(new CallBackPara(result, m_id, err, 0, ext));
        }
        dispose();
    }

    //调用以示事务执行进度
    protected void onProgress(int progress, Object ext)
    {
        if (m_progress != null)
        {
            m_progress.accept(new CallBackPara(null, m_id, null, progress, ext));
        }
    }
}