using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Director_of_Entry_AND_Exit.Presentation_Layer
{
    public partial class Form_Con : Form
    {
        public Form_Con()
        {
            InitializeComponent();
            txtServer.Text = Properties.Settings.Default.Server;
            txtDatabase.Text = Properties.Settings.Default.Database;

            Properties.Settings.Default["Dr_DBConnectionString"] = String.Format("Data Source=" + Properties.Settings.Default.Server +
            "; Initial Catalog=" + Properties.Settings.Default.Database +
            "; Integrated Security = True;");

            if (Properties.Settings.Default.Mode == "SQL")
            {
                rbSQL.Checked = true;
                txtID.Text = Properties.Settings.Default.ID;
                txtPWD.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rbWindows.Checked = true;
                txtID.Clear();
                txtPWD.Clear();
                txtID.ReadOnly = true;
                txtPWD.ReadOnly = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.Mode = rbSQL.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.ID = txtID.Text;
            Properties.Settings.Default.Password = txtPWD.Text;
            
            string mode = Properties.Settings.Default.Mode;
            if (rbSQL.Checked == true)
            {
                Properties.Settings.Default["Dr_DBConnectionString"] = String.Format("Data Source=" + txtServer.Text +
                 "; Initial Catalog=" + txtDatabase.Text +
                 "; Integrated Security = false; User ID=" + txtID.Text +
                 "; Password=" + txtPWD.Text + "");
            }
            else
            {
                Properties.Settings.Default["Dr_DBConnectionString"] = String.Format("Data Source=" + txtServer.Text +
                 "; Initial Catalog=" + txtDatabase.Text +
                 "; Integrated Security = True;");
            }

            Properties.Settings.Default.Save();

            MessageBox.Show("تم الحفظ");
            this.Close();
        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            txtPWD.ReadOnly = false;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtPWD.ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
