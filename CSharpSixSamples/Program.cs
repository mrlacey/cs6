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
            // Roslyn + some syntax improvements

            // http://roslyn.codeplex.com/wikipage?title=Language%20Feature%20Status

            // http://roslyn.codeplex.com/discussions/568820



            // New language features
            // solves a real problem AND better than a current work around





            // Auto-property enhancements
            // Expression bodied members
            // using Static
            // Await in catch and finally blocks
            // Exception filters
            // NameOf expressions *
            // Null Propogation operator (AKA Null-conditional)
            // Element and Index Initializers

            // string interpolation * - Coming but not yet in the preview
            // #pragma changes - Coming but not yet in the preview 



            // * still subject to change


            SetOutputHeading("Auto-Property enhancements");

            var ap = new AutoPropertyInitializers("Matt");
            Console.WriteLine(ap.Name);
            Console.WriteLine(ap.AnotherProperty);


            SetOutputHeading("Expression bodied members");

            var ebm = new ExpressionBodyMembers(4, 5);
            Console.WriteLine(ebm.Area);
            Console.WriteLine(ebm.GrowAreaByPercentage(20));


            SetOutputHeading("using Static");

            // Look at code to see what's new here


            SetOutputHeading("Await in catch and finally blocks");

            // Look at code to see what's new here


            SetOutputHeading("Exception filters");

            // Look at code to see what's new here


            SetOutputHeading("Null Propogation operator");

            var nullProp = new NullConditionalOrNullPropagation();

            nullProp.OldWay();
            nullProp.NewWay();
            nullProp.EvenBetterWay();
            nullProp.AsSingleLine();
            //nullProp.OnIndexersToo();


            SetOutputHeading("Element Index Initializers");

            // Look at code to see what's new here


            SetOutputHeading("'nameof' expressions");
            var nameof = new NameOfExpressions();
            nameof.ShowWhatCanNowBeDone("something");



            Console.ReadKey(true);
        }

        private static void SetOutputHeading(string heading)
        {
            Console.WriteLine("");
            Console.WriteLine(heading);
            Console.WriteLine("---------------------------------");
        }
    }
}
