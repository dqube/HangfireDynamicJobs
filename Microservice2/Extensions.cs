using Hangfire;

namespace Microservice2
{
    public static class Extensions
    {
        public static void UseRecurringJobs(this WebApplication app)
        {
            IRecurringJobManager manager = new RecurringJobManager(); // or obtain instance using dependency injection

            manager.AddOrUpdateDynamic<IOrderSubmitter>("order-submitter", x => x.SubmitOrder(1, "Success"), Cron.Never());

        }
    }
}
