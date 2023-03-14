using JikanDotNet;
using System;
using System.Collections.Generic;
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
        public async Task<String> populateFields() {
            IJikan jikan = new Jikan();
            var anime = await jikan.GetAnimeAsync(this.id);
            name = anime.Data.TitleEnglish;
            return name;
        }
        private string populateSynopsis(Anime anime) {
            return anime.Synopsis;
        }
        public string getName() {
            return name;
        }
        public string getDescription() {
            return description;
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
