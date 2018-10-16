namespace SagePay.IntegrationKit.Standard
{
    public enum FraudResponse
    {
        NONE,
        ACCEPT, 
        DENY, 
        CHALLENGE, 
        NOTCHECKED,
        TIMEOUT
    }
}