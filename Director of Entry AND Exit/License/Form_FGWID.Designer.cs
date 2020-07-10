namespace Director_of_Entry_AND_Exit.License
{
    partial class Form_FGWID
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
            this.TxGet = new System.Windows.Forms.TextBox();
            this.BuGet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "سيريل";
            // 
            // TxGet
            // 
            this.TxGet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxGet.Location = new System.Drawing.Point(118, 30);
            this.TxGet.Multiline = true;
            this.TxGet.Name = "TxGet";
            this.TxGet.ReadOnly = true;
            this.TxGet.Size = new System.Drawing.Size(231, 34);
            this.TxGet.TabIndex = 1;
            this.TxGet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuGet
            // 
            this.BuGet.Location = new System.Drawing.Point(118, 92);
            this.BuGet.Name = "BuGet";
            this.BuGet.Size = new System.Drawing.Size(75, 29);
            this.BuGet.TabIndex = 0;
            this.BuGet.Text = "توليد سيريل";
            this.BuGet.UseVisualStyleBackColor = true;
            this.BuGet.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_FGWID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 151);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BuGet);
            this.Controls.Add(this.TxGet);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_FGWID";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مولد سيريل CPU ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxGet;
        private System.Windows.Forms.Button BuGet;
        private System.Windows.Forms.Button button2;
    }
}