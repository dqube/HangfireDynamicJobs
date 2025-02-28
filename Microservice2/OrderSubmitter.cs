namespace Microservice2;

public class OrderSubmitter : IOrderSubmitter
{
    public void SubmitOrder(long orderId, string status)
    {
        Console.WriteLine($"Submitting order {orderId} with status {status}");
    }
}
