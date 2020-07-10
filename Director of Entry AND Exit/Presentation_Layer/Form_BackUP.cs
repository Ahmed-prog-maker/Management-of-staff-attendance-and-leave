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
    public partial class Form_BackUP : Form
    {
        //SqlConnection con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.Database + "; Integrated Security=true");
        //SqlConnection con = new SqlConnection(@"Server=.\SQLEXPRESS; Database=Director of Entry AND Exit_DB; Integrated Security=True");

        SqlConnection con;
        SqlCommand cmd;

        public Form_BackUP()
        {
            InitializeComponent();
            string mode = Properties.Settings.Default.Mode;
            if (mode == "SQL")
            {
                con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=" +
                                                    Properties.Settings.Default.Database + "; Integrated Security=false; User ID=" +
                                                    Properties.Settings.Default.ID + "; Password=" + Properties.Settings.Default.Password + "");
            }
            else
            {
                con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.Database + "; Integrated Security=true");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(FBD.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = FBD.SelectedPath;
            }
            btnCreate.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtFileName.Text + "\\Director of Entry AND Exit_DB " + DateTime.Now.ToShortDateString().Replace('/', '-')
                            + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                string strQuery = "Backup Database [Director of Entry AND Exit_DB] to Disk= '" + fileName + " .bak'";
                cmd = new SqlCommand(strQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم إنشاء النسخة الاحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show(" فشل عمليه إنشاء النسخة الاحتياطية احفظ النسخة الاحتياطية في قرص آخر ", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btbCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
