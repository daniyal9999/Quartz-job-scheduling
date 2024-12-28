using Quartz;
using Quartz.Impl;

class Program
{
    static async Task Main(string[] args)
    {
        // 1. Create a scheduler
        IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
        await scheduler.Start();

        // 2. Define the job and tie it to our ExampleJob class
        IJobDetail job = JobBuilder.Create<ExampleJob>()
            .WithIdentity("exampleJob", "group1")
            .Build();

        // 3. Create a trigger that runs every 5 seconds
        ITrigger trigger = TriggerBuilder.Create()
            .WithIdentity("exampleTrigger", "group1")
            .StartNow()
            .WithSimpleSchedule(x => x
                .WithIntervalInSeconds(5)
                .RepeatForever())
            .Build();

        // 4. Schedule the job using the trigger
        await scheduler.ScheduleJob(job, trigger);

        Console.WriteLine("Press [Enter] to close the application.");
        Console.ReadLine();

        // 5. Shutdown the scheduler gracefully
        await scheduler.Shutdown();
    }
}

// Example Job
public class ExampleJob : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        Console.WriteLine($"Job executed at: {DateTime.Now}");
        return Task.CompletedTask;
    }
}
