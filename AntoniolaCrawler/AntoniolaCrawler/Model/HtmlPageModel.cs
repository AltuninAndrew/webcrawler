using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AntoniolaCrawler.Model
{
    class HtmlPageModel
    {
        private readonly WebClient _webClient;
        private string _htmlPage;
        private readonly string _htmlUri;

        /*
         * parser
         * readonly Parser parser();
         */

        public HtmlPageModel(string uri)
        {
            _webClient = new WebClient();
            _htmlUri = uri;
        }

        public void Initialize()
        {
            DownloadHtmlPage(_htmlUri);
        }

        private void DownloadHtmlPage(string url)
        {
            new Task(() =>
            {
                _htmlPage = _webClient.DownloadString(url);
            }).Start();
        }

    }
}
