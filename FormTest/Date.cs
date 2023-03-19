using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkerTracker {
    internal class Date { //class for changing from jst to pst
        string day="Not valid";
        string time="Not valid";
        String[] daysofweek = {"Mondays","Tuesdays", "Wednesdays", "Thursdays", "Fridays","Saturdays","Sundays"};
        public Date(string day, string time) {
            this.day = day;
            this.time = time;
        }
        public Date(string raw_str) {
            parseString(raw_str);
        }
        private void parseString(string str) {
            string[] substrings = str.Split(' ');
            int counter = 0;
            int dayint=0; //placeholder
            for (int i = substrings.Length; i >= 0; i--) {
                if (substrings.Length >= 3) {
                    if (i == 0) { //day of week
                        for (int k =0; k < daysofweek.Length; k++) {
                            if (substrings[i] == daysofweek[k]) {
                                dayint = k;
                            }
                        }
                        if (dayint - counter < 0) {
                            day = daysofweek[substrings.Length-1];
                        }
                        else{
                            day = daysofweek[dayint-counter];
                        }
                    }
                    else if (i == 2) { //time
                        String[] substrings2 = substrings[i].Split(":");
                            int firsthalf = Int32.Parse(substrings2[0]) - 16; //hour difference
                            if (firsthalf < 0) {
                                firsthalf = 24-Math.Abs(firsthalf); //if negative value of time
                                counter++;
                            time = firsthalf + ":" + substrings2[1];
                        }
                    }
                }
            }
        }

        public override string ToString() {
            return day + " at " + time +" PST (without daylight savings time)";
        }


    }
}
