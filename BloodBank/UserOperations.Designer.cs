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
            this.donor_panel = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.donor_listview = new System.Windows.Forms.ListView();
            this.Donor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.main_label = new System.Windows.Forms.Label();
            this.donor_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // donor_panel
            // 
            this.donor_panel.Controls.Add(this.exit_button);
            this.donor_panel.Controls.Add(this.donor_listview);
            this.donor_panel.Location = new System.Drawing.Point(41, 59);
            this.donor_panel.Name = "donor_panel";
            this.donor_panel.Size = new System.Drawing.Size(1602, 977);
            this.donor_panel.TabIndex = 2;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(1028, 896);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(550, 70);
            this.exit_button.TabIndex = 24;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // donor_listview
            // 
            this.donor_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Donor,
            this.Age,
            this.ID,
            this.Sex,
            this.Phone,
            this.Address,
            this.City,
            this.State,
            this.Rh,
            this.Amount,
            this.Type});
            this.donor_listview.GridLines = true;
            this.donor_listview.Location = new System.Drawing.Point(43, 36);
            this.donor_listview.Name = "donor_listview";
            this.donor_listview.Size = new System.Drawing.Size(1547, 849);
            this.donor_listview.TabIndex = 4;
            this.donor_listview.UseCompatibleStateImageBehavior = false;
            this.donor_listview.View = System.Windows.Forms.View.Details;
            // 
            // Donor
            // 
            this.Donor.Text = "Donor";
            this.Donor.Width = 150;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 100;
            // 
            // Sex
            // 
            this.Sex.Text = "Sex";
            this.Sex.Width = 100;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 120;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 250;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.Width = 100;
            // 
            // State
            // 
            this.State.Text = "State";
            this.State.Width = 100;
            // 
            // Rh
            // 
            this.Rh.Text = "Rh Factor";
            this.Rh.Width = 150;
            // 
            // Amount
            // 
            this.Amount.Text = "Liters Donated";
            this.Amount.Width = 200;
            // 
            // Type
            // 
            this.Type.Text = "Blood Group";
            this.Type.Width = 180;
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
            // UserOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 1079);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.donor_panel);
            this.Name = "UserOperations";
            this.Text = "Blood Bank Database";
            this.donor_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel donor_panel;
        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.ListView donor_listview;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ColumnHeader Donor;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader Rh;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Type;
    }
}