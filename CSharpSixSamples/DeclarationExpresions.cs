
using System;

namespace CSharpSixSamples
{
    // CUT!!!
    public class DeclarationExpresions
    {
        public int OldWay()
        {
            int number;
            TryGetMagicNumber(out number);

            return number;
        }

        private bool TryGetMagicNumber(out int number)
        {
            number = 3; // https://www.youtube.com/watch?v=0irL1M15DH8
            return true;
        }

        public int NewWay()
        {
            TryGetMagicNumber(out var result);
            return result;
        }

        public void InAnIfStatement()
        {
            if ((var magicNo = NewWay()) != 3)
            {
                Console.WriteLine("De La Soul got it wrong. The magic number is " + magicNo);
            }
        }
    }
}
