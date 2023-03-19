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
        protected int id;
        protected string name;
        protected string description;
        protected Boolean airing;
        protected Queue<string> entrys = new Queue<string>();

        public ShowInfo(int id, string name, string description) {
            this.id = id;
            this.name = name;
            this.description = description;
        }
        public ShowInfo(int id) {
            this.id = id;
            name = "Filler Name";
            description = "This is a description";
        }
        protected virtual async Task<Boolean> populateFieldInternal() {
            var jikan = new Jikan();
            try {
                var anime = await jikan.GetAnimeAsync(id);
                name = anime.Data.TitleEnglish;
                description = anime.Data.Synopsis;
                description = description.Replace("\n", "\r\n"); //so it outputs correctly in textbox
                airing = anime.Data.Airing;
                return true;
            } catch (JikanRequestException ex) {
                name = "ID invalid or does not exist";
                description = "Not found";
                return false;
            }
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
        public Boolean isAiring() {
            return airing;
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
