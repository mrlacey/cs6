using System;
using System.Diagnostics;

namespace CSharpSixSamples
{
    public class NameOfExpressions
    {
        [Conditional("DEBUG")]
        public void ShowWhatCanNowBeDone(string someParam)
        {
            Console.WriteLine(nameof(ConditionalAttribute));
            Console.WriteLine(nameof(NameOfExpressions));
            Console.WriteLine(nameof(ShowWhatCanNowBeDone));
            Console.WriteLine(nameof(someParam));
        }
    }
}
