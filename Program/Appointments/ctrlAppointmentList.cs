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

namespace Hospital_Management_System.Appointments
{
    public partial class ctrlAppointmentList : UserControl
    {
        public ctrlAppointmentList(string ListOf)
        {
            InitializeComponent();


        }

        public void HandelFormatScreenForDoctors()
        {

        }

        public void HandelFormatScreen(string ListOf)
        {
            switch(ListOf)
            {
                case "Doctors":
                    {

                        break;
                    }
            }
        }
        
    }
}
