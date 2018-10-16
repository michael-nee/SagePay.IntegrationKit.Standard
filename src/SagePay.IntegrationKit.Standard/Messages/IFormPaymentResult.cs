namespace SagePay.IntegrationKit.Standard.Messages
{
    public interface IFormPaymentResult : IPaymentStatusResult
    {
        decimal Amount { get; set; }
    }
}
