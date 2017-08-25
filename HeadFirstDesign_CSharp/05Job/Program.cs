using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05Job
{
    //Job模式
    //单线程异步解决方案，将待完成的事务逻辑(JOB)划分为树形结构同步或异步执行
    //优点:使用方便功能强大，不依赖特定语言特性通用性强
    //缺点:大量使用lambda回调，出现错误较难定位。
    class Program
    {
        static void Main(string[] args)
        {
            //AnimalAction.JobTest();
            //AnimalAction.SyncMgrTest();
            //AnimalAction.AsyncMgrTest();
            AnimalAction.BlendMgrTest();
            Console.ReadLine();
        }
    }
    public class AnimalAction
    {
        public static void BlendMgrTest()
        {
            JobSerialManager mgr01 = new JobSerialManager();
            JobParallelManager mgr02 = new JobParallelManager();
            mgr02.addJob(new DogDo());
            mgr02.addJob(new CatDo());

            mgr01.addJob(new DogDo());
            mgr01.addJob(mgr02);
            mgr01.addJob(new CatDo());

            mgr01.run((CallBackPara para)=> {//成功
                Console.WriteLine("猫狗之事已完毕！");
            }, (CallBackPara para) => {//失败
                Console.WriteLine("猫狗之事情有错！");
            }, (CallBackPara para) => {//进度
                Console.WriteLine("猫狗之事进度： " + para.m_progress);
            });
        }

        public static void AsyncMgrTest()
        {
            JobSerialManager mgr = new JobSerialManager();
            mgr.addJob(new DogDo());
            mgr.addJob(new CatDo());
            mgr.run((CallBackPara para) => {
                Console.WriteLine("猫狗之事已完毕！");
            }, (CallBackPara para) => {
                Console.WriteLine("猫狗之事情有错！");
            }, (CallBackPara para) => {
                Console.WriteLine("猫狗之事进度： " + para.m_progress);
            });
        }

        public static void SyncMgrTest()
        {
            JobParallelManager mgr = new JobParallelManager();
            mgr.addJob(new DogDo());
            mgr.addJob(new CatDo());
            mgr.run((CallBackPara para)=> {
                Console.WriteLine("猫狗之事已完毕！");
            }, (CallBackPara para) => {
                Console.WriteLine("猫狗之事情有错！");
            }, (CallBackPara para) => {
                Console.WriteLine("猫狗之事进度： "+para.m_progress);
            });
        }
        public static void JobTest()
        {
            DogDo dogDo = new DogDo();
            dogDo.run((CallBackPara para)=> {//成功回调
                Console.WriteLine(para.m_resultData as string);
            }, (CallBackPara para) => {//错误回调
                Console.WriteLine(para.m_errorData as string);
            }, (CallBackPara para) => {//进度回调
                Console.WriteLine("狗进食进度： "+para.m_progress);
            });
        }
    }
    public class DogDo:JobBase
    {
        protected override void onRun()
        {
            Console.WriteLine("狗开吃:");
            onProgress(10);
            onProgress(50);
            onSuccess("狗进食成功！");
            //onError("狗不吃东西！");
        }
        protected override void onDispose()
        {
            Console.WriteLine("狗拉出去溜...");
        }
    }
   public class CatDo:JobBase
    {
        protected override void onRun()
        {
            Console.WriteLine("猫开拉:");
            onProgress(10);
            onProgress(50);
            onSuccess("猫拉屎成功！");
            //onError("猫拉不出屎！");
        }
        protected override void onDispose()
        {
            Console.WriteLine("猫拉出去溜...");
        }
    }
}
