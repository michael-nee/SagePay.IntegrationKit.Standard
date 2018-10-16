namespace SagePay.IntegrationKit.Standard.Messages
{
    public interface IServerNotificationResult : IMessage
    {
        ResponseStatus Status { get; set; }
        string StatusDetail { get; set; }
        string RedirectUrl { get; set; }
    }
}