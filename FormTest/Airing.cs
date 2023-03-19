using FormTest;
using JikanDotNet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ParkerTracker {
    [DataContract]
    internal class Airing : ShowInfo{
        [DataMember]
        Date date { get; set; }
        
        public Airing (int id, Date date, string name, string description, Boolean airing) : base(id, name, description, airing) {
            this.date = new Date(date.getDay(), date.getTime());
        }
        public Airing (int id) : base(id) { date=new Date(); }
        public Airing () : base() { date = new Date(); }
        protected override async Task<Boolean> populateFieldInternal() { //add the unique stuff like airing schedule or something probably need to implement date class based off of that though
            await base.populateFieldInternal();
            var jikan = new Jikan();
            var anime = await jikan.GetAnimeAsync(id);
            string timezone = anime.Data.Broadcast.String;
            Debug.WriteLine(timezone);
            date = new Date(timezone);
            Debug.WriteLine(date.ToString());
            /*string jsonstring = JsonSerializer.Serialize(this);
            Debug.WriteLine(jsonstring);*/
            return true;
        }
        public Date getDate() {
            return date;
        }
        public void setDate(Date date) {
            this.date = new Date(date.getDay(),date.getTime());
        }
        public override string ToString() {
            return name +" - "+ description + date.ToString();
        }
    }
}
