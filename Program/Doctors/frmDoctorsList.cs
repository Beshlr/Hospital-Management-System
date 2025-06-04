using Hospital_Management_System.Global.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System.Doctors
{
    public partial class frmDoctorsList: Form
    {
        public frmDoctorsList()
        {
            InitializeComponent();
        }

        private void frmDoctorsList_Load(object sender, EventArgs e)
        {
            ctrlListWithFilter1.enListOf = ctrlListWithFilter.enListTypes.enDoctors;
            ctrlListWithFilter1.RefreashList();
        }
    }
}
