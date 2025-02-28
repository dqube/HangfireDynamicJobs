using Hangfire;

namespace Microservice1;

[LogJobs]
[Queue("newsletter")]
public class NewsletterSender : INewsletterSender
{
    [DisableConcurrentExecution(60)]
    public void SendNewsLetter(long campaignId)
    {
        Console.WriteLine($"Processing newsletter '{campaignId}'");
    }
}
