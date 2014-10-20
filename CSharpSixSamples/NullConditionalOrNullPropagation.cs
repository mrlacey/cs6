using System;

namespace CSharpSixSamples
{
    public class NullConditionalOrNullPropagation
    {
        public void OldWay()
        {
            var cust = GetCustomer();

            string postcode = "not set";

            if (cust != null && cust.Address != null && cust.Address.Postcode != null)
            {
                postcode = cust.Address.Postcode;
            }

            Console.WriteLine(postcode);
        }

        public void NewWay()
        {
            var cust = GetCustomer();

            string postcode = "not set";

            var actualPostcode = cust?.Address?.Postcode;

            if (actualPostcode != null)
            {
                postcode = actualPostcode;
            }

            Console.WriteLine(postcode);
        }

        public void EvenBetterWay()
        {
            // With null coalescing too!
            var cust = GetCustomer();

            string postcode = cust?.Address?.Postcode ?? "not set";

            Console.WriteLine(postcode);
        }


        private Customer GetCustomer()
        {
            return new Customer
            {
                Address = new Address
                {
                    Line1 = "House name",
                    Line2 = "Street Name"
                }
            };
        }

        public class Customer
        {
            public Address Address { get; set; }
        }

        public class Address
        {
            public string Line1 { get; set; }
            public string Line2 { get; set; }
            public string Line3 { get; set; }
            public string Line4 { get; set; }
            public string Postcode { get; set; }
        }
    }
}
