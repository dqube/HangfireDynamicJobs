using Hangfire;

namespace Microservice1
{
    public static class Extensions
    {
        public static void UseRecurringJobs(this WebApplication app)
        {
            IRecurringJobManager manager = new RecurringJobManager(); // or obtain instance using dependency injection

            manager.AddOrUpdateDynamic<INewsletterSender>("newsletter-sender", x => x.SendNewsLetter(1), Cron.Never());

        }
    }
}
