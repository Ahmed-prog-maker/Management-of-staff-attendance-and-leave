namespace Director_of_Entry_AND_Exit.User_Control
{
    partial class User_Message
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.To_Massage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Full_Name_USER = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Date_Labl = new System.Windows.Forms.Label();
            this.Text_Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // To_Massage
            // 
            this.To_Massage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.To_Massage.FormattingEnabled = true;
            this.To_Massage.Location = new System.Drawing.Point(473, 101);
            this.To_Massage.Name = "To_Massage";
            this.To_Massage.Size = new System.Drawing.Size(121, 21);
            this.To_Massage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "الى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(721, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "من";
            // 
            // Full_Name_USER
            // 
            this.Full_Name_USER.AutoSize = true;
            this.Full_Name_USER.Location = new System.Drawing.Point(680, 111);
            this.Full_Name_USER.Name = "Full_Name_USER";
            this.Full_Name_USER.Size = new System.Drawing.Size(35, 13);
            this.Full_Name_USER.TabIndex = 6;
            this.Full_Name_USER.Text = "label3";
            //this.Full_Name_USER.Click += new System.EventHandler(this.Full_Name_USER_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "تاريخ";
            // 
            // Date_Labl
            // 
            this.Date_Labl.AutoSize = true;
            this.Date_Labl.Location = new System.Drawing.Point(236, 108);
            this.Date_Labl.Name = "Date_Labl";
            this.Date_Labl.Size = new System.Drawing.Size(0, 13);
            this.Date_Labl.TabIndex = 8;
            this.Date_Labl.Click += new System.EventHandler(this.label5_Click);
            // 
            // Text_Message
            // 
            this.Text_Message.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Message.ForeColor = System.Drawing.Color.SeaGreen;
            this.Text_Message.Location = new System.Drawing.Point(146, 157);
            this.Text_Message.Multiline = true;
            this.Text_Message.Name = "Text_Message";
            this.Text_Message.Size = new System.Drawing.Size(614, 251);
            this.Text_Message.TabIndex = 9;
            // 
            // User_Message
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Text_Message);
            this.Controls.Add(this.Date_Labl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Full_Name_USER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.To_Massage);
            this.Name = "User_Message";
            this.Size = new System.Drawing.Size(900, 527);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox To_Massage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Full_Name_USER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Date_Labl;
        private System.Windows.Forms.TextBox Text_Message;
    }
}
