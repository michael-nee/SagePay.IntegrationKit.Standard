namespace SagePay.IntegrationKit.Standard.Messages
{
    public interface IServerPaymentResult : IPaymentResult
    {
        string NextUrl { get; set; }
    }
}