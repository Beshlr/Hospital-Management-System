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

namespace Hospital_Management_System.Global.Controls
{
    public partial class ctrlAddNewPicture : UserControl
    {
        public ctrlAddNewPicture()
        {
            InitializeComponent();
        }

        public delegate bool CheckImageChange(object sender, Image img);

        public event CheckImageChange OnImageChanged;


        private Image _img { get; set; }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            
            if (!clsGlobal.HandelChooseImageFromFileExplorer(ref openFileDialog1, ref pbxImage))
            {
                MessageBox.Show("There is an error, Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbxImage.Image = Resources.Male_512;
                
            }
            _img = pbxImage.Image;

            if(pbxImage.Image != Resources.Male_512)
                OnImageChanged += CtrlAddNewPicture_OnImageChanged;

        }

        private bool CtrlAddNewPicture_OnImageChanged(object sender, Image img)
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
        public void SetImage(Image Img)
        {
            _img = Img;
            pbxImage.Image = Img;
        }

        private void llblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbxImage.Image = Resources.Male_512;
        }

        public void ChangeEditingStatus(bool EnableEdit)
        {
            btnChangeImage.Enabled = llblRemoveImage.Enabled = EnableEdit;
        }
            
    }
}
