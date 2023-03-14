using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace ParkerTracker {
    internal class Scraper {
        private string scraperUrl;
        HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument();

        public Scraper(int id) {
            this.scraperUrl = "https://myanimelist.net/anime/" + id;
        }
        private static async Task<string> callUrl(string fullUrl) {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(fullUrl);
            //Debug.WriteLine(response);
            return response;
        }
        public async void runStuff() { //parse html
            string htmlfile = await callUrl(scraperUrl);
            htmldoc.LoadHtml(htmlfile);
           // var parsedfile = htmldoc.DocumentNode.SelectNodes("//div[@id=\"content\"]"); //, 'p itemprop=\"description\"'))]");
            var prasedfile = htmldoc.DocumentNode.Descendants("td")
                .Where(node => node.GetAttributeValue("valign", "").Contains("top"))
                .ToList();
            Debug.WriteLine(prasedfile[0].InnerText);
        }
        
    }
}
