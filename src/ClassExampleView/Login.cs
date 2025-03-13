using ClassExampleController;


namespace ClassExample
{
    /// <summary>
    /// Login form of the application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Login : Form
    {
        private const string GoogleLogo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Google_2015_logo.svg/1200px-Google_2015_logo.svg.png";

        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            webLogo.Load(GoogleLogo);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var user = txt_User.Text;
            var password = txt_Password.Text;
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                if (string.IsNullOrEmpty(user))
                {
                    this.txt_User.BorderStyle = BorderStyle.FixedSingle;
                    this.txt_User.BackColor = System.Drawing.Color.Red;
                }

                MessageBox.Show("Please enter valid inputs");
                return;
            }
            else
            {
                this.txt_User.BorderStyle = BorderStyle.None;
                this.txt_User.BackColor = System.Drawing.Color.White;
            }

            var loginResult = LoginController.Login(user, password);
            if (loginResult)
            {
                MessageBox.Show("Login successful");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed");
                this.DialogResult = DialogResult.Cancel;
                this.txt_Password.Text = string.Empty;
                this.txt_User.Text = string.Empty;
            }
        }
    }
}
