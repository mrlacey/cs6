
using System;
using System.Collections.Generic;

namespace CSharpSixSamples
{
    public class OldPrimaryConstructor
    {
        public OldPrimaryConstructor(string someProperty)
        {
            this.SomeProperty = someProperty;
        }

        public string SomeProperty { get; private set; }
    }

    public class NewPrimaryConstructor(string someProperty)
    {

    }

    public class AutoPropertyInitializer
    {
        // Default values - All in one place, not via fields or a constructor
        public int MyProperty { get; set; } = 5;

        // Immutability
        public List<string> MyList { get; } = new List<string>();

        // Fields too!
        public Guid id = Guid.NewGuid();
    }

    public class NewPrimaryConstructorAndAutoPropertyInitializer(string id)
    {
        public string Id { get; } = id;
    }

    public class MultipleConstructors(string id)
    {
        public MultipleConstructors() : this(null)
        {
        }

        public MultipleConstructors(string id, string name) : this(id)
        {
            // Additional properties, not from variables in the default constructor 
            // Should be set like before
            this.Name = name;
        }

        public string Id { get; set; } = id;

        public string Name { get; set; } // = name; // This doesn't work because "name" isn't known at default class constructor time
    }

    public class DefaultParameterlessConstructor()
    {
        // Note that we have to reference the default constructor
        public DefaultParameterlessConstructor(string id) : this()
        {
            this.Id = id;
        }

        public string Id { get; set; }
    }

    public class AutoPropertyValidationWithPrimaryConstructors(string id)
    {
        public string Id { get; protected set; } = Verify.NotNullOrWhitespace(id);
    }

    public static class Verify
    {
        internal static string NotNullOrWhitespace(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException();
            }

            return value;
        }
    }
}
