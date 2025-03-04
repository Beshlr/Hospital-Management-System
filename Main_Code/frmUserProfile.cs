using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsBussinessLayer;

namespace Hospital_Management_System
{
    public partial class frmUserProfile : Form
    {
        public frmUserProfile(int UserID)
        {
            InitializeComponent();
            _User = clsUsers.Find(UserID);
        }

        public frmUserProfile(clsUsers User)
        {
            InitializeComponent();
            _User = User;
        }



        private clsUsers _User = null;

        private void frmUserProfile_Load(object sender, EventArgs e)
        {

        }

        private void ctrlAddNewPicture1_Load(object sender, EventArgs e)
        {
            Image img = _User.ImagePath != null ? Image.FromFile(_User.ImagePath) : null ;
            ctrlAddNewPicture1 = new Global.Controls.ctrlAddNewPicture(img);
        }
    }
}
