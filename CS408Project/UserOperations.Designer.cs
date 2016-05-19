namespace CS408Project
{
    partial class UserOperations
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.main_label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(41, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 977);
            this.panel1.TabIndex = 2;
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Location = new System.Drawing.Point(56, 42);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(106, 32);
            this.main_label.TabIndex = 3;
            this.main_label.Text = "Donors";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(917, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(718, 977);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UserOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 1079);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "UserOperations";
            this.Text = "Blood Bank Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.ListView listView1;
    }
}