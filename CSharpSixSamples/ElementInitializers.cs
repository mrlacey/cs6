using System.Collections.Generic;

namespace CSharpSixSamples
{
    public class ElementInitializers
    {
        public void LongHand()
        {
            var myDic = new Dictionary<string, string>();
            myDic.Add("reaction", "Woo!");
            myDic.Add("response", "Yeah!");
            myDic.Add("opinion", "These features are amazing!");
        }

        public void ShortHand()
        {
            var myDic = new Dictionary<string, string>
            {
                {"reaction", "Woo!" },
                { "response", "Yeah!" },
                { "opinion", "These features are amazing!" }
            };
        }

        public void EvenShorterHand()
        {
            var myDic = new Dictionary<string, string>
            {
                ["reaction"] = "Woo!",
                ["response"] = "Yeah!",
                ["opinion"] = "These features are amazing!"
            };
        }
    }
}
