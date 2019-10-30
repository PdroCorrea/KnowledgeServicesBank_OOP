using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace KnowledgeServicesBank
{
    [Serializable]
    [ExcludeFromCodeCoverage]
    public class OutOfFundException : Exception
    {
        public OutOfFundException(string message = "You do not have enough funds to execute this operation.") : base(message)
        {
        }

    }
}