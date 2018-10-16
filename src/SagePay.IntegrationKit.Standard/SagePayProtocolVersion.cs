using System;

namespace SagePay.IntegrationKit.Standard
{
    public class SagePayProtocolVersion : Attribute
    {
        internal SagePayProtocolVersion(ProtocolVersion min)
        {
            Min = min;
        }

        public ProtocolVersion Min { get; private set; }
    }
}