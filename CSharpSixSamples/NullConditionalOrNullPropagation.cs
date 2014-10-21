using System;
using System.Collections.Generic;

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

        public void AsSingleLine()
        {
            Console.WriteLine(GetCustomer()?.Address?.Postcode ?? "not set");
        }

        public void OnIndexersToo()
        {
            var orderAmounts = new Dictionary<int, double>();
            orderAmounts.Add(1, 12.99);
            orderAmounts.Add(2, 2.99);
            orderAmounts.Add(3, 100.99);
            orderAmounts.Add(4, 7.49);

            Console.WriteLine(orderAmounts?[2].ToString() ?? "unknown order");
            Console.WriteLine(orderAmounts?[7].ToString() ?? "unknown order");
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
