namespace CS408Project
{
    partial class Login
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
            this.login_button = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(54, 245);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(179, 96);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(42, 63);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(145, 32);
            this.username_label.TabIndex = 3;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(48, 136);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(139, 32);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Password";
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(250, 63);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(528, 38);
            this.username_input.TabIndex = 5;

            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(250, 136);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(528, 38);
            this.password_input.TabIndex = 6;
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(599, 245);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(179, 96);
            this.close_button.TabIndex = 7;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 408);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.login_button);
            this.Name = "Login";
            this.Text = "Blood Bank Login Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button close_button;
    }
}

