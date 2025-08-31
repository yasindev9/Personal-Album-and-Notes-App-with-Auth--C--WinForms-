namespace MemoireWinForms
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginPanelBack = new Panel();
            backLoginButton = new Button();
            signUpPanel = new Panel();
            label2 = new Label();
            passcontrol = new TextBox();
            signupButton = new Button();
            signPassTextbox = new TextBox();
            textBox2 = new TextBox();
            signNameTextbox = new TextBox();
            loginPanel = new Panel();
            passcharCheck = new CheckBox();
            label1 = new Label();
            RegisterButton = new Button();
            nameTextBox = new TextBox();
            loginButton = new Button();
            passTextBox = new TextBox();
            loginPanelBack.SuspendLayout();
            signUpPanel.SuspendLayout();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanelBack
            // 
            loginPanelBack.BackgroundImage = Properties.Resources.loginback;
            loginPanelBack.Controls.Add(backLoginButton);
            loginPanelBack.Controls.Add(signUpPanel);
            loginPanelBack.Controls.Add(loginPanel);
            loginPanelBack.Location = new Point(366, 94);
            loginPanelBack.Name = "loginPanelBack";
            loginPanelBack.Size = new Size(360, 540);
            loginPanelBack.TabIndex = 10;
            // 
            // backLoginButton
            // 
            backLoginButton.BackColor = Color.Transparent;
            backLoginButton.BackgroundImage = Properties.Resources.Back_Arrow;
            backLoginButton.BackgroundImageLayout = ImageLayout.Stretch;
            backLoginButton.Cursor = Cursors.Hand;
            backLoginButton.FlatAppearance.BorderSize = 0;
            backLoginButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backLoginButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backLoginButton.FlatStyle = FlatStyle.Flat;
            backLoginButton.Location = new Point(12, 12);
            backLoginButton.Name = "backLoginButton";
            backLoginButton.Size = new Size(32, 32);
            backLoginButton.TabIndex = 10;
            backLoginButton.UseVisualStyleBackColor = false;
            backLoginButton.Click += backLoginButton_Click;
            // 
            // signUpPanel
            // 
            signUpPanel.BackColor = Color.White;
            signUpPanel.BackgroundImage = Properties.Resources.boxback;
            signUpPanel.Controls.Add(label2);
            signUpPanel.Controls.Add(passcontrol);
            signUpPanel.Controls.Add(signupButton);
            signUpPanel.Controls.Add(signPassTextbox);
            signUpPanel.Controls.Add(textBox2);
            signUpPanel.Controls.Add(signNameTextbox);
            signUpPanel.Location = new Point(298, 192);
            signUpPanel.Name = "signUpPanel";
            signUpPanel.Size = new Size(200, 345);
            signUpPanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Optima", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 135);
            label2.TabIndex = 7;
            label2.Text = "Sign up to for memoire";
            // 
            // passcontrol
            // 
            passcontrol.BackColor = SystemColors.Highlight;
            passcontrol.BorderStyle = BorderStyle.FixedSingle;
            passcontrol.Font = new Font("Montserrat", 9F);
            passcontrol.ForeColor = SystemColors.InactiveCaption;
            passcontrol.Location = new Point(0, 277);
            passcontrol.Margin = new Padding(0);
            passcontrol.Name = "passcontrol";
            passcontrol.Size = new Size(200, 26);
            passcontrol.TabIndex = 9;
            passcontrol.Text = "  Password again";
            passcontrol.Enter += passcontrol_Enter;
            passcontrol.Leave += passcontrol_Leave;
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.FromArgb(6, 73, 141);
            signupButton.FlatAppearance.BorderSize = 0;
            signupButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 119, 186);
            signupButton.FlatStyle = FlatStyle.Popup;
            signupButton.Font = new Font("Optima", 10.2F, FontStyle.Bold);
            signupButton.ForeColor = Color.FromArgb(179, 209, 232);
            signupButton.Location = new Point(0, 316);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(200, 29);
            signupButton.TabIndex = 9;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // signPassTextbox
            // 
            signPassTextbox.BackColor = SystemColors.Highlight;
            signPassTextbox.BorderStyle = BorderStyle.FixedSingle;
            signPassTextbox.Font = new Font("Montserrat", 9F);
            signPassTextbox.ForeColor = SystemColors.InactiveCaption;
            signPassTextbox.Location = new Point(0, 244);
            signPassTextbox.Margin = new Padding(0);
            signPassTextbox.Name = "signPassTextbox";
            signPassTextbox.Size = new Size(200, 26);
            signPassTextbox.TabIndex = 9;
            signPassTextbox.Text = "  Password";
            signPassTextbox.Enter += signPassTextbox_Enter;
            signPassTextbox.Leave += signPassTextbox_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(-3, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 0;
            // 
            // signNameTextbox
            // 
            signNameTextbox.BackColor = SystemColors.Highlight;
            signNameTextbox.BorderStyle = BorderStyle.FixedSingle;
            signNameTextbox.Font = new Font("Montserrat", 9F);
            signNameTextbox.ForeColor = SystemColors.InactiveCaption;
            signNameTextbox.Location = new Point(0, 211);
            signNameTextbox.Margin = new Padding(0);
            signNameTextbox.Name = "signNameTextbox";
            signNameTextbox.Size = new Size(200, 26);
            signNameTextbox.TabIndex = 9;
            signNameTextbox.Text = "  Username";
            signNameTextbox.Enter += signNameTextbox_Enter;
            signNameTextbox.Leave += signNameTextbox_Leave;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.White;
            loginPanel.BackgroundImage = Properties.Resources.boxback;
            loginPanel.Controls.Add(passcharCheck);
            loginPanel.Controls.Add(label1);
            loginPanel.Controls.Add(RegisterButton);
            loginPanel.Controls.Add(nameTextBox);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(passTextBox);
            loginPanel.Location = new Point(80, 99);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(200, 342);
            loginPanel.TabIndex = 2;
            // 
            // passcharCheck
            // 
            passcharCheck.AutoSize = true;
            passcharCheck.BackColor = Color.Transparent;
            passcharCheck.CheckAlign = ContentAlignment.MiddleCenter;
            passcharCheck.Checked = true;
            passcharCheck.CheckState = CheckState.Checked;
            passcharCheck.Location = new Point(179, 291);
            passcharCheck.Name = "passcharCheck";
            passcharCheck.Size = new Size(18, 17);
            passcharCheck.TabIndex = 10;
            passcharCheck.UseVisualStyleBackColor = false;
            passcharCheck.CheckedChanged += passcharCheck_CheckedChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Optima", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 135);
            label1.TabIndex = 7;
            label1.Text = "Login        to memoire";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(6, 73, 141);
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 119, 186);
            RegisterButton.FlatStyle = FlatStyle.Popup;
            RegisterButton.Font = new Font("Optima", 10.2F, FontStyle.Bold);
            RegisterButton.ForeColor = Color.FromArgb(179, 209, 232);
            RegisterButton.Location = new Point(104, 310);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(96, 29);
            RegisterButton.TabIndex = 10;
            RegisterButton.Text = "Sign Up";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.Highlight;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nameTextBox.ForeColor = SystemColors.InactiveCaption;
            nameTextBox.Location = new Point(0, 211);
            nameTextBox.Margin = new Padding(0);
            nameTextBox.MaxLength = 40;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 26);
            nameTextBox.TabIndex = 9;
            nameTextBox.Text = "  Username";
            nameTextBox.Enter += nameTextBox_Enter;
            nameTextBox.KeyDown += passTextBox_KeyDown;
            nameTextBox.Leave += nameTextBox_Leave;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(6, 73, 141);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 119, 186);
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Optima", 10.2F, FontStyle.Bold);
            loginButton.ForeColor = Color.FromArgb(179, 209, 232);
            loginButton.Location = new Point(0, 310);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(98, 29);
            loginButton.TabIndex = 1;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passTextBox
            // 
            passTextBox.BackColor = SystemColors.Highlight;
            passTextBox.BorderStyle = BorderStyle.FixedSingle;
            passTextBox.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            passTextBox.ForeColor = SystemColors.InactiveCaption;
            passTextBox.Location = new Point(0, 262);
            passTextBox.Margin = new Padding(0);
            passTextBox.MaxLength = 8;
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(200, 26);
            passTextBox.TabIndex = 9;
            passTextBox.Text = "  Password";
            passTextBox.Enter += passTextBox_Enter;
            passTextBox.KeyDown += passTextBox_KeyDown;
            passTextBox.Leave += passTextBox_Leave;
            // 
            // mainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1262, 673);
            Controls.Add(loginPanelBack);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "memoire";
            Load += mainForm_Load;
            loginPanelBack.ResumeLayout(false);
            signUpPanel.ResumeLayout(false);
            signUpPanel.PerformLayout();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanelBack;
        private Button backLoginButton;
        private Panel signUpPanel;
        private Label label2;
        private TextBox passcontrol;
        private Button signupButton;
        private TextBox signPassTextbox;
        private TextBox textBox2;
        private TextBox signNameTextbox;
        private Panel loginPanel;
        private CheckBox passcharCheck;
        private Label label1;
        private Button RegisterButton;
        private TextBox nameTextBox;
        private Button loginButton;
        private TextBox passTextBox;
    }
}