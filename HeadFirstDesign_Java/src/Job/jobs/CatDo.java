package Job.jobs;
import Job.core.JobBase;

public class CatDo extends JobBase
{
    protected void onRun()
    {
        System.out.println("猫开拉:");
        onProgress(10, null);
        onProgress(50, null);
        onSuccess("猫拉屎成功！", null);
        //onError("猫拉不出屎！");
    }

    protected void onDispose()
    {
        System.out.println("猫拉出去溜...");
    }
}
