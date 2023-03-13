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
    public partial class Form2 : Form {
        Stack<Panel> panels = new Stack<Panel>();
        Panel currentpanel;
        public Form2() {
            InitializeComponent();
            EntryPanel.Hide();
            //StarPanel.Hide();

        }
        private void populateText() {

        }

        private void button1_Click(object sender, EventArgs e) { //home button on home panel

        }

        private void EntryButton_Click(object sender, EventArgs e) {
            HomePanel.Hide();
            panels.Push(HomePanel);
            EntryPanel.Show();
            currentpanel = EntryPanel;
            Debug.WriteLine("Going Entry, adding Home to Stack");
        }

        private void StarButton_Click(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e){ //homebutton on Entry page 
            EntryPanel.Hide();
            panels.Push(EntryPanel);
            HomePanel.Show();
            currentpanel = HomePanel;
            Debug.WriteLine("Going Home, adding entry to stack");
        }

        private void BackButton_Click(object sender, EventArgs e) {
            if (panels.Count > 0) {
                currentpanel.Hide();
                currentpanel=panels.Pop();
                currentpanel.Show();
                
            }
            else {
                Debug.WriteLine("Unsuccessful because stack is empty?");
            }
        }
    }
}
