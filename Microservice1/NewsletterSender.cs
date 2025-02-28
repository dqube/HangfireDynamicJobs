using Hangfire;

namespace Microservice1;

[Queue("newsletter")]
public class NewsletterSender : INewsletterSender
{
    public void SendNewsLetter(long campaignId)
    {
        Console.WriteLine($"Processing newsletter '{campaignId}'");
    }
}
