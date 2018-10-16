namespace SagePay.IntegrationKit.Standard.Messages
{
    public interface IBasicResult : IMessage
    {
        ProtocolVersion VpsProtocol { get; set; }
        ResponseStatus Status{ get; set; }
        string StatusDetail{ get; set; }
    }
}