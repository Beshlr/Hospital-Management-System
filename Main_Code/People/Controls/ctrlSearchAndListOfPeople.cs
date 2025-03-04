using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.Classes;
using clsBussinessLayer;


namespace Hospital_Management_System.People.Controls
{
    public partial class ctrlSearchAndListOfPeople : UserControl
    {
        public ctrlSearchAndListOfPeople()
        {

            InitializeComponent();
            // Add your runtime initialization code here

        }

        public static DataTable dataSource {  get; set; }

        private void pbxSearchFilter_Click(object sender, EventArgs e)
        {
            if (gbxFilterBy.Visible == true)
                gbxFilterBy.Visible = false;
            else
                gbxFilterBy.Visible = true;
        }

        private void ctrlSearchAndListOfPeople_Load(object sender, EventArgs e)
        {
            gbxFilterBy.Visible = false;
            pnlAddEditPerson.Visible = false;

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {



        }

        public bool AddNewPerson()
        {
            clsPeople newPerson = new clsPeople();

            string[] Name = txtName.Text.Split(' ');

            if(Name.Length > 3)
            {
                newPerson.FirstName = Name[0];
                newPerson.SecondName = Name[1];
                newPerson.LastName = Name[Name.Length-1];
            }

            newPerson.NationalNumber = txtNationalNo.Text.Trim();
            newPerson.DateOfBirth = dtpDOB.Value;
            if (cbxGendor.Text == "Male")
                newPerson.Gendor = clsPeople.enGendor.Male;
            else 
                newPerson.Gendor = clsPeople.enGendor.Female;

            newPerson.PhoneNumber = txtPhoneNumber.Text;
            newPerson.Address = txtAddress.Text;

            return newPerson.Save();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            clsGlobal.HandelChooseImageFromFileExplorer(ref openFileDialog1,ref pbxImage);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!pnlAddEditPerson.Visible)
                pnlAddEditPerson.Visible = true;
        }

        private void pbxHidePanel_Click(object sender, EventArgs e)
        {
            pnlAddEditPerson.Visible = false;
        }
    }
}
