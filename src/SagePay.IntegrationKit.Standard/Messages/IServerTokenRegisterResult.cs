namespace SagePay.IntegrationKit.Standard.Messages
{
    public interface IServerTokenRegisterResult : IPaymentResult
    {
        string NextUrl { get; set; }
    }
}