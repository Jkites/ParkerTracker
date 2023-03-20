using Nito.AsyncEx;
using ParkerTracker;
using System.Diagnostics;

namespace FormTest {
    public partial class LoginScreen : Form {
        public LoginScreen() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void UserText_TextChanged(object sender, EventArgs e) {

        }

        private void loginbutton_Click(object sender, EventArgs e) {
            /*ShowInfo si = new ShowInfo(1);
            si.populateFields();
            Debug.Write(si.getName());*/           
            if (UserText.Text == "btrfangril" && PasswordText.Text == "imbocchi727") {
                new Form2().Show();
                this.Hide();
                //StatusText.Text = "Successful Login";
            }
            else {
                StatusText.Text = "Invalid Login";
            }
        }

        private void StatusText_TextChanged(object sender, EventArgs e) {

        }
    }
}