using ParkerTracker;

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
            Scraper s = new Scraper(9253);
            s.runStuff();
            //new Form2().Show();
            //this.Hide();
            if (UserText.Text == "btrfangril" && PasswordText.Text == "imbocchi727") {
                
                StatusText.Text = "Successful Login";
            }
            else {
                StatusText.Text = "Invalid Login";
            }
        }
    }
}