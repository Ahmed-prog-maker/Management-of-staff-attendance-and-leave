namespace Director_of_Entry_AND_Exit.Presentation_Layer
{
    partial class Form_Working_time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Working_time));
            this.label1 = new System.Windows.Forms.Label();
            this.From_H = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.From_M = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Name_Working_time = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total_hours = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.To_H = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.To_M = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "من";
            // 
            // From_H
            // 
            this.From_H.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.From_H.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.From_H.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.From_H.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.From_H.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_H.ForeColor = System.Drawing.Color.DimGray;
            this.From_H.HintForeColor = System.Drawing.Color.DimGray;
            this.From_H.HintText = "ساعه";
            this.From_H.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.From_H.isPassword = false;
            this.From_H.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.From_H.LineIdleColor = System.Drawing.Color.DarkGray;
            this.From_H.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.From_H.LineThickness = 3;
            this.From_H.Location = new System.Drawing.Point(265, 126);
            this.From_H.Margin = new System.Windows.Forms.Padding(4);
            this.From_H.MaxLength = 2;
            this.From_H.Name = "From_H";
            this.From_H.Size = new System.Drawing.Size(45, 33);
            this.From_H.TabIndex = 41;
            this.From_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.From_H.OnValueChanged += new System.EventHandler(this.From_H_OnValueChanged);
            this.From_H.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.From_H_KeyPress);
            this.From_H.KeyUp += new System.Windows.Forms.KeyEventHandler(this.From_H_KeyUp);
            // 
            // From_M
            // 
            this.From_M.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.From_M.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.From_M.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.From_M.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.From_M.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_M.ForeColor = System.Drawing.Color.DimGray;
            this.From_M.HintForeColor = System.Drawing.Color.DimGray;
            this.From_M.HintText = "دقيقه";
            this.From_M.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.From_M.isPassword = false;
            this.From_M.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.From_M.LineIdleColor = System.Drawing.Color.DarkGray;
            this.From_M.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.From_M.LineThickness = 3;
            this.From_M.Location = new System.Drawing.Point(183, 126);
            this.From_M.Margin = new System.Windows.Forms.Padding(4);
            this.From_M.MaxLength = 2;
            this.From_M.Name = "From_M";
            this.From_M.Size = new System.Drawing.Size(45, 33);
            this.From_M.TabIndex = 40;
            this.From_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.From_M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.From_M_KeyPress);
            this.From_M.KeyUp += new System.Windows.Forms.KeyEventHandler(this.From_M_KeyUp);
            // 
            // Name_Working_time
            // 
            this.Name_Working_time.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Name_Working_time.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Name_Working_time.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Name_Working_time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_Working_time.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Working_time.ForeColor = System.Drawing.Color.DimGray;
            this.Name_Working_time.HintForeColor = System.Drawing.Color.DimGray;
            this.Name_Working_time.HintText = "فترة الدوام";
            this.Name_Working_time.isPassword = false;
            this.Name_Working_time.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.Name_Working_time.LineIdleColor = System.Drawing.Color.DarkGray;
            this.Name_Working_time.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.Name_Working_time.LineThickness = 3;
            this.Name_Working_time.Location = new System.Drawing.Point(183, 66);
            this.Name_Working_time.Margin = new System.Windows.Forms.Padding(4);
            this.Name_Working_time.MaxLength = 32767;
            this.Name_Working_time.Name = "Name_Working_time";
            this.Name_Working_time.Size = new System.Drawing.Size(127, 33);
            this.Name_Working_time.TabIndex = 39;
            this.Name_Working_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "من";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "فترة الدوام";
            // 
            // total_hours
            // 
            this.total_hours.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.total_hours.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.total_hours.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.total_hours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.total_hours.Enabled = false;
            this.total_hours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_hours.ForeColor = System.Drawing.Color.DimGray;
            this.total_hours.HintForeColor = System.Drawing.Color.DimGray;
            this.total_hours.HintText = "عدد ساعات الدوام";
            this.total_hours.isPassword = false;
            this.total_hours.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.total_hours.LineIdleColor = System.Drawing.Color.DarkGray;
            this.total_hours.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.total_hours.LineThickness = 3;
            this.total_hours.Location = new System.Drawing.Point(183, 260);
            this.total_hours.Margin = new System.Windows.Forms.Padding(4);
            this.total_hours.MaxLength = 3;
            this.total_hours.Name = "total_hours";
            this.total_hours.Size = new System.Drawing.Size(127, 33);
            this.total_hours.TabIndex = 49;
            this.total_hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "عدد ساعات الدوام";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "حفظ";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(90, 363);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(81, 36);
            this.bunifuFlatButton1.TabIndex = 51;
            this.bunifuFlatButton1.Text = "حفظ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "الغاء";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(219, 363);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(81, 36);
            this.bunifuFlatButton2.TabIndex = 52;
            this.bunifuFlatButton2.Text = "الغاء";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // To_H
            // 
            this.To_H.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.To_H.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.To_H.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.To_H.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.To_H.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_H.ForeColor = System.Drawing.Color.DimGray;
            this.To_H.HintForeColor = System.Drawing.Color.DimGray;
            this.To_H.HintText = "ساعه";
            this.To_H.isPassword = false;
            this.To_H.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.To_H.LineIdleColor = System.Drawing.Color.DarkGray;
            this.To_H.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.To_H.LineThickness = 3;
            this.To_H.Location = new System.Drawing.Point(265, 191);
            this.To_H.Margin = new System.Windows.Forms.Padding(4);
            this.To_H.MaxLength = 2;
            this.To_H.Name = "To_H";
            this.To_H.Size = new System.Drawing.Size(45, 33);
            this.To_H.TabIndex = 54;
            this.To_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.To_H.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.To_H_KeyPress);
            this.To_H.KeyUp += new System.Windows.Forms.KeyEventHandler(this.To_H_KeyUp);
            // 
            // To_M
            // 
            this.To_M.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.To_M.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.To_M.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.To_M.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.To_M.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_M.ForeColor = System.Drawing.Color.DimGray;
            this.To_M.HintForeColor = System.Drawing.Color.DimGray;
            this.To_M.HintText = "دقيقه";
            this.To_M.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.To_M.isPassword = false;
            this.To_M.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.To_M.LineIdleColor = System.Drawing.Color.DarkGray;
            this.To_M.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.To_M.LineThickness = 3;
            this.To_M.Location = new System.Drawing.Point(183, 191);
            this.To_M.Margin = new System.Windows.Forms.Padding(4);
            this.To_M.MaxLength = 2;
            this.To_M.Name = "To_M";
            this.To_M.Size = new System.Drawing.Size(45, 33);
            this.To_M.TabIndex = 53;
            this.To_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.To_M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.To_M_KeyPress);
            this.To_M.KeyUp += new System.Windows.Forms.KeyEventHandler(this.To_M_KeyUp);
            // 
            // Form_Working_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 467);
            this.Controls.Add(this.To_H);
            this.Controls.Add(this.To_M);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total_hours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.From_H);
            this.Controls.Add(this.From_M);
            this.Controls.Add(this.Name_Working_time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Working_time";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل جدول الدوامات";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox From_H;
        public Bunifu.Framework.UI.BunifuMaterialTextbox From_M;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Name_Working_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public Bunifu.Framework.UI.BunifuMaterialTextbox total_hours;
        private System.Windows.Forms.Label label6;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox To_H;
        public Bunifu.Framework.UI.BunifuMaterialTextbox To_M;
    }
}