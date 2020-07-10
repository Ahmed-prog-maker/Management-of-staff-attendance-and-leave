namespace Director_of_Entry_AND_Exit
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPWD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.OkButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtID
            // 
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtID.ForeColor = System.Drawing.Color.Silver;
            this.txtID.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtID.HintText = "اسم المستخدم";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtID.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtID.LineThickness = 3;
            this.txtID.Location = new System.Drawing.Point(43, 201);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(223, 33);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.OnValueChanged += new System.EventHandler(this.txtID_OnValueChanged);
            // 
            // txtPWD
            // 
            this.txtPWD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPWD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPWD.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPWD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPWD.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPWD.ForeColor = System.Drawing.Color.Silver;
            this.txtPWD.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtPWD.HintText = "رقم السري";
            this.txtPWD.isPassword = true;
            this.txtPWD.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtPWD.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPWD.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtPWD.LineThickness = 3;
            this.txtPWD.Location = new System.Drawing.Point(43, 285);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(4);
            this.txtPWD.MaxLength = 32767;
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(223, 33);
            this.txtPWD.TabIndex = 2;
            this.txtPWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OkButton1
            // 
            this.OkButton1.Active = false;
            this.OkButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OkButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OkButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OkButton1.BorderRadius = 0;
            this.OkButton1.ButtonText = "موافق";
            this.OkButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton1.DisabledColor = System.Drawing.Color.Gray;
            this.OkButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.OkButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("OkButton1.Iconimage")));
            this.OkButton1.Iconimage_right = null;
            this.OkButton1.Iconimage_right_Selected = null;
            this.OkButton1.Iconimage_Selected = null;
            this.OkButton1.IconMarginLeft = 0;
            this.OkButton1.IconMarginRight = 0;
            this.OkButton1.IconRightVisible = true;
            this.OkButton1.IconRightZoom = 0D;
            this.OkButton1.IconVisible = true;
            this.OkButton1.IconZoom = 90D;
            this.OkButton1.IsTab = false;
            this.OkButton1.Location = new System.Drawing.Point(43, 378);
            this.OkButton1.Name = "OkButton1";
            this.OkButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OkButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.OkButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.OkButton1.selected = false;
            this.OkButton1.Size = new System.Drawing.Size(108, 36);
            this.OkButton1.TabIndex = 3;
            this.OkButton1.Text = "موافق";
            this.OkButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OkButton1.Textcolor = System.Drawing.Color.White;
            this.OkButton1.TextFont = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 18;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 36;
            this.bunifuTileButton1.LabelText = "تسجيل الدخول";
            this.bunifuTileButton1.Location = new System.Drawing.Point(100, 58);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(108, 111);
            this.bunifuTileButton1.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CancelButton.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(158, 378);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(108, 36);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "الغاء";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "موافق";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(43, 378);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(108, 36);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "موافق";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(158, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "الغاء";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.OkButton1);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_login";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuFlatButton OkButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPWD;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

