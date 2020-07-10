namespace Director_of_Entry_AND_Exit.License
{
    partial class Form_EnAndDe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.BtnEn = new System.Windows.Forms.Button();
            this.BtnDe = new System.Windows.Forms.Button();
            this.BtnCansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "نص المدخل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "نص المشفر";
            // 
            // txtDe
            // 
            this.txtDe.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDe.Location = new System.Drawing.Point(128, 27);
            this.txtDe.Multiline = true;
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(295, 29);
            this.txtDe.TabIndex = 2;
            // 
            // txtEn
            // 
            this.txtEn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEn.Location = new System.Drawing.Point(128, 83);
            this.txtEn.Multiline = true;
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(295, 29);
            this.txtEn.TabIndex = 3;
            // 
            // BtnEn
            // 
            this.BtnEn.Location = new System.Drawing.Point(128, 141);
            this.BtnEn.Name = "BtnEn";
            this.BtnEn.Size = new System.Drawing.Size(75, 23);
            this.BtnEn.TabIndex = 4;
            this.BtnEn.Text = "تشفير";
            this.BtnEn.UseVisualStyleBackColor = true;
            this.BtnEn.Click += new System.EventHandler(this.BtnEn_Click);
            // 
            // BtnDe
            // 
            this.BtnDe.Location = new System.Drawing.Point(210, 141);
            this.BtnDe.Name = "BtnDe";
            this.BtnDe.Size = new System.Drawing.Size(75, 23);
            this.BtnDe.TabIndex = 5;
            this.BtnDe.Text = "فك التشفير";
            this.BtnDe.UseVisualStyleBackColor = true;
            this.BtnDe.Click += new System.EventHandler(this.BtnDe_Click);
            // 
            // BtnCansel
            // 
            this.BtnCansel.Location = new System.Drawing.Point(348, 141);
            this.BtnCansel.Name = "BtnCansel";
            this.BtnCansel.Size = new System.Drawing.Size(75, 23);
            this.BtnCansel.TabIndex = 6;
            this.BtnCansel.Text = "خروج";
            this.BtnCansel.UseVisualStyleBackColor = true;
            this.BtnCansel.Click += new System.EventHandler(this.BtnCansel_Click);
            // 
            // Form_EnAndDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 176);
            this.Controls.Add(this.BtnCansel);
            this.Controls.Add(this.BtnDe);
            this.Controls.Add(this.BtnEn);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_EnAndDe";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تشفير النصوص";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.Button BtnEn;
        private System.Windows.Forms.Button BtnDe;
        private System.Windows.Forms.Button BtnCansel;
    }
}