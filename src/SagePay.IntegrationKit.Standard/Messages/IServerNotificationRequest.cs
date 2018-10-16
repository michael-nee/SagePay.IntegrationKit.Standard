namespace SagePay.IntegrationKit.Standard.Messages
{
    public interface IServerNotificationRequest : IPaymentStatusResult
    {
        TransactionType TransactionType { get; set; }
        string VpsSignature { get; set; }
    }
}