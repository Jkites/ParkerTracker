using JikanDotNet;
using JikanDotNet.Exceptions;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FormTest {
    [DataContract]
    internal class ShowInfo {
        [DataMember]
        protected int id { get; set; }
        [DataMember]
        protected string name { get; set; }
        [DataMember]
        protected string description {
            get; set;
        }
        [DataMember]
        protected Boolean airing { get; set; }
        /*[DataMember]
        protected Queue<string> entrys = new Queue<string>();*/
        [JsonConstructor]
        public ShowInfo(int id, string name, string description, Boolean airing) {
            this.id = id;
            this.name = name;
            this.description = description;
            this.airing= airing;
            /*for (int i = 0; i < entrys.Count; i++) {
                this.entrys.Enqueue(entrys.Dequeue());
            }*/
        }
        public ShowInfo(int id) {
            this.id = id;
            name = "Filler Name";
            description = "This is a description";
        }
        public ShowInfo() { 
            this.id = -1;
            name= "test";
            description="test description";
            airing = false;
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
        public void setID(int id) {
            this.id = id;
        }
        public void setDescription(string description) {
            this.description = description;
        }
        public void setName(string name) {
            this.name = name;
        }
        public void setAiring(bool airing) {
            this.airing = airing;
        }
        /*public void setEntrys(Queue<String> entrys) {
            for (int i = 0; i < entrys.Count; i++) {
                this.entrys.Enqueue(entrys.Dequeue());
            }
        }*/
        public Boolean isAiring() {
            return airing;
        }
        /*public void addEntry(string entry) {
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
        }*/
    }
}
