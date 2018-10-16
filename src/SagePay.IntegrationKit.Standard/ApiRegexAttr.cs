using System;

namespace SagePay.IntegrationKit.Standard
{
    internal class ApiRegexAttr : Attribute
    {
        internal ApiRegexAttr(string pattern)
        {
            Pattern = pattern;
        }

        public string Pattern { get; }
    }
}