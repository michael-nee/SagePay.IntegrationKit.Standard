﻿namespace SagePay.IntegrationKit.Standard
{
    public enum TransactionType
    {
        NONE,
        PAYMENT,
        DEFERRED,
        AUTHENTICATE,
        TOKEN,
        REMOVETOKEN,
        ABORT,
        REFUND,
        CANCEL,
        VOID,
        RELEASE,
        COMPLETE,
        REPEAT,
        REPEATDEFERRED,
        MANUAL,
        DIRECTREFUND,
        AUTHORISE
    }
}