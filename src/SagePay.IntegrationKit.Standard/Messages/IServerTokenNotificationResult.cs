namespace SagePay.IntegrationKit.Standard.Messages
{
    public interface IServerTokenNotificationResult : IMessage
    {
        ResponseStatus Status { get; set; }
        string StatusDetail { get; set; }
        string RedirectUrl { get; set; }
    }
}