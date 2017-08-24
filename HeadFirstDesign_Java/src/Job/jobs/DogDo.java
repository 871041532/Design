package Job.jobs;

import Job.core.JobBase;

public class DogDo extends JobBase
{
    protected void onRun()
    {
        System.out.println("狗开吃:");
        onProgress(10, null);
        onProgress(50, null);
        onSuccess("狗进食成功！", null);
        //onError("狗不吃东西！");
    }

    protected void onDispose()
    {
        System.out.println("狗拉出去溜...");
    }
}
