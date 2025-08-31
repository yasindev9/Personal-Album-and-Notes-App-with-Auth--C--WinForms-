namespace MemoireWinForms
{
    partial class MainProgram
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            welcomeText = new Label();
            welcomePanel = new GradientRoundedPanelHorizontal();
            letsPanel = new GradientRoundedPanel();
            startButton = new Label();
            menuPanel = new GradientRoundedPanelHorizontal();
            notePanel = new GradientRoundedPanel();
            noteRichTextBox = new RichTextBox();
            label6 = new Label();
            addnoteButton = new Button();
            photoViewer = new GradientRoundedPanel();
            closeButton = new PictureBox();
            mainViewer = new Panel();
            mainPhotoSource = new PictureBox();
            totalText = new Label();
            create2Button = new PictureBox();
            createLabel = new Label();
            createAlbum = new Button();
            albumNameTextbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            deleteAlbum = new PictureBox();
            addButton = new PictureBox();
            openAlbum = new PictureBox();
            createButton = new PictureBox();
            gradientRoundedPanel2 = new GradientRoundedPanel();
            label2 = new Label();
            gradientRoundedPanel1 = new GradientRoundedPanel();
            albumName = new Label();
            panel1 = new Panel();
            textTimer = new System.Windows.Forms.Timer(components);
            welcomePanel.SuspendLayout();
            letsPanel.SuspendLayout();
            menuPanel.SuspendLayout();
            notePanel.SuspendLayout();
            photoViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            mainViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainPhotoSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)create2Button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteAlbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openAlbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createButton).BeginInit();
            gradientRoundedPanel2.SuspendLayout();
            gradientRoundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeText
            // 
            welcomeText.BackColor = Color.Transparent;
            welcomeText.Dock = DockStyle.Top;
            welcomeText.Font = new Font("Montserrat SemiBold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            welcomeText.ForeColor = SystemColors.Control;
            welcomeText.Location = new Point(0, 0);
            welcomeText.Name = "welcomeText";
            welcomeText.Size = new Size(500, 368);
            welcomeText.TabIndex = 0;
            welcomeText.Text = "welcome text";
            welcomeText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // welcomePanel
            // 
            welcomePanel.BackColor = Color.Transparent;
            welcomePanel.BorderRadius = 45;
            welcomePanel.ColorEnd = Color.FromArgb(31, 31, 31);
            welcomePanel.ColorStart = Color.FromArgb(31, 31, 31);
            welcomePanel.Controls.Add(letsPanel);
            welcomePanel.Controls.Add(welcomeText);
            welcomePanel.Location = new Point(381, 86);
            welcomePanel.Name = "welcomePanel";
            welcomePanel.Size = new Size(500, 500);
            welcomePanel.TabIndex = 1;
            // 
            // letsPanel
            // 
            letsPanel.BorderRadius = 22;
            letsPanel.ColorEnd = Color.FromArgb(62, 62, 62);
            letsPanel.ColorStart = Color.FromArgb(62, 62, 62);
            letsPanel.Controls.Add(startButton);
            letsPanel.Location = new Point(124, 388);
            letsPanel.Name = "letsPanel";
            letsPanel.Size = new Size(250, 75);
            letsPanel.TabIndex = 1;
            // 
            // startButton
            // 
            startButton.Cursor = Cursors.Hand;
            startButton.Dock = DockStyle.Fill;
            startButton.Font = new Font("Montserrat SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            startButton.ForeColor = SystemColors.Control;
            startButton.Location = new Point(0, 0);
            startButton.Name = "startButton";
            startButton.Size = new Size(250, 75);
            startButton.TabIndex = 0;
            startButton.Text = "Lets start";
            startButton.TextAlign = ContentAlignment.MiddleCenter;
            startButton.Click += startButton_Click;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.Transparent;
            menuPanel.BorderRadius = 45;
            menuPanel.ColorEnd = Color.FromArgb(31, 31, 31);
            menuPanel.ColorStart = Color.FromArgb(31, 31, 31);
            menuPanel.Controls.Add(notePanel);
            menuPanel.Controls.Add(photoViewer);
            menuPanel.Controls.Add(createAlbum);
            menuPanel.Controls.Add(albumNameTextbox);
            menuPanel.Controls.Add(label4);
            menuPanel.Controls.Add(label3);
            menuPanel.Controls.Add(label5);
            menuPanel.Controls.Add(label1);
            menuPanel.Controls.Add(deleteAlbum);
            menuPanel.Controls.Add(addButton);
            menuPanel.Controls.Add(openAlbum);
            menuPanel.Controls.Add(createButton);
            menuPanel.Controls.Add(gradientRoundedPanel2);
            menuPanel.Controls.Add(gradientRoundedPanel1);
            menuPanel.Controls.Add(panel1);
            menuPanel.Location = new Point(30, 30);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1202, 613);
            menuPanel.TabIndex = 2;
            // 
            // notePanel
            // 
            notePanel.BorderRadius = 22;
            notePanel.ColorEnd = Color.FromArgb(62, 62, 62);
            notePanel.ColorStart = Color.FromArgb(62, 62, 62);
            notePanel.Controls.Add(noteRichTextBox);
            notePanel.Controls.Add(label6);
            notePanel.Controls.Add(addnoteButton);
            notePanel.Location = new Point(813, 321);
            notePanel.Name = "notePanel";
            notePanel.Size = new Size(347, 274);
            notePanel.TabIndex = 10;
            // 
            // noteRichTextBox
            // 
            noteRichTextBox.BackColor = Color.FromArgb(62, 62, 62);
            noteRichTextBox.BorderStyle = BorderStyle.None;
            noteRichTextBox.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            noteRichTextBox.ForeColor = SystemColors.Control;
            noteRichTextBox.Location = new Point(12, 37);
            noteRichTextBox.MaxLength = 2000;
            noteRichTextBox.Name = "noteRichTextBox";
            noteRichTextBox.Size = new Size(323, 195);
            noteRichTextBox.TabIndex = 8;
            noteRichTextBox.Text = "Note";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(128, 7);
            label6.Name = "label6";
            label6.Size = new Size(98, 27);
            label6.TabIndex = 9;
            label6.Text = "Your note";
            // 
            // addnoteButton
            // 
            addnoteButton.BackColor = Color.FromArgb(62, 62, 62);
            addnoteButton.FlatStyle = FlatStyle.Popup;
            addnoteButton.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            addnoteButton.ForeColor = SystemColors.Control;
            addnoteButton.Location = new Point(241, 234);
            addnoteButton.Name = "addnoteButton";
            addnoteButton.Size = new Size(94, 35);
            addnoteButton.TabIndex = 5;
            addnoteButton.Text = "add note";
            addnoteButton.UseVisualStyleBackColor = false;
            addnoteButton.Click += addnoteButton_Click;
            // 
            // photoViewer
            // 
            photoViewer.BorderRadius = 22;
            photoViewer.ColorEnd = Color.FromArgb(62, 62, 62);
            photoViewer.ColorStart = Color.FromArgb(62, 62, 62);
            photoViewer.Controls.Add(closeButton);
            photoViewer.Controls.Add(mainViewer);
            photoViewer.Controls.Add(totalText);
            photoViewer.Controls.Add(create2Button);
            photoViewer.Controls.Add(createLabel);
            photoViewer.Location = new Point(46, 113);
            photoViewer.Name = "photoViewer";
            photoViewer.Size = new Size(679, 482);
            photoViewer.TabIndex = 7;
            // 
            // closeButton
            // 
            closeButton.Cursor = Cursors.Hand;
            closeButton.Image = Properties.Resources.Cancel;
            closeButton.Location = new Point(636, 13);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            closeButton.TabIndex = 1;
            closeButton.TabStop = false;
            closeButton.Click += closeButton_Click;
            // 
            // mainViewer
            // 
            mainViewer.Controls.Add(mainPhotoSource);
            mainViewer.Location = new Point(45, 45);
            mainViewer.Name = "mainViewer";
            mainViewer.Size = new Size(582, 395);
            mainViewer.TabIndex = 7;
            // 
            // mainPhotoSource
            // 
            mainPhotoSource.Location = new Point(0, 0);
            mainPhotoSource.Name = "mainPhotoSource";
            mainPhotoSource.Size = new Size(514, 361);
            mainPhotoSource.TabIndex = 0;
            mainPhotoSource.TabStop = false;
            // 
            // totalText
            // 
            totalText.AutoSize = true;
            totalText.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            totalText.ForeColor = SystemColors.Control;
            totalText.Location = new Point(15, 447);
            totalText.Name = "totalText";
            totalText.Size = new Size(115, 24);
            totalText.TabIndex = 6;
            totalText.Text = "Total Images: ";
            // 
            // create2Button
            // 
            create2Button.Cursor = Cursors.Hand;
            create2Button.Image = Properties.Resources.Add_Folder;
            create2Button.Location = new Point(320, 197);
            create2Button.Name = "create2Button";
            create2Button.Size = new Size(50, 50);
            create2Button.SizeMode = PictureBoxSizeMode.AutoSize;
            create2Button.TabIndex = 2;
            create2Button.TabStop = false;
            create2Button.Click += createButton_Click;
            // 
            // createLabel
            // 
            createLabel.AutoSize = true;
            createLabel.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            createLabel.ForeColor = SystemColors.Control;
            createLabel.Location = new Point(289, 250);
            createLabel.Name = "createLabel";
            createLabel.Size = new Size(111, 24);
            createLabel.TabIndex = 3;
            createLabel.Text = "create album";
            // 
            // createAlbum
            // 
            createAlbum.BackColor = Color.FromArgb(62, 62, 62);
            createAlbum.FlatStyle = FlatStyle.Popup;
            createAlbum.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            createAlbum.ForeColor = SystemColors.Control;
            createAlbum.Location = new Point(1066, 280);
            createAlbum.Name = "createAlbum";
            createAlbum.Size = new Size(94, 35);
            createAlbum.TabIndex = 5;
            createAlbum.Text = "create";
            createAlbum.UseVisualStyleBackColor = false;
            createAlbum.Click += createAlbum_Click;
            // 
            // albumNameTextbox
            // 
            albumNameTextbox.BackColor = Color.FromArgb(62, 62, 62);
            albumNameTextbox.BorderStyle = BorderStyle.FixedSingle;
            albumNameTextbox.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            albumNameTextbox.ForeColor = SystemColors.ActiveBorder;
            albumNameTextbox.Location = new Point(949, 248);
            albumNameTextbox.Name = "albumNameTextbox";
            albumNameTextbox.Size = new Size(211, 26);
            albumNameTextbox.TabIndex = 4;
            albumNameTextbox.Text = "  Enter album name";
            albumNameTextbox.Enter += albumNameTextbox_Enter;
            albumNameTextbox.Leave += albumNameTextbox_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(1063, 188);
            label4.Name = "label4";
            label4.Size = new Size(110, 24);
            label4.TabIndex = 3;
            label4.Text = "delete album";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(949, 188);
            label3.Name = "label3";
            label3.Size = new Size(89, 24);
            label3.TabIndex = 3;
            label3.Text = "add photo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(815, 291);
            label5.Name = "label5";
            label5.Size = new Size(102, 24);
            label5.TabIndex = 3;
            label5.Text = "open album";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(806, 188);
            label1.Name = "label1";
            label1.Size = new Size(111, 24);
            label1.TabIndex = 3;
            label1.Text = "create album";
            // 
            // deleteAlbum
            // 
            deleteAlbum.Cursor = Cursors.Hand;
            deleteAlbum.Image = Properties.Resources.Delete_Trash;
            deleteAlbum.Location = new Point(1089, 135);
            deleteAlbum.Name = "deleteAlbum";
            deleteAlbum.Size = new Size(50, 50);
            deleteAlbum.SizeMode = PictureBoxSizeMode.AutoSize;
            deleteAlbum.TabIndex = 2;
            deleteAlbum.TabStop = false;
            deleteAlbum.Click += deleteAlbum_Click;
            // 
            // addButton
            // 
            addButton.Cursor = Cursors.Hand;
            addButton.Image = Properties.Resources.Import_Folder;
            addButton.Location = new Point(967, 135);
            addButton.Name = "addButton";
            addButton.Size = new Size(50, 50);
            addButton.SizeMode = PictureBoxSizeMode.AutoSize;
            addButton.TabIndex = 2;
            addButton.TabStop = false;
            addButton.Click += addButton_Click;
            // 
            // openAlbum
            // 
            openAlbum.Cursor = Cursors.Hand;
            openAlbum.Image = Properties.Resources.Opened_Folder;
            openAlbum.Location = new Point(837, 238);
            openAlbum.Name = "openAlbum";
            openAlbum.Size = new Size(50, 50);
            openAlbum.SizeMode = PictureBoxSizeMode.AutoSize;
            openAlbum.TabIndex = 2;
            openAlbum.TabStop = false;
            openAlbum.Click += openAlbum_Click;
            // 
            // createButton
            // 
            createButton.Cursor = Cursors.Hand;
            createButton.Image = Properties.Resources.Add_Folder;
            createButton.Location = new Point(837, 135);
            createButton.Name = "createButton";
            createButton.Size = new Size(50, 50);
            createButton.SizeMode = PictureBoxSizeMode.AutoSize;
            createButton.TabIndex = 2;
            createButton.TabStop = false;
            createButton.Click += createButton_Click;
            // 
            // gradientRoundedPanel2
            // 
            gradientRoundedPanel2.BorderRadius = 22;
            gradientRoundedPanel2.ColorEnd = Color.FromArgb(62, 62, 62);
            gradientRoundedPanel2.ColorStart = Color.FromArgb(62, 62, 62);
            gradientRoundedPanel2.Controls.Add(label2);
            gradientRoundedPanel2.Location = new Point(813, 27);
            gradientRoundedPanel2.Name = "gradientRoundedPanel2";
            gradientRoundedPanel2.Size = new Size(347, 75);
            gradientRoundedPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(347, 75);
            label2.TabIndex = 0;
            label2.Text = "File Operations";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gradientRoundedPanel1
            // 
            gradientRoundedPanel1.BorderRadius = 22;
            gradientRoundedPanel1.ColorEnd = Color.FromArgb(62, 62, 62);
            gradientRoundedPanel1.ColorStart = Color.FromArgb(62, 62, 62);
            gradientRoundedPanel1.Controls.Add(albumName);
            gradientRoundedPanel1.Location = new Point(46, 27);
            gradientRoundedPanel1.Name = "gradientRoundedPanel1";
            gradientRoundedPanel1.Size = new Size(679, 75);
            gradientRoundedPanel1.TabIndex = 1;
            // 
            // albumName
            // 
            albumName.Dock = DockStyle.Fill;
            albumName.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            albumName.ForeColor = SystemColors.Control;
            albumName.Location = new Point(0, 0);
            albumName.Name = "albumName";
            albumName.Size = new Size(679, 75);
            albumName.TabIndex = 0;
            albumName.Text = "No active album";
            albumName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 62, 62);
            panel1.Location = new Point(763, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 623);
            panel1.TabIndex = 0;
            // 
            // textTimer
            // 
            textTimer.Tick += textTimer_Tick;
            // 
            // MainProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.back1Expended;
            Controls.Add(menuPanel);
            Controls.Add(welcomePanel);
            Name = "MainProgram";
            Size = new Size(1262, 673);
            Load += MainProgram_Load;
            welcomePanel.ResumeLayout(false);
            letsPanel.ResumeLayout(false);
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            notePanel.ResumeLayout(false);
            notePanel.PerformLayout();
            photoViewer.ResumeLayout(false);
            photoViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            mainViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainPhotoSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)create2Button).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteAlbum).EndInit();
            ((System.ComponentModel.ISupportInitialize)addButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)openAlbum).EndInit();
            ((System.ComponentModel.ISupportInitialize)createButton).EndInit();
            gradientRoundedPanel2.ResumeLayout(false);
            gradientRoundedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label welcomeText;
        private GradientRoundedPanelHorizontal welcomePanel;
        private GradientRoundedPanel letsPanel;
        private Label startButton;
        private GradientRoundedPanelHorizontal menuPanel;
        private System.Windows.Forms.Timer textTimer;
        private Panel panel1;
        private GradientRoundedPanel gradientRoundedPanel2;
        private GradientRoundedPanel gradientRoundedPanel1;
        private Label albumName;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox deleteAlbum;
        private PictureBox addButton;
        private PictureBox createButton;
        private Button createAlbum;
        private TextBox albumNameTextbox;
        private Label totalText;
        private GradientRoundedPanel photoViewer;
        private PictureBox create2Button;
        private Label createLabel;
        private Panel mainViewer;
        private PictureBox mainPhotoSource;
        private PictureBox closeButton;
        private Label label5;
        private PictureBox openAlbum;
        private RichTextBox noteRichTextBox;
        private Button addnoteButton;
        private GradientRoundedPanel notePanel;
        private Label label6;
    }
}
