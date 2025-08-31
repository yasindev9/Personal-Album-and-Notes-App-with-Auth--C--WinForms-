using MemoireWinForms.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MemoireWinForms
{
    public partial class MainProgram : UserControl
    {
        #region vars
        bool albumNameOK = false;
        int totalImages;
        string dirPath;
        string txtPath;
        Bitmap bit = Resources.Import_Folder;
        Bitmap picturePhoto = Resources.Picture;
        string[] images = new string[15];
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        int startX = 45;
        int startY = 45;
        int offsetX = 120;
        int offsetY = 120;
        int maxWidth = 626;
        int previewIM = 0;
        string currentImagePath = null; // seçili fotoğrafın pathi
        #endregion

        public MainProgram()
        {
            InitializeComponent();
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            menuPanel.Hide();
            textTimer.Start();
            welcomeText.Text = $"{_username}, ";
        }

        #region buttons
        private void startButton_Click(object sender, EventArgs e)
        {
            welcomePanel.Hide();
            menuPanel.Location = new Point(30, 30);
            menuPanel.Show();
            albumNameTextbox.Hide();
            createAlbum.Hide();
            totalText.Hide();
            mainViewer.Hide();
            closeButton.Hide();
            notePanel.Hide();
        }
        #endregion

        #region extra
        public string _username { get; set; }
        string fullText = "welcome to your 'memoire.'";
        int currentIndex = 0;
        private void textTimer_Tick(object sender, EventArgs e)
        {
            if (currentIndex < fullText.Length)
            {
                welcomeText.Text += fullText[currentIndex];
                currentIndex++;
            }
            else
            {
                textTimer.Stop();
            }
        }
        #endregion

        private void createButton_Click(object sender, EventArgs e)
        {
            mainViewer.Hide();
            mainPhotoSource.Image = null;
            closeButton.Hide();
            albumNameTextbox.Show();
            createAlbum.Show();
        }

        private void albumNameTextbox_Enter(object sender, EventArgs e)
        {
            if (albumNameTextbox.ForeColor == Color.FromName("ActiveBorder") || albumNameTextbox.ForeColor == Color.Red)
            {
                albumNameTextbox.Clear();
                albumNameOK = true;
                albumNameTextbox.ForeColor = Color.FromName("Control");
            }
        }

        private void albumNameTextbox_Leave(object sender, EventArgs e)
        {
            if (albumNameTextbox.Text == string.Empty)
            {
                albumNameTextbox.ForeColor = Color.Red;
                albumNameOK = false;
                albumNameTextbox.Text = "Name can't be left blank!";
            }
        }

        private void createAlbum_Click(object sender, EventArgs e)
        {
            notePanel.Hide();
            mainViewer.Hide();
            mainPhotoSource.Image = null;
            closeButton.Hide();
            if (!albumNameOK) { albumNameTextbox.ForeColor = Color.Red; albumNameTextbox.Text = "Name can't be left blank!"; return; }

            string basePath = $"C:\\Memoire\\{_username}\\";
            if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);

            dirPath = Path.Combine(basePath, albumNameTextbox.Text);
            txtPath = Path.Combine(dirPath, "photos.txt");

            if (Directory.Exists(dirPath))
            {
                MessageBox.Show("There is an album with the same name!", "Create Album", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Directory.CreateDirectory(dirPath);
            File.Create(txtPath).Close();

            foreach (var pb in pictureBoxes) { photoViewer.Controls.Remove(pb); pb.Dispose(); }
            pictureBoxes.Clear();
            previewIM = 0;

            albumNameTextbox.Hide();
            createAlbum.Hide();
            albumName.Text = "Current album: " + albumNameTextbox.Text;
            totalImages = 0;
            totalText.Text = "Total Images: " + totalImages.ToString();
            totalText.Show();

            createLabel.Text = "add photo";
            createLabel.Location = new Point(302, 250);
            create2Button.Image = bit;
            create2Button.Click -= createButton_Click;
            create2Button.Click += addButton_Click;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            mainViewer.Hide();
            mainPhotoSource.Image = null;
            closeButton.Hide();
            try
            {
                create2Button.Hide();
                createLabel.Hide();

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Memoire | Select picture";
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (ofd.ShowDialog() != DialogResult.OK) return;
                if (pictureBoxes.Count >= 15) { MessageBox.Show("Up to 15 images can be added!"); return; }

                string imagePath = ofd.FileName;
                string imageName = Path.GetFileName(imagePath);
                string copyPath = Path.Combine(dirPath, imageName);
                string notePath = Path.ChangeExtension(copyPath, ".txt");
                if (!File.Exists(notePath)) File.WriteAllText(notePath, "");

                var existingImages = File.Exists(txtPath) ? File.ReadAllLines(txtPath) : new string[0];
                if (existingImages.Any(p => Path.GetFileName(p).Equals(imageName, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("This image already exists!"); return;
                }

                File.Copy(imagePath, copyPath);
                File.AppendAllText(txtPath, copyPath + Environment.NewLine);
                totalImages = File.ReadLines(txtPath).Count();
                totalText.Text = "Total Images: " + totalImages.ToString();

                PictureBox pb = new PictureBox();
                pb.Size = new Size(100, 100);
                pb.BackColor = Color.Transparent;
                pb.SizeMode = PictureBoxSizeMode.AutoSize;
                pb.Cursor = Cursors.Hand;
                pb.Image = picturePhoto;

                int index = pictureBoxes.Count;
                int x = startX + (index * offsetX);
                int y = startY;
                while (x + pb.Width > maxWidth) { x -= maxWidth - startX; y += offsetY; }
                pb.Location = new Point(x, y);

                pb.Tag = copyPath;
                pb.Click += Photo_Click;

                pictureBoxes.Add(pb);
                photoViewer.Controls.Add(pb);
                pb.BringToFront();
            }
            catch (Exception ex) { MessageBox.Show("An error occurred while adding the image:\n" + ex.Message); }
        }

        private void Photo_Click(object sender, EventArgs e)
        {
            notePanel.Show();
            PictureBox pb = sender as PictureBox;
            if (pb == null || !File.Exists(pb.Tag.ToString())) return;

            currentImagePath = pb.Tag.ToString();
            Image img;
            using (var fs = new FileStream(currentImagePath, FileMode.Open, FileAccess.Read))
            {
                img = Image.FromStream(fs);
                img = new Bitmap(img); // RAM kopyası
            }

            int maxW = 582, maxH = 395;
            float ratio = Math.Min((float)maxW / img.Width, (float)maxH / img.Height);
            int newWidth = (int)(img.Width * ratio), newHeight = (int)(img.Height * ratio);

            mainPhotoSource.Size = new Size(newWidth, newHeight);
            mainPhotoSource.Location = new Point(0, 0);
            mainPhotoSource.Image = img;
            mainPhotoSource.SizeMode = PictureBoxSizeMode.Zoom;
            mainViewer.Show();
            closeButton.Show();

            string notePath = Path.ChangeExtension(currentImagePath, ".txt");
            noteRichTextBox.Text = File.Exists(notePath) ? File.ReadAllText(notePath) : "";

            foreach (var otherPb in pictureBoxes) otherPb.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            foreach (var pb in pictureBoxes) pb.Show();
            mainViewer.Hide();
            closeButton.Hide();
            noteRichTextBox.Clear();
            notePanel.Hide();
        }

        private void addnoteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentImagePath))
            {
                string notePath = Path.ChangeExtension(currentImagePath, ".txt");
                File.WriteAllText(notePath, noteRichTextBox.Text);
            }
            else
            {
                MessageBox.Show("No photo selected to save note!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteAlbum_Click(object sender, EventArgs e)
        {
            mainViewer.Hide();
            mainPhotoSource.Image = null;
            closeButton.Hide();
            notePanel.Hide();

            if (string.IsNullOrEmpty(dirPath) || !Directory.Exists(dirPath)) { MessageBox.Show("No album found to delete."); return; }
            if (MessageBox.Show("Are you sure you want to delete this album?\nAll photos inside will be lost!", "Delete Album", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            Directory.Delete(dirPath, true);

            albumName.Text = "No active album";
            totalText.Text = "Total Images: 0";
            foreach (var pb in pictureBoxes) { photoViewer.Controls.Remove(pb); pb.Dispose(); }
            pictureBoxes.Clear();

            mainViewer.Hide();
            mainPhotoSource.Image = null;
            closeButton.Hide();

            createLabel.Text = "create album";
            createLabel.Location = new Point(302, 250);
            create2Button.Image = bit;
            create2Button.Click -= addButton_Click;
            create2Button.Click += createButton_Click;

            dirPath = null;
            txtPath = null;
            totalImages = 0;
            previewIM = 0;

            MessageBox.Show("Album deleted successfully!", "Delete Album", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openAlbum_Click(object sender, EventArgs e)
        {
            create2Button.Hide();
            createLabel.Hide();
            mainViewer.Hide();
            mainPhotoSource.Image = null;
            closeButton.Hide();

            string basePath = $"C:\\Memoire\\{_username}\\";
            if (!Directory.Exists(basePath)) { MessageBox.Show("No albums found for this user."); return; }

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select your album folder";
                fbd.SelectedPath = basePath;
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = false;

                if (fbd.ShowDialog() != DialogResult.OK) return;
                string selectedFolder = fbd.SelectedPath;
                if (!selectedFolder.StartsWith(basePath)) { MessageBox.Show("Access denied!"); return; }

                string photosTxt = Path.Combine(selectedFolder, "photos.txt");
                if (!File.Exists(photosTxt)) { MessageBox.Show("This folder is not a valid album!"); return; }

                foreach (var pb in pictureBoxes) { photoViewer.Controls.Remove(pb); pb.Dispose(); }
                pictureBoxes.Clear();
                previewIM = 0;

                dirPath = selectedFolder;
                txtPath = photosTxt;
                albumName.Text = "Current album: " + Path.GetFileName(selectedFolder);

                images = File.ReadAllLines(txtPath);
                totalImages = images.Length;
                totalText.Text = "Total Images: " + totalImages.ToString();
                totalText.Show();

                int index = 0;
                foreach (string imgPath in images)
                {
                    if (!File.Exists(imgPath)) continue;
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(100, 100);
                    pb.BackColor = Color.Transparent;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Image = picturePhoto;
                    pb.Cursor = Cursors.Hand;
                    pb.Tag = imgPath;

                    int x = startX + (index * offsetX);
                    int y = startY;
                    while (x + pb.Width > maxWidth) { x -= maxWidth - startX; y += offsetY; }
                    pb.Location = new Point(x, y);

                    pb.Click += Photo_Click;
                    pictureBoxes.Add(pb);
                    photoViewer.Controls.Add(pb);
                    pb.BringToFront();
                    index++;
                }

                createLabel.Text = "add photo";
                createLabel.Location = new Point(302, 250);
                create2Button.Image = bit;
                create2Button.Click -= createButton_Click;
                create2Button.Click += addButton_Click;
            }
        }
    }
}
