package Job;

import Job.core.AsyncJobManager;
import Job.core.CallBackPara;
import Job.core.SyncJobManager;
import Job.jobs.CatDo;
import Job.jobs.DogDo;


//Job模式
//单线程异步解决方案，将待完成的事务逻辑(JOB)划分为树形结构同步或异步执行
//优点:使用方便功能强大，不依赖特定语言特性通用性强
//缺点:大量使用lambda回调，出现错误较难定位。
public class Job
{
    public static void main(String[] args)
    {
        //JobTest();
        //SyncMgrTest();
        //AsyncMgrTest();
        BlendMgrTest();
    }

    public static void BlendMgrTest()
    {
        AsyncJobManager mgr01 = new AsyncJobManager(null);
        SyncJobManager mgr02 = new SyncJobManager(null);
        mgr02.addJob(new DogDo());
        mgr02.addJob(new CatDo());

        mgr01.addJob(new DogDo());
        mgr01.addJob(mgr02);
        mgr01.addJob(new CatDo());

        mgr01.run((CallBackPara para) ->
        {//成功
            System.out.println("猫狗之事已完毕！");
        }, (CallBackPara para) ->
        {//失败
            System.out.println("猫狗之事情有错！");
        }, (CallBackPara para) ->
        {//进度
            System.out.println("猫狗之事进度： " + para.m_progress);
        }, 0);



    }

    public static void AsyncMgrTest()
    {
        AsyncJobManager mgr = new AsyncJobManager(null);
        mgr.addJob(new DogDo());
        mgr.addJob(new CatDo());
        mgr.run((CallBackPara para) ->
        {
            System.out.println("猫狗之事已完毕！");
        }, (CallBackPara para) ->
        {
            System.out.println("猫狗之事情有错！");
        }, (CallBackPara para) ->
        {
            System.out.println("猫狗之事进度： " + para.m_progress);
        }, 1);
    }

    public static void SyncMgrTest()
    {
        SyncJobManager mgr = new SyncJobManager(null);
        mgr.addJob(new DogDo());
        mgr.addJob(new CatDo());
        mgr.run((CallBackPara para) ->
        {
            System.out.println("猫狗之事已完毕！");
        }, (CallBackPara para) ->
        {
            System.out.println("猫狗之事情有错！");
        }, (CallBackPara para) ->
        {
            System.out.println("猫狗之事进度： " + para.m_progress);
        }, 2);
    }

    public static void JobTest()
    {
        DogDo dogDo = new DogDo();
        dogDo.run((CallBackPara para) ->
        {//成功回调
            System.out.println(para.m_resultData);
        }, (CallBackPara para) ->
        {//错误回调
            System.out.println(para.m_errorData);
        }, (CallBackPara para) ->
        {//进度回调
            System.out.println("狗进食进度： " + para.m_progress);
        }, 3);
    }
}
