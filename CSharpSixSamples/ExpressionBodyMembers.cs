using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpSixSamples
{
    public class ExpressionBodyMembers
    {
        public ExpressionBodyMembers(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public List<string> MyList { get; set; } = new List<string>();
               
        // It's a property-like function member - consume it like a getter only property
        // The "get" keyword is implied
        public int Area => Width * Height;

        // The above is the same as this
        public int OldStyleArea
        {
            get
            {
                return Width * Height;
            }
        }

        // We can use indexers here too
        public string this[int id] => MyList[id];

        // Like a single line method
        public float GrowAreaByPercentage(int percentage) => ((float)Area / 100) * (100 + percentage);

        // Can be used for methods that return void
        public void WriteToLog() => Console.WriteLine(this.ToString());

        // Works with async/await
        public async Task<int> PauseThenReturnAreaPlusX(int x) => await PauseThenReturn(Area + x);

        // Helper method as expression body must be a single statement
        private async Task<int> PauseThenReturn(int toReturn)
        {
            await Task.Delay(3000);

            return toReturn;
        }
    }
}
