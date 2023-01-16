using System.Diagnostics.CodeAnalysis;

namespace DZ1
{
    class Account
    {
        public double GetBalance { get; set; }
        public bool Deposit { get; set; }
        public bool Withdraw { get; set; }
        private double Balance { get; set; }
        
    }

    class CreditAccount : Account
    {
        private double MaximumCredit { get; set; }
        public double GetCredit { get; set; }

    }

    class Client
    {
        public int GetId { get; set;}
    }

    class Person : Client
    {
        private string FirstName { get; set; }
        private string Family { get; set; }
        public string getFulName { get; set; }
        AddressKind Kind { get; set; }

        class AddressKind : Person
        {
            public string HOME;
            public string OFFICE;
        }
    }


    public class Address
    {
        private string Street { get; set; }
        private string State { get; set; }
        private string City { get; set; }
        private string Country { get; set; }
        private string zip { get; set; }
        public string GetFulAdress { get; set; }
    }
    public class Organization
    {
        Address Address;
        public Organization()
        {
            Address = new Address();
        }
        private string title { get; set; }
    }

}