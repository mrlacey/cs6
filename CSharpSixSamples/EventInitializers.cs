using System;

namespace CSharpSixSamples
{
    // This doesn't work yet!!!
    public class EventInitializers
    {
        public void Basic()
        {
            var client = new WebClient();
            client.BaseAddress = "http://example.com/";
            client.DownloadDataCompleted += DownloadDataCompletedHandler;
        }

        public void OldInitializers()
        {
            var client = new WebClient
            {
                BaseAddress = "http://example.com/"
            };
            client.DownloadDataCompleted += DownloadDataCompletedHandler;
        }

        public void NowWithMoreInitializerGoodness()
        {
            var client = new WebClient
            {
                BaseAddress = "http://example.com/",
                //DownloadDataCompleted += DownloadDataCompletedHandler
            };
        }

        private void DownloadDataCompletedHandler(object sender, DownloadDataCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
