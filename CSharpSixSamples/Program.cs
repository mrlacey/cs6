using System;
using System.Collections.Generic;

namespace CSharpSixSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // History (a summary)
            // http://en.wikipedia.org/wiki/C_Sharp_(programming_language)#Versions

            // 1.0 - 2002 (1.2 - 2003)

            // 2.0 - 2005
            // Generics, partial types, iterators, static classes, ...

            // 3.0 - 2007
            // Lambda expressions, Extension methods, auto-properties, ...

            // 4.0 - 2010
            // Dynamics (DLR), named and optional arguments, ...

            // 5.0 - 2012
            // async/await, caller info attributes

            // 6.0 - 2014
            // Roslyn + lots of lovely syntax improvements

            // Because we're using new features, in the CTP, we need to modify the .csproj file
            // to set the LangVersion to be "experimental"
            // This is done on  per configuration basis.
            // I've only enabled it for Debug, so if you switch to Release you'll see errors


            var nameof = new NameOfExpressions();
            nameof.ShowWhatCanNowBeDone("something");


            Console.ReadKey(true);
        }
    }
}
