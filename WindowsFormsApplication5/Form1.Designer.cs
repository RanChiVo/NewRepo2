namespace WindowsFormsApplication5
{
    partial class Form1
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
            this.userControl32 = new WindowsFormsApplication5.UserControl3();
            this.userControl31 = new WindowsFormsApplication5.UserControl3();
            this.userControl33 = new WindowsFormsApplication5.UserControl3();
            this.userControl34 = new WindowsFormsApplication5.UserControl3();
            this.SuspendLayout();
            // 
            // userControl32
            // 
            this.userControl32.Location = new System.Drawing.Point(250, 3);
            this.userControl32.Name = "userControl32";
            this.userControl32.Size = new System.Drawing.Size(183, 171);
            this.userControl32.TabIndex = 3;
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(12, 12);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(183, 171);
            this.userControl31.TabIndex = 2;
            // 
            // userControl33
            // 
            this.userControl33.Location = new System.Drawing.Point(12, 189);
            this.userControl33.Name = "userControl33";
            this.userControl33.Size = new System.Drawing.Size(183, 171);
            this.userControl33.TabIndex = 4;
            // 
            // userControl34
            // 
            this.userControl34.Location = new System.Drawing.Point(250, 189);
            this.userControl34.Name = "userControl34";
            this.userControl34.Size = new System.Drawing.Size(183, 171);
            this.userControl34.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 484);
            this.Controls.Add(this.userControl34);
            this.Controls.Add(this.userControl33);
            this.Controls.Add(this.userControl32);
            this.Controls.Add(this.userControl31);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl3 userControl31;
        private UserControl3 userControl32;
        private UserControl3 userControl33;
        private UserControl3 userControl34;
    }
}