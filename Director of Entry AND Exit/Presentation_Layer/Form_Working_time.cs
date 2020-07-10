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
    public partial class Form_Working_time : Form
    {
        Business_Layer.Cls_Entry_AND_Exit EaE = new Business_Layer.Cls_Entry_AND_Exit();
        public Form_Working_time()
        {
            InitializeComponent();
        }

        void cula()
        {
            if (From_M.Text != string.Empty && To_M.Text != string.Empty && From_H.Text != string.Empty && To_H.Text != string.Empty)
            {
                Double TOTALH = Math.Abs(Convert.ToDouble(From_H.Text) - Convert.ToDouble(To_H.Text));
                Double TOTALM = (Math.Abs(Convert.ToDouble(From_M.Text) - Convert.ToDouble(To_M.Text))) / 60;

                total_hours.Text = Convert.ToString(TOTALH + TOTALM);
            }
        }

        private void From_M_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void From_M_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void From_M_KeyUp(object sender, KeyEventArgs e)
        {
            cula();
        }

        private void From_H_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void From_H_KeyUp(object sender, KeyEventArgs e)
        {
            cula();
        }

        private void To_M_KeyUp(object sender, KeyEventArgs e)
        {
            cula();
        }

        private void To_H_KeyUp(object sender, KeyEventArgs e)
        {
            cula();
        }

        private void From_H_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void To_M_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void To_H_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (From_M.Text != string.Empty && To_M.Text != string.Empty && From_H.Text != string.Empty &&
                To_H.Text != string.Empty && Name_Working_time.Text != string.Empty)
            {

                string From_total = From_H.Text + ":" + From_M.Text;
                string To_total = To_H.Text + ":" + To_M.Text;


                int mm = Convert.ToInt32(To_M.Text) - Convert.ToInt32(From_M.Text);
                int hh = Convert.ToInt32(To_H.Text) - Convert.ToInt32(From_H.Text);
                string totalDT = hh.ToString() + ":" + mm.ToString();

                DateTime From_total1 = Convert.ToDateTime(From_total);
                DateTime To_total1 = Convert.ToDateTime(To_total);


                DateTime totalDT1 = Convert.ToDateTime(totalDT);

                TextBox t1 = new TextBox();
                t1.Text = From_total1.ToString("hh:mm");

                TextBox t2 = new TextBox();
                t2.Text = To_total1.ToString("hh:mm");

                TextBox t3 = new TextBox();
                t3.Text = totalDT1.ToString("hh:mm:ss");

                // DateTime dt3 = Convert.ToDateTime(t3.Text);

                String Holidays = "";

                EaE.Add_Working_time(Name_Working_time.Text, t1.Text, t2.Text, total_hours.Text, Convert.ToDateTime(t3.Text), Holidays);
                MessageBox.Show("تم التعديل", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
