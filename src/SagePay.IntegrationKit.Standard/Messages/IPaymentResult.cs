namespace SagePay.IntegrationKit.Standard.Messages
{
    public interface IPaymentResult : IBasicResult
    {
        string VpsTxId { get; set; }
        string SecurityKey { get; set; }
    }
}
