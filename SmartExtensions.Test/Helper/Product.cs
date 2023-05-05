using System;

namespace SmartExtensions.Test.Helper
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