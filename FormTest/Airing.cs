using FormTest;
using JikanDotNet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkerTracker {
    internal class Airing : ShowInfo{
        string broadcast;
        string day;
        string timezone;
        public Airing (int id) : base(id) {}
        protected override async Task<Boolean> populateFieldInternal() { //add the unique stuff like airing schedule or something probably need to implement date class based off of that though
            await base.populateFieldInternal();
            var jikan = new Jikan();
            var anime = await jikan.GetAnimeAsync(id);
            broadcast = anime.Data.Broadcast.Time; //time in JST
            day = anime.Data.Broadcast.Day; // in JST
            timezone = anime.Data.Broadcast.String;
            Debug.WriteLine(timezone);
            Date date = new Date(timezone);
            Debug.WriteLine(date.ToString());
            return true;
        }
    }
}
