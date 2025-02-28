namespace Microservice2;

public interface IOrderSubmitter
{
    void SubmitOrder(long orderId, string status);
}
