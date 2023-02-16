namespace FormTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void UserText_TextChanged(object sender, EventArgs e) {

        }

        private void loginbutton_Click(object sender, EventArgs e) {
            if (UserText.Text == "btrfangril" && PasswordText.Text == "imbocchi727") {
                //new Form2().Show();
                //this.Hide();
                StatusText.Text = "Successful Login";
            }
            else {
                StatusText.Text = "Invalid Login";
            }
        }
    }
}