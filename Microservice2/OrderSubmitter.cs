using Hangfire;

namespace Microservice2;

[LogJobs]
[Queue("ordersubmitter")]
public class OrderSubmitter : IOrderSubmitter
{
    [DisableConcurrentExecution(60)]
    public void SubmitOrder()
    {
        Console.WriteLine($"Submitting order");
    }
}
