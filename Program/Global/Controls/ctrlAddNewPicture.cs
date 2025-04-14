using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using static System.Drawing.Image;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.Global;
using Hospital_Management_System.Properties;
using Hospital_Management_System.Classes;
using System.IO;
using System.Windows.Input;


namespace Hospital_Management_System.Global.Controls
{
    public partial class ctrlAddNewPicture : UserControl
    {
        public ctrlAddNewPicture()
        {
            InitializeComponent();
        }
        public ctrlAddNewPicture(Image img)
        {
            InitializeComponent();
            llblRemoveImage.Visible = img !=null;
            _img = img;
            pbxImage.Image = img;
        }

        public delegate bool CheckImageChange(object sender, Image img);

        public event CheckImageChange OnImageChanged;


        private Image _img { get; set; }
        private string _ImagePath = "";

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            
            if (!clsGlobal.HandelChooseImageFromFileExplorer(ref openFileDialog1, ref pbxImage, ref _ImagePath))
            {
                MessageBox.Show("There is an error, Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbxImage.Image = Resources.Male_512;
                
            }
            _img = pbxImage.Image;

            if(pbxImage.Image != Resources.Male_512)
                OnImageChanged += CtrlAddNewPicture_OnImageChanged;

        }

        public bool CtrlAddNewPicture_OnImageChanged(object sender, Image img)
        {
            if (img != _img && img != Resources.Male_512)
            {
                _img = img;
                return true;
            }

            return false;
        }

        public Image GetImage()
        {
            return _img;
        }
        public void SetImage(string ImgPath)
        {
            _ImagePath = ImgPath;
            Console.WriteLine($"Trying to set image: {ImgPath}");

            if (File.Exists(ImgPath))
            {
                using (var stream = new FileStream(ImgPath, FileMode.Open, FileAccess.Read))
                {
                    _img = Image.FromStream(stream);
                }
                pbxImage.Image = _img;
                pbxImage.Refresh();

                Console.WriteLine("Image set successfully.");
            }
            else
            {
                MessageBox.Show("The image does not exist in the specified path!");
            }
        }

        public string GetImagePath()
        {
            return _ImagePath;
        }


        public void ChangeEditImageStatus(bool Edit)
        {
            btnChangeImage.Enabled = llblRemoveImage.Enabled = Edit;

        }


        private void llblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pbxImage.Image != Resources.Male_512)
                OnImageChanged += CtrlAddNewPicture_OnImageChanged;
            pbxImage.Image = Resources.Male_512;
            _ImagePath = null;
            _img = null;

        }

        public void ChangeEditingStatus(bool EnableEdit)
        {
            btnChangeImage.Enabled = llblRemoveImage.Enabled = EnableEdit;
        }
    }
}
