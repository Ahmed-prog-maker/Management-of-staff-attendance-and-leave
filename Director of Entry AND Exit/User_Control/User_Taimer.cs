using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Director_of_Entry_AND_Exit.Properties;

namespace Director_of_Entry_AND_Exit.User_Control
{
    public partial class User_Taimer : UserControl
    {
       
        Business_Layer.Cls_Entry_AND_Exit EaE = new Business_Layer.Cls_Entry_AND_Exit();
        Business_Layer.Cls_login log = new Business_Layer.Cls_login();

        Timer t = new Timer();
        int hh1, mm1, ss1;
        int hh2, mm2, ss2;
        //string TTime ="0.00";

        
      
        public User_Taimer()
        {
            InitializeComponent();
            // groupBox2.Enabled = false;

            text1.Enabled = false;
            text2.Enabled = false;
            ExitButton.Enabled = false;
        }
        

        private void User_Taimer_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_tick);

            t.Start();
        }

        private void t_tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            //string ST = DateTime.Now.ToString("tt");

            string Time = "";

            if (hh < 10)
                Time += "0" + hh;
            else
                Time += hh;
            Time += ":";

            if (mm < 10)
                Time += "0" + mm;
            else
                Time += mm;
            Time += ":";
            
            if (ss < 10)
             Time += "0" + ss;
            else
             Time += ss;

            //Time += ST;

            label1.Text = Time;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.login(txtID.Text, txtPWD.Text);

            // NameID = txtID.Text;
            //Presentation_Layer.Form_main.NameID = ((log.get_Full_Name_USER(txtID.Text)).Rows[0][0]).ToString();

            //Dt.Rows[0]["Full_Name_USER"].ToString();
            //
           if (Settings.Default.U == txtID.Text && Settings.Default.P == txtPWD.Text)
            {
                Presentation_Layer.Form_main.getMainForm.TableButton.Visible = true;
                Presentation_Layer.Form_main.getMainForm.NewUserButton.Visible = true;
                Presentation_Layer.Form_main.getMainForm.SalaryBTN.Visible = true;
                Presentation_Layer.Form_main.getMainForm.ManagementBTN.Visible = true;
                Presentation_Layer.Form_main.getMainForm.ExitButton.Visible = true;
                Presentation_Layer.Form_main.getMainForm.SettingsButton.Visible = true;
                Presentation_Layer.Form_main.getMainForm.Working_time.Visible = true;

                
            }
            else
            {
                if (Dt.Rows.Count > 0)
                {

                    if (Dt.Rows[0][2].ToString() == "مدير")
                    {
                        //Presentation_Layer.Form_main.getMainForm.TimeButton.Enabled = true;
                        Presentation_Layer.Form_main.getMainForm.TableButton.Visible = true;
                        Presentation_Layer.Form_main.getMainForm.NewUserButton.Visible = true;
                        Presentation_Layer.Form_main.getMainForm.SalaryBTN.Visible = true;
                        Presentation_Layer.Form_main.getMainForm.ManagementBTN.Visible = true;
                        Presentation_Layer.Form_main.getMainForm.ExitButton.Visible = true;
                        Presentation_Layer.Form_main.getMainForm.SettingsButton.Visible = true;
                        Presentation_Layer.Form_main.getMainForm.Working_time.Visible = true;
                        Settings.Default.FullName = txtID.Text;
                        Settings.Default.Save();
                    }

                    else if (Dt.Rows[0][2].ToString() == "عادي")
                    {
                        //Presentation_Layer.Form_main.getMainForm.TableButton.Visible = false;
                        //Presentation_Layer.Form_main.getMainForm.NewUserButton.Visible = false;
                        //Presentation_Layer.Form_main.getMainForm.SettingsButton.Visible = false;
                        Settings.Default.FullName = txtID.Text;
                        Settings.Default.Save();
                    }
                    Log_In_Button.Enabled = true;
                    Log_Out_Button.Enabled = true;
                    txtID.Enabled = false;
                    txtPWD.Enabled = false;
                    groupBox2.Enabled = true;
                    ExitButton.Enabled = true;
                    okButton.Enabled = false;
                    groupBox2.Enabled = true;

                    MessageBox.Show("تم تسجيل الدخول بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("لم يتم تسجيل الدخول", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
            DataTable ddt = EaE.get_Messege_Table(txtID.Text);
            //if (ddt.Rows[4]["Flat_Message"].ToString() == "0")
            //{
            //    Presentation_Layer.Form_Reception_Message FRM = new Presentation_Layer.Form_Reception_Message();
            //    FRM.Full_Name_USER.Text = ddt.Rows[0]["Full_Name_USER"].ToString();
            //    FRM.Date_Labl.Text = ddt.Rows[0]["Date_Message"].ToString();
            //    FRM.To_Massage.Text = ddt.Rows[0]["To_Massage"].ToString();
            //    FRM.Text_Message.Text = ddt.Rows[0]["To_Massage"].ToString();
            //    FRM.ShowDialog();
            //}
            //else
            //    txtID.Text = txtID.Text;

        }

        private void Log_In_Button_Click(object sender, EventArgs e)
        {
           

        }

        private void Log_Out_Button_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            int ID_Entry = Convert.ToInt32( (EaE.get_ID_Entry(txtID.Text)).Rows[0][0]);

            DateTime dt = DateTime.Now;
            //string s = DateTime.Now.ToString("d/M/yyyy");
            //DateTime dt = Convert.ToDateTime(s);

            string T = DateTime.Now.ToString("tt");

            //int a = Math.Abs(((hh2 * 60 * 60) + (mm2 * 60) + ss2) - ((hh1 * 60 * 60) + (mm1 * 60) + ss1));
            //double H = a / 3600;
            //int B = Math.Abs(((mm2 * 60) + ss2) - ((mm1 * 60) + ss1));
            //double M = B / 60;
            //int S = Math.Abs(((mm2 * 60) + ss2) - ((mm1 * 60) + ss1));

            int a = Math.Abs(((hh2 * 60 ) + mm2 ) - ((hh1 * 60) + mm1));
            double H = a / 60;
            int B = Math.Abs(mm2-mm1);
            double M = B;
            int S = Math.Abs(((mm2 * 60) + ss2) - ((mm1 * 60) + ss1));

            EaE.add_Exit_TableE(txtID.Text, dt, hh2, mm2, ss2, text2.Text, ID_Entry, T, H, M, S, (log.get_Full_Name_USER(txtID.Text).Rows[0][0]).ToString());

            //string Date = DateTime.Now.Date.ToString("d/M/yyyy");
            //EaE.ADD_TIMING(txtID.Text, LABLog_In.Text, text1.Text, LABLog_Out.Text, text2.Text, TTime, Date);

            MessageBox.Show("تم الحفظ", "عمليه الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {


            Log_In_Button.Enabled = false;
            Log_Out_Button.Enabled = false;
            Log_Out_Save.Enabled = false;
            Log_In_Save.Enabled = false;
            text1.Enabled = false;
            text2.Enabled = false;
            ExitButton.Enabled = false;

            txtID.Enabled = true;
            txtPWD.Enabled = true;
            //groupBox2.Enabled = false;
            okButton.Enabled = true;
            ExitButton.Enabled = false;

            Presentation_Layer.Form_main.getMainForm.TableButton.Visible = false;
            Presentation_Layer.Form_main.getMainForm.Working_time.Visible = false;
            Presentation_Layer.Form_main.getMainForm.NewUserButton.Visible = false;
            Presentation_Layer.Form_main.getMainForm.SalaryBTN.Visible = false;
            Presentation_Layer.Form_main.getMainForm.ManagementBTN.Visible = false;
            Presentation_Layer.Form_main.getMainForm.ExitButton.Visible = false;
            Presentation_Layer.Form_main.getMainForm.SettingsButton.Visible = false;

            txtID.Text = "";
            txtPWD.Text = "";
            text1.Clear();
            text2.Clear();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //string s = DateTime.Now.ToString("d/M/yyyy");
            //DateTime dt = Convert.ToDateTime(s);

            string ST = DateTime.Now.ToString("tt");
            EaE.add_Entry_TableE(txtID.Text, dt, hh1, mm1, ss1, text1.Text, ST, (log.get_Full_Name_USER(txtID.Text).Rows[0][0]).ToString());

            MessageBox.Show("تم الحفظ", "عمليه الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPWD.Focus();
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okButton.Focus();
            }
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            hh1 = DateTime.Now.Hour;
            mm1 = DateTime.Now.Minute;
            ss1 = DateTime.Now.Second;
            string ST = DateTime.Now.ToString("tt");

            string Time = "";

            if (hh1 < 10)
                Time += "0" + hh1;
            else
                Time += hh1;
            Time += ":";

            if (mm1 < 10)
                Time += "0" + mm1;
            else
                Time += mm1;
            Time += ":";

            if (ss1 < 10)
                Time += "0" + ss1;
            else
                Time += ss1;
            Time += ST;

            LABLog_In.Text = Time;

            text1.Enabled = true;
            Log_In_Save.Enabled = true;
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            hh2 = DateTime.Now.Hour;
            mm2 = DateTime.Now.Minute;
            ss2 = DateTime.Now.Second;
            string ST = DateTime.Now.ToString("tt");

            string Time = "";

            if (hh2 < 10)
                Time += "0" + hh2;
            else
                Time += hh2;
            Time += ":";

            if (mm2 < 10)
                Time += "0" + mm2;
            else
                Time += mm2;
            Time += ":";

            if (ss2 < 10)
                Time += "0" + ss2;
            else
                Time += ss2;
            Time += ST;

            LABLog_Out.Text = Time;

            text2.Enabled = true;
            Log_Out_Save.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

             
        }
    }
}
