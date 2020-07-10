namespace Director_of_Entry_AND_Exit.User_Control
{
    partial class Form_Edit
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
            this.user_Taimer1 = new Director_of_Entry_AND_Exit.User_Control.User_Taimer();
            this.SuspendLayout();
            // 
            // user_Taimer1
            // 
            this.user_Taimer1.Location = new System.Drawing.Point(-2, -10);
            this.user_Taimer1.Name = "user_Taimer1";
            this.user_Taimer1.Size = new System.Drawing.Size(900, 527);
            this.user_Taimer1.TabIndex = 0;
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 505);
            this.Controls.Add(this.user_Taimer1);
            this.Name = "Form_Edit";
            this.Text = "Form_Edit";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Taimer user_Taimer1;
    }
}