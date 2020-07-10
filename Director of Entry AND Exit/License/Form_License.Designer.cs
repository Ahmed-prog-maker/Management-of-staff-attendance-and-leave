namespace Director_of_Entry_AND_Exit.License
{
    partial class Form_License
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_License));
            this.txtSerial1 = new System.Windows.Forms.TextBox();
            this.txtSerial4 = new System.Windows.Forms.TextBox();
            this.txtSerial3 = new System.Windows.Forms.TextBox();
            this.txtSerial2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnTrial = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSerial1
            // 
            this.txtSerial1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial1.Location = new System.Drawing.Point(49, 57);
            this.txtSerial1.MaxLength = 4;
            this.txtSerial1.Multiline = true;
            this.txtSerial1.Name = "txtSerial1";
            this.txtSerial1.Size = new System.Drawing.Size(68, 31);
            this.txtSerial1.TabIndex = 0;
            this.txtSerial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerial1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial1_KeyDown);
            this.txtSerial1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerial1_KeyPress);
            // 
            // txtSerial4
            // 
            this.txtSerial4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial4.Location = new System.Drawing.Point(271, 57);
            this.txtSerial4.MaxLength = 4;
            this.txtSerial4.Multiline = true;
            this.txtSerial4.Name = "txtSerial4";
            this.txtSerial4.Size = new System.Drawing.Size(68, 31);
            this.txtSerial4.TabIndex = 1;
            this.txtSerial4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerial4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial4_KeyDown);
            this.txtSerial4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerial4_KeyPress);
            // 
            // txtSerial3
            // 
            this.txtSerial3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial3.Location = new System.Drawing.Point(197, 57);
            this.txtSerial3.MaxLength = 4;
            this.txtSerial3.Multiline = true;
            this.txtSerial3.Name = "txtSerial3";
            this.txtSerial3.Size = new System.Drawing.Size(68, 31);
            this.txtSerial3.TabIndex = 2;
            this.txtSerial3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerial3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial3_KeyDown);
            this.txtSerial3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerial3_KeyPress);
            // 
            // txtSerial2
            // 
            this.txtSerial2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial2.Location = new System.Drawing.Point(123, 57);
            this.txtSerial2.MaxLength = 4;
            this.txtSerial2.Multiline = true;
            this.txtSerial2.Name = "txtSerial2";
            this.txtSerial2.Size = new System.Drawing.Size(68, 31);
            this.txtSerial2.TabIndex = 3;
            this.txtSerial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerial2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial2_KeyDown);
            this.txtSerial2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerial2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "السيريل";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(221, 106);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 35);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "تسجيل";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnTrial
            // 
            this.BtnTrial.Location = new System.Drawing.Point(98, 106);
            this.BtnTrial.Name = "BtnTrial";
            this.BtnTrial.Size = new System.Drawing.Size(75, 35);
            this.BtnTrial.TabIndex = 6;
            this.BtnTrial.Text = "تجريبي";
            this.BtnTrial.UseVisualStyleBackColor = true;
            this.BtnTrial.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(171, 20);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(174, 16);
            this.labelText.TabIndex = 7;
            this.labelText.Text = "الفترة التجريبية المسموحة لك ";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(150, 18);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(24, 18);
            this.labelDays.TabIndex = 8;
            this.labelDays.Text = "15";
            this.labelDays.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "يوم";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "اعدادت اتصال بالسيرفر";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(10, 166);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(151, 39);
            this.bunifuFlatButton1.TabIndex = 10;
            this.bunifuFlatButton1.Text = "اعدادت اتصال بالسيرفر";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSerial1);
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.labelText);
            this.groupBox1.Controls.Add(this.labelDays);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnTrial);
            this.groupBox1.Controls.Add(this.txtSerial3);
            this.groupBox1.Controls.Add(this.txtSerial4);
            this.groupBox1.Controls.Add(this.txtSerial2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 213);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 237);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_License";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفعيل البرنامج";
            this.Load += new System.EventHandler(this.Form_License_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerial1;
        private System.Windows.Forms.TextBox txtSerial4;
        private System.Windows.Forms.TextBox txtSerial3;
        private System.Windows.Forms.TextBox txtSerial2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnTrial;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}