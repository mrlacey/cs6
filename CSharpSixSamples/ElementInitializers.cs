
namespace CSharpSixSamples
{
    public class ElementInitializers
    {
        public void OldWayFoDictionaries()
        {
            var myDic = new Dictionary<string, string>
            {
                {"reaction", "Woo!" },
                { "response", "Yeah!" },
                { "opinion", "These features are amazing!" }
            };
        }

        public void NowWithSimplerSyntax()
        {
            var myDic = new Dictionary<string, string>
            {
                ["reaction"] = "Woo!",
                ["response"] = "Yeah!",
                ["opinion"] = "These features are amazing!"
            };
        }
    }

    public class IndexedMembers
    {
        // Yet another thing that will hopefully work by RTM
        //public void NowWithSimplerSyntax()
        //{
        //    var myDic = new Dictionary<string, string>
        //    {
        //        $Reaction = "Woo!",
        //        $Response=  "Yeah!",
        //        $Opinion = "These features are amazing!"
        //    };

        //    Console.WriteLine(myDic.$reaction);
        //}
    }

}
