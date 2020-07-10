using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Director_of_Entry_AND_Exit.Presentation_Layer
{
    public partial class Form_add : Form
    {
        Business_Layer.Cls_Entry_AND_Exit EaE = new Business_Layer.Cls_Entry_AND_Exit();
        Business_Layer.Cls_login log = new Business_Layer.Cls_login();
        int hh1, mm1, ss1=0;
        int hh2, mm2, ss2=0;

        DateTime dt1, dt2;
        
        public Form_add()
        {
            InitializeComponent();
            this.Date_Log_In.Value = DateTime.Now;
            this.Date_Log_Out.Value = DateTime.Now;
            comboID_USER.DataSource = EaE.get_ID_USER();
            comboID_USER.DisplayMember = "Full_Name_USER";
            comboID_USER.ValueMember = "Full_Name_USER";
        }

       

        private void Date_Log_In_onValueChanged(object sender, EventArgs e)
        {
            //Date_Log_In = DateTime.Now.Date;
           
            //string s = Date_Log_In.Value.Date.ToString("d/M/yyyy");
            //dt1 = Convert.ToDateTime(s);

        }

        private void Date_Log_Out_onValueChanged(object sender, EventArgs e)
        {
            //DateTime dt2 = Date_Log_Out.Value.Date;
            //string s = Date_Log_Out.Value.Date.ToString("d/M/yyyy");
            //dt2 = Convert.ToDateTime(s);
        }

        private void comboHH1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hh1 = Convert.ToInt32(comboHH1.Text);
        }

        private void comboMM1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mm1 = Convert.ToInt32(comboMM1.Text);
        }

        private void comboHH2_SelectedIndexChanged(object sender, EventArgs e)
        {
            hh2 = Convert.ToInt32(comboHH2.Text);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (comboID_USER.Text == string.Empty || comboHH1.Text == string.Empty ||
                comboMM1.Text == string.Empty || comboHH2.Text == string.Empty ||
                comboMM2.Text == string.Empty)
            {
                MessageBox.Show("رجاء ادخل جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime dt1 = Date_Log_In.Value.Date;
            DateTime dt2 = Date_Log_Out.Value.Date;

            int a = Math.Abs(((hh2 * 60 * 60) + (mm2 * 60) + ss2) - ((hh1 * 60 * 60) + (mm1 * 60) + ss1));
            double H = a / 3600;
            int B = Math.Abs(((mm2 * 60) + ss2) - ((mm1 * 60) + ss1));
            double M = B / 60;
            int S = Math.Abs(((mm2 * 60) + ss2) - ((mm1 * 60) + ss1));

            string one = Convert.ToString(dt1);
            string two = comboHH1.Text + ":" + comboMM1.Text + ":" + 00 + comboTT1;
            
            DateTime DT1 = Convert.ToDateTime(one + " " + two);
            //DateTime DT11 = DateTime.ParseExact(one + " " + two, "dd/MM/yy h:mm:ss tt" );

            


            EaE.add_Entry_TableE(comboID_USER.Text, dt1, hh1, mm1, ss1, text1.Text, comboTT1.Text, (log.get_Full_Name_USER(comboID_USER.Text)).ToString());
            int ID_Entry = Convert.ToInt32((EaE.get_ID_Entry(comboID_USER.Text)).Rows[0][0]);
            EaE.add_Exit_TableE(comboID_USER.Text, dt2, hh2, mm2, ss2, text2.Text, ID_Entry, comboTT2.Text, H, M, S, (log.get_Full_Name_USER(comboID_USER.Text)).ToString());
            MessageBox.Show("تم الاضافه ", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            string one = Convert.ToString(dt1);
            string two = comboHH1.Text + ":" + comboMM1.Text + ":" + 00 + comboTT1;

            //DateTime DT1 = Convert.ToDateTime(one + " " + two);
            //string ss = Convert.ToString(DT1);
            textBox1.Text = (Convert.ToDateTime(one + " " + two)).ToString();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboMM2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mm2 = Convert.ToInt32(comboMM2.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboTT1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void text1_OnValueChanged(object sender, EventArgs e)
        {

        }

    }
}
