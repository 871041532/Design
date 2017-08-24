package Job.core;

/// <summary>
/// 回调参数传递
/// </summary>
public class CallBackPara
{
    public Object m_resultData;//回调结果
    public Object m_errorData;//错误结果
    public int m_progress;//进度
    public int m_id;//编号
    public Object m_ext;//扩展参数

    public CallBackPara(Object _result, int _id, Object _error, int _progress, Object _ext)
    {
        m_resultData = _result;
        m_id = _id;
        m_errorData = _error;
        m_progress = _progress;
        m_ext = _ext;
    }
}