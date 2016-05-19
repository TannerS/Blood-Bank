namespace CS408Project
{
    partial class Main
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
            this.register_button = new System.Windows.Forms.Button();
            this.view_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(112, 122);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(308, 50);
            this.register_button.TabIndex = 0;
            this.register_button.Text = "Register Donor";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(112, 486);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(308, 50);
            this.view_button.TabIndex = 1;
            this.view_button.Text = "View Donors";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(112, 302);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(308, 50);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search Donors";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 783);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.register_button);
            this.Name = "Main";
            this.Text = "Blood Bank Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.Button search_button;
    }
}