using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest {
    public partial class Form2 : Form { //needs the list of ShowInfos that are SAVED so also create that file reader class
        Stack<Panel> panels = new Stack<Panel>();
        Panel currentpanel;
        public Form2() {
            InitializeComponent();
            currentpanel = HomePanel;
            EntryPanel.Hide();
            StarPanel.Hide();
            populateText();

        }
        private void populateText() {
            //something populate main page with schedule
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
        //32281
        private void SearchButton_Click(object sender, EventArgs e) { //use SearchIntBox
            StarButton_Click(sender, e);
            int id = Convert.ToInt32(Math.Round(SearchIntBox.Value, 0));
            ShowInfo temp_show = new ShowInfo(id);
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
    }
}
