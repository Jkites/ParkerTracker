using JikanDotNet;
using JikanDotNet.Exceptions;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTest {
    internal class ShowInfo {
        private int id;
        private string name;
        private string description;
        private Queue<string> entrys = new Queue<string>();

        public ShowInfo(int id, string name, string description) {
            this.id = id;
            this.name = name;
            this.description = description;
        }
        public ShowInfo(int id) {
            this.id = id;
        }
        private async Task<String> populateFieldInternal() {
            var jikan = new Jikan();
            try {
                var anime = await jikan.GetAnimeAsync(this.id); //need to add check if id is a valid one....
            //JikanDotNet.Exceptions.JikanRequestException: 'GET request failed. Status code: NotFound Inner message: System.Net.Http.HttpConnectionResponseContent
            
                name = anime.Data.TitleEnglish;
                description = anime.Data.Synopsis;
            } catch (JikanRequestException ex) {
                name = "Could not find"+id;
                description = "Not found";
            }

            return name;
        }
        public void populateFields() {
            AsyncContext.Run(populateFieldInternal);
        }
        public string getName() {
            return name;
        }
        public string getDescription() {
            return description;
        }
        public int getID() {
            return id;
        }
        public void addEntry(string entry) {
            entrys.Enqueue(entry);
        }
        public String getEntryString() {
            Queue<string> temp_entrys = new Queue<string>(entrys);
            string entry = "";
            while (entrys.Count > 0) {
                entry+= entrys.Dequeue();
                entry += "\n";
            }
            return entry;
        }
    }
}
