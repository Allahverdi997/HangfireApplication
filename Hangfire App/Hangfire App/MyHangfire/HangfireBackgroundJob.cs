using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Hangfire_App.Process;

namespace Hangfire_App.MyHangfire
{
    public class HangfireBackgroundJob
    {
         public static void Operation()
         {
            //BackgroundJob.Enqueue<IWirteFile>(h => h.Write($"{DateTime.Now.ToLongDateString()}-"));
            //var jobId=BackgroundJob.Schedule<IWirteFile>(h => h.Write($"Scheduled {DateTime.Now.ToLongDateString()}-"),DateTimeOffset.Now.AddMinutes(1));
            //BackgroundJob.ContinueJobWith<IWirteFile>(jobId,h => h.Write($"Scheduled {DateTime.Now.ToLongDateString()}-"));
            RecurringJob.AddOrUpdate<IWirteFile>(h => h.Write($"Recurring {DateTime.Now.ToLongDateString()}-"),Cron.MinuteInterval(2));
        }
    }
}
