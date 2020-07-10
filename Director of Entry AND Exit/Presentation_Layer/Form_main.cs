using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Director_of_Entry_AND_Exit.Properties;

namespace Director_of_Entry_AND_Exit.Presentation_Layer
{
    public partial class Form_main : Form
    {
        User_Control.User_Table ut = new User_Control.User_Table();
        Business_Layer.Cls_Entry_AND_Exit EaE = new Business_Layer.Cls_Entry_AND_Exit();
        double TResult;
        public static string NameID;

        public static Form_main frm;
        public static string fr;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Form_main getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form_main();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public Form_main()
        {
            InitializeComponent();

            string mode = Settings.Default.Mode;
            if (mode == "SQL")
            {
                Settings.Default["Dr_DBConnectionString"] = String.Format("Data Source=" + Settings.Default.Server +
                 "; Initial Catalog=" + Settings.Default.Database +
                 "; Integrated Security = false; User ID=" + Settings.Default.ID +
                 "; Password=" + Settings.Default.Password + "");
            }
            else
            {
                 Settings.Default["Dr_DBConnectionString"] = String.Format("Data Source=" + Settings.Default.Server +
                 "; Initial Catalog=" + Settings.Default.Database +
                 "; Integrated Security = True;");
            }

            if (frm == null)
                frm = this;
            user_Taimer1.BringToFront();

            this.bunifuFlatButton4.Visible = false;
            // this.TimeButton.Enabled = false;
            this.TableButton.Visible = false;
            this.NewUserButton.Visible = false;
            this.SettingsButton.Visible = false;
            //this.SalaryBTN.Validate = false;
            //this.ManagementBTN.Validate = false;
            if (Settings.Default.isLicensed == Convert.ToBoolean(Business_Layer.Cls_Encryption.Decrypt(("101 * 117 % 114 % 116 *").ToString())))
            {
                SettingsCala();
                if (TResult == Convert.ToDouble(Business_Layer.Cls_Encryption.Decrypt(Settings.Default.KT.ToString())))
                {
                    return;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private void SettingsCala()
        {
            if (Settings.Default.m1 != string.Empty && Settings.Default.m2 != string.Empty &&
                Settings.Default.m3 != string.Empty && Settings.Default.m4 != string.Empty)
            {
                double S1 = Convert.ToDouble(Settings.Default.m1);
                double S2 = Convert.ToDouble(Settings.Default.m2);
                double S3 = Convert.ToDouble(Settings.Default.m3);
                double S4 = Convert.ToDouble(Settings.Default.m4);
                TResult = (S1 + S2) - (S3 + S4);
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            user_Taimer1.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            user_AddNewUser1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            user_Table1.BringToFront();
            ut.dataGridView1.DataSource = EaE.Get_all_and_shawIt();
        }

        private void user_Taimer21_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            user_login1.BringToFront();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        private void heder_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

        private void user_Table1_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            user_Management1.BringToFront();
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            user_Salary1.BringToFront();
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            user_Message1.BringToFront();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            user_Settings1.BringToFront();
        }

        private void user_login1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AboutBTN_Click(object sender, EventArgs e)
        {
            user_About1.BringToFront();
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            Form_Con FC = new Form_Con();
            FC.ShowDialog();
        }

        private void Working_time_Click(object sender, EventArgs e)
        {
            user_Working_time1.BringToFront();
        }

        private void user_Top1_Load(object sender, EventArgs e)
        {

        }
    }
}
