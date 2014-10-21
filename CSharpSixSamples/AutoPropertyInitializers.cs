using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSixSamples
{
    class AutoPropertyInitializers
    {
        public AutoPropertyInitializers(string name)
        {
            // Set getter only properties in the constructor
            // Note. CTP doesn't yet support this
            //this.Name = name;

            // TODO: confirm - what is the value of AnotherProperty when the constructor starts and completes - break on next line to prove
            //this.AnotherProperty = 6;
        }

        // Default values - All in one place, not via fields or a constructor
        public int MyProperty { get; private set; } = 5;
        
        // Immutability
        public List<string> MyList { get; } = new List<string>();

        // Fields too!
        public Guid id = Guid.NewGuid();

        // getter only auto-properties
        // Note. CTP doesn't yet support this
        //public string Name { get; }

        //pubilc int AnotherProperty { get; } = 6
    }
}
