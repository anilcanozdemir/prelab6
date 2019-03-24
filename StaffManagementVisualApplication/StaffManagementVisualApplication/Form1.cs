using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffManagementVisualApplication
{
    public partial class StaffManagementApplication : Form
    {
        public StaffManagementApplication()
        {
            InitializeComponent();
        }


        private void rbtnMarried_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMarried.Checked)
            {
                grpbxFamily.Visible = true;
            }
            else
            {
                grpbxFamily.Visible = false;
            }
        }

        private void chckbxlittle_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxlittle.Checked)
            {
                txtlittle.Visible = true;

            }
            else
            {
                txtlittle.Visible = false;
            }
        }

        private void chckmiddle_CheckedChanged(object sender, EventArgs e)
        {
            if(chckbxmiddle.Checked)
            {
                txtmiddle.Visible = true;
            }
            else
            {
                txtmiddle.Visible = false;
            }

        }

        private void chckbxolder_CheckedChanged(object sender, EventArgs e)
        {
            if(chckbxolder.Checked)
            {
                txtolder.Visible = true;
            }
            else
            {
                txtolder.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnMarried.Checked = false;
            rbtnSingle.Checked = true;
        }
    }
}
