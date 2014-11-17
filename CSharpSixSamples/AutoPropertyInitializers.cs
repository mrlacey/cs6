using System;
using System.Collections.Generic;

namespace CSharpSixSamples
{
    class AutoPropertyInitializers
    {
        public AutoPropertyInitializers(string name)
        {
            // Set getter only properties in the constructor
            this.Name = name;

            // this is set by the property but can be overwritten here
            this.AnotherProperty = 7;
        }

        // Default values - All in one place, not via fields or a constructor
        public int MyProperty { get; private set; } = 5;
        
        // Immutability
        public List<string> MyList { get; } = new List<string>();

        // Fields too!
        public Guid id = Guid.NewGuid();

        // Not set here but an be set in the constructor
        public string Name { get; }

        // Can be overwritten in the constructor;
        public int AnotherProperty { get; } = 6;
    }
}
