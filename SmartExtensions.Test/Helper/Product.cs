using System;
using Xunit;
using System.Linq;


namespace SmartExtensions.Tests.Helper
{
    [Serializable]
    public class PurchaseOrder
    {
        public Address MyAddress;
    }
    
    [Serializable]
    public class Address
    {
        public string FirstName;
    }
}