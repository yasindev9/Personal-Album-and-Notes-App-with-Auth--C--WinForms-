using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoireWinForms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        #region VARS
        string[] usernames = new string[128];
        string[] passwords = new string[128];
        #endregion

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.Width = loginPanelBack.Width;
            this.Height = loginPanelBack.Height;
            signUpPanel.Hide();
            backLoginButton.Hide();
            //mainPanel.Hide();
            //uiPanel.Hide();
            loginPanelBack.Location = new Point(0, 0);
            usernames[0] = "admin";
            passwords[0] = "admin";
            this.StartPosition = FormStartPosition.CenterScreen;
            CenterToScreen();
        }

        #region extra

        public void messageShow(string message, string title, MessageBoxButtons buton, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, buton, icon);
        }

        private void passcharCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!passcharCheck.Checked && passTextBox.ForeColor != Color.FromName("InactiveCaption"))
            {
                passTextBox.PasswordChar = '*';
            }
            else
            {
                passTextBox.PasswordChar = '\0';
            }
        }
        private void passTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                loginButton_Click(sender, e);
            }
        }

        private void CenterToScreenCustom()
        {
            var screen = Screen.FromControl(this).WorkingArea;
            this.Left = (screen.Width - this.Width) / 2;
            this.Top = (screen.Height - this.Height) / 2;
        }
        #endregion

        #region buttons
        private void loginButton_Click(object sender, EventArgs e)
        {
            bool loged = false;
            for (int i = 0; i < usernames.Length; i++)
            {
                if (nameTextBox.Text == usernames[i] && passTextBox.Text == passwords[i])
                {
                    loginPanelBack.Hide();
                    //mainPanel.Show();
                    this.Width = 1280; this.Height = 720;
                    CenterToScreen();
                    //timer1.Start();
                    //typewriteLabel.Text = $"{usernames[i]}, ";
                    loged = true;
                    MainProgram mp = new MainProgram();
                    mp._username = usernames[i];
                    mp.Dock = DockStyle.Fill;
                    loginPanelBack.Hide();
                    this.Controls.Add(mp);
                    break;
                }
                else if (nameTextBox.Text == usernames[i] && passTextBox.Text != passwords[i])
                {
                    messageShow("Password wrong!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else if (passTextBox.Text == passwords[i] && nameTextBox.Text != usernames[i])
                {
                    messageShow("Username wrong!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    loged = false;
                }
            }
            if (!loged)
            {
                messageShow("User not found! Please sign up!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            signNameTextbox.Text = "  Username";
            signNameTextbox.ForeColor = Color.FromName("InactiveCaption");
            signPassTextbox.Text = "  Password";
            signPassTextbox.ForeColor = Color.FromName("InactiveCaption");
            passcontrol.Text = "  Password again";
            passcontrol.ForeColor = Color.FromName("InactiveCaption");
            signUpPanel.Show();
            backLoginButton.Show();
            loginPanel.Hide();
            signUpPanel.Location = new Point(80, 99);
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            bool nameOk = false;
            for (int i = 0; i < usernames.Length; i++)
            {
                if (signNameTextbox.Text != usernames[i])
                {
                    nameOk = true;
                }
                else
                {
                    nameOk = false;
                    messageShow("Sign up is failed! Username taken!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            int x = 0;
            for (int i = 0; i < usernames.Length; i++)
            {
                if (!string.IsNullOrEmpty(usernames[i]))
                    x++;
                else
                    break;
            }
            if (nameOk && passcontrol.Text == signPassTextbox.Text && passcontrol.Text != string.Empty)
            {
                usernames[x] = signNameTextbox.Text;
                passwords[x] = signPassTextbox.Text;
                messageShow("Sign up is successful! Please login.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                signUpPanel.Hide();
                backLoginButton.Hide();
                loginPanel.Show();
            }
            else if(nameOk && passcontrol.Text != signPassTextbox.Text || passcontrol.Text == string.Empty)
            {
                messageShow("Password could not be verified", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backLoginButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "  Username";
            nameTextBox.ForeColor = Color.FromName("InactiveCaption");
            passTextBox.Text = "  Password";
            passTextBox.ForeColor = Color.FromName("InactiveCaption");
            signUpPanel.Hide();
            loginPanel.Show();
            backLoginButton.Hide();
        }

        #endregion

        #region PlaceHolder
        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.ForeColor == Color.FromName("InactiveCaption"))
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == string.Empty)
            {
                nameTextBox.Text = "  Username";
                nameTextBox.ForeColor = Color.FromName("InactiveCaption");
            }
        }

        private void passTextBox_Enter(object sender, EventArgs e)
        {
            if (passTextBox.ForeColor == Color.FromName("InactiveCaption"))
            {
                passTextBox.Text = "";
                passTextBox.ForeColor = Color.Black;
            }
        }

        private void passTextBox_Leave(object sender, EventArgs e)
        {
            if (passTextBox.Text == string.Empty)
            {
                passTextBox.Text = "  Password";
                passTextBox.ForeColor = Color.FromName("InactiveCaption");
            }
        }

        private void signNameTextbox_Enter(object sender, EventArgs e)
        {
            if (signNameTextbox.ForeColor == Color.FromName("InactiveCaption"))
            {
                signNameTextbox.Text = "";
                signNameTextbox.ForeColor = Color.Black;
            }
        }

        private void signNameTextbox_Leave(object sender, EventArgs e)
        {
            if (signNameTextbox.Text == string.Empty)
            {
                signNameTextbox.Text = "  Username";
                signNameTextbox.ForeColor = Color.FromName("InactiveCaption");
            }
        }

        private void signPassTextbox_Enter(object sender, EventArgs e)
        {
            if (signPassTextbox.ForeColor == Color.FromName("InactiveCaption"))
            {
                signPassTextbox.Text = "";
                signPassTextbox.ForeColor = Color.Black;
            }
        }

        private void signPassTextbox_Leave(object sender, EventArgs e)
        {
            if (signPassTextbox.Text == string.Empty)
            {
                signPassTextbox.Text = "  Password";
                signPassTextbox.ForeColor = Color.FromName("InactiveCaption");
            }
        }

        private void passcontrol_Enter(object sender, EventArgs e)
        {
            if (passcontrol.ForeColor == Color.FromName("InactiveCaption"))
            {
                passcontrol.Text = "";
                passcontrol.ForeColor = Color.Black;
            }
        }

        private void passcontrol_Leave(object sender, EventArgs e)
        {
            if (passcontrol.Text == string.Empty)
            {
                passcontrol.Text = "  Password again";
                passcontrol.ForeColor = Color.FromName("InactiveCaption");
            }
        }

        #endregion

        string fullText = "welcome to your 'memoire'.";
        int currentIndex = 0;
        /*private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentIndex < fullText.Length)
            {
                typewriteLabel.Text += fullText[currentIndex];
                currentIndex++;
            }
            else
            {
                timer1.Stop();
            }
        }*/

        private void startButton_Click(object sender, EventArgs e)
        {
            //uiPanel.Show();
            //uiPanel.Location = new Point(50, 50);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void startText_Click(object sender, EventArgs e)
        {

        }
    }
}
