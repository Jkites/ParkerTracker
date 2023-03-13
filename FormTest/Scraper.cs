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

        public Scraper(int id) {
            this.scraperUrl = "https://myanimelist.net/anime/" + id;
        }
        private static async Task<string> callUrl(string fullUrl) {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(fullUrl);
            Debug.WriteLine(response);
            return response;
        }
        public async void runStuff() {
            await callUrl(scraperUrl);
        }
        private void runStuff2() {

        }
        
    }
}
