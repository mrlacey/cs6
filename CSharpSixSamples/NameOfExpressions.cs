using System;
using System.Diagnostics;

namespace CSharpSixSamples
{
    public class NameOfExpressions
    {
        [Conditional("DEBUG")]
        public void ShowWhatCanNowBeDone(string someParam)
        {
            // No magic string literals or reflection needed for class names
            Console.WriteLine(nameof(NameOfExpressions));

            // No magic string literals or reflection needed for method names
            Console.WriteLine(nameof(ShowWhatCanNowBeDone));

            // No magic string literals or reflection needed for parameter names
            Console.WriteLine(nameof(someParam));

            // No magic string literals or reflection needed for Attribute names
            Console.WriteLine(nameof(ConditionalAttribute));

            // Can also work by addressing objects with dot syntax
            //Console.WriteLine(nameof(Customer.Address.Postcode));
            // Above would print "Postcode"
        }
    }
}
