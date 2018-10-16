﻿namespace SagePay.IntegrationKit.Standard.Messages
{
    public interface IRepeatRequest : IMessage
    {
        ProtocolVersion VpsProtocol { get; set; }
        TransactionType TransactionType { get; set; }
        string Vendor { get; set; }
        string VendorTxCode { get; set; }
        decimal Amount { get; set; }
        string Currency { get; set; }
        string Description { get; set; }
        string RelatedVpsTxId { get; set; }
        string RelatedVendorTxCode { get; set; }
        string RelatedSecurityKey { get; set; }
        int RelatedTxAuthNo { get; set; }
        string Cv2 { get; set; }
    }
}