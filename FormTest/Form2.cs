using Newtonsoft.Json;
using ParkerTracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest {
    public partial class Form2 : Form { //needs the list of ShowInfos that are SAVED so also create that file reader class
        Stack<Panel> panels = new Stack<Panel>();
        Panel currentpanel;
        ShowInfo temp_show;
        List<Airing> airings = new List<Airing>();
        List<ShowInfo> completed_shows = new List<ShowInfo>();
        public Form2() {
            InitializeComponent();
            currentpanel = HomePanel;
            EntryPanel.Hide();
            StarPanel.Hide();   
            populateText();

        }
        private void populateText() {
            //something populate main page with schedule
            byte[] fileinfo = new byte[1];
            string filecontents = "";
            try {
                fileinfo = File.ReadAllBytes("AiringShows.json");
                filecontents = File.ReadAllText("AiringShows.json");
                Debug.WriteLine(filecontents);
            } catch (FileNotFoundException e) {
                Debug.WriteLine(e.Message);
            }
            try {
                //var ms = new MemoryStream(Encoding.UTF8.GetBytes(filecontents));
                //var ser = new DataContractJsonSerializer(airings.GetType());
                //var v2 = ser.ReadObject(ms) as List<Airing>;
                //var utf = new Utf8JsonReader(fileinfo);
                List<Airing> airingstemp = JsonConvert.DeserializeObject<List<Airing>>(filecontents);
                //ms.Close();
                for (int i = 0; i < airingstemp.Count; i++) {
                    airings.Add((Airing)airingstemp[i]);
                    Debug.WriteLine(airingstemp[i]);
                    AiringScheduleText.Text = AiringScheduleText.Text + "\r\n" + airingstemp[i];
                }
            }catch(SerializationException e) { Debug.WriteLine(e.Message); }
            
        }

        private void button1_Click(object sender, EventArgs e) { //home button on home panel

        }

        private void EntryButton_Click(object sender, EventArgs e) {
            currentpanel.Hide();
            panels.Push(currentpanel);
            EntryPanel.Show();
            currentpanel = EntryPanel;
            Debug.WriteLine("Going Entry, adding" + currentpanel.Name + "to Stack");
        }

        private void StarButton_Click(object sender, EventArgs e) {
            currentpanel.Hide();
            panels.Push(currentpanel);
            StarPanel.Show();
            currentpanel = StarPanel;
            Debug.WriteLine("going star, add " + currentpanel.Name + "to Stack");
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) { //homebutton on Entry page 
            populateText();
            currentpanel.Hide();
            panels.Push(currentpanel);
            HomePanel.Show();
            currentpanel = HomePanel;
            Debug.WriteLine("Going Home, adding " + currentpanel.Name + " to stack");
        }

        private void BackButton_Click(object sender, EventArgs e) {
            if (panels.Count > 0) {
                currentpanel.Hide(); //original panel
                currentpanel = panels.Pop();
                currentpanel.Show(); //new panel

            }
            else {
                Debug.WriteLine("Unsuccessful because stack is empty?");
            }
        }
        //32281 your name test //49387 vinland saga airing test
        private void SearchButton_Click(object sender, EventArgs e) { //use SearchIntBox
            StarButton_Click(sender, e);
            int id = Convert.ToInt32(Math.Round(SearchIntBox.Value, 0));
            temp_show = new ShowInfo(id);
            temp_show.populateFields();
            ShowInformationBox.Text = "" + temp_show.getName() + " - " + temp_show.getID() + "\r\n" + temp_show.getDescription();
        }

        private void ValidTitlesBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void HomeButtonEmpty2_Click(object sender, EventArgs e) {
            button3_Click(sender, e);
        }

        private void EntryButtonEmpty2_Click(object sender, EventArgs e) {
            EntryButton_Click(sender, e);
        }

        private void StarButton2_Click(object sender, EventArgs e) {
            StarButton_Click(sender, e);
        }

        private void SaveButtonStar_Click(object sender, EventArgs e) {
            //uise show info check if the show is airing or not. If airing create airing object, if not continue with showinfo object
            if (temp_show.isAiring()) {
                Airing temp_airing = new Airing(temp_show.getID());
                temp_airing.populateFields();
                airings.Add(temp_airing);
                var ser = new DataContractJsonSerializer(typeof(List<Airing>)); //crazy right adding the objects into a list solved the issue of finding multiple per json
                MemoryStream stream1 = new MemoryStream(); //well kind of , protected methdos that the json could not reach, so I needed to create new construtors that the Json file could use to update object fields
                ser.WriteObject(stream1, airings);
                //stream1.Position = 0;
                //var sr = new StreamReader(stream1);
                //string jsonstring = sr.ReadToEnd();
                byte[] json = stream1.ToArray();
                stream1.Close();
                Debug.WriteLine(json);
                string jsonstring = Encoding.UTF8.GetString(json, 0, json.Length);
                File.WriteAllText("AiringShows.json", jsonstring);
            }
            else {

            }
        }
    }
}
