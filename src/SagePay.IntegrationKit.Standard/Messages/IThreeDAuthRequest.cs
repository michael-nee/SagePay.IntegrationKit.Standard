namespace SagePay.IntegrationKit.Standard.Messages
{
    public interface IThreeDAuthRequest : IMessage
    {
        string Md { get; set; }
        string PaRes { get; set; }
    }
}