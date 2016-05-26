namespace CS408Project
{
    partial class Search
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
            this.search_listview = new System.Windows.Forms.ListView();
            this.search_groupbox = new System.Windows.Forms.GroupBox();
            this.rh_factor_box = new System.Windows.Forms.ComboBox();
            this.return_box = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.state_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.blood_type = new System.Windows.Forms.ComboBox();
            this.name_label = new System.Windows.Forms.Label();
            this.rh_factor_label = new System.Windows.Forms.Label();
            this.blood_type_label = new System.Windows.Forms.Label();
            this.state_label = new System.Windows.Forms.Label();
            this.search_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_listview
            // 
            this.search_listview.Location = new System.Drawing.Point(804, 28);
            this.search_listview.Name = "search_listview";
            this.search_listview.Size = new System.Drawing.Size(810, 978);
            this.search_listview.TabIndex = 0;
            this.search_listview.UseCompatibleStateImageBehavior = false;
            // 
            // search_groupbox
            // 
            this.search_groupbox.Controls.Add(this.rh_factor_box);
            this.search_groupbox.Controls.Add(this.return_box);
            this.search_groupbox.Controls.Add(this.search_button);
            this.search_groupbox.Controls.Add(this.state_box);
            this.search_groupbox.Controls.Add(this.name_box);
            this.search_groupbox.Controls.Add(this.blood_type);
            this.search_groupbox.Controls.Add(this.name_label);
            this.search_groupbox.Controls.Add(this.rh_factor_label);
            this.search_groupbox.Controls.Add(this.blood_type_label);
            this.search_groupbox.Controls.Add(this.state_label);
            this.search_groupbox.Location = new System.Drawing.Point(25, 28);
            this.search_groupbox.Name = "search_groupbox";
            this.search_groupbox.Size = new System.Drawing.Size(752, 978);
            this.search_groupbox.TabIndex = 1;
            this.search_groupbox.TabStop = false;
            this.search_groupbox.Text = "Search";
            // 
            // rh_factor_box
            // 
            this.rh_factor_box.FormattingEnabled = true;
            this.rh_factor_box.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.rh_factor_box.Location = new System.Drawing.Point(324, 329);
            this.rh_factor_box.Name = "rh_factor_box";
            this.rh_factor_box.Size = new System.Drawing.Size(398, 39);
            this.rh_factor_box.TabIndex = 21;
            // 
            // return_box
            // 
            this.return_box.Location = new System.Drawing.Point(444, 783);
            this.return_box.Name = "return_box";
            this.return_box.Size = new System.Drawing.Size(278, 134);
            this.return_box.TabIndex = 20;
            this.return_box.Text = "Return";
            this.return_box.UseVisualStyleBackColor = true;
            this.return_box.Click += new System.EventHandler(this.return_box_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(30, 783);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(278, 134);
            this.search_button.TabIndex = 19;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // state_box
            // 
            this.state_box.Location = new System.Drawing.Point(324, 152);
            this.state_box.Name = "state_box";
            this.state_box.Size = new System.Drawing.Size(398, 38);
            this.state_box.TabIndex = 15;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(324, 74);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(398, 38);
            this.name_box.TabIndex = 14;
            // 
            // blood_type
            // 
            this.blood_type.FormattingEnabled = true;
            this.blood_type.Items.AddRange(new object[] {
            "A",
            "AB",
            "B",
            "O"});
            this.blood_type.Location = new System.Drawing.Point(324, 238);
            this.blood_type.Name = "blood_type";
            this.blood_type.Size = new System.Drawing.Size(398, 39);
            this.blood_type.TabIndex = 8;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(24, 74);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(90, 32);
            this.name_label.TabIndex = 6;
            this.name_label.Text = "Name";
            // 
            // rh_factor_label
            // 
            this.rh_factor_label.AutoSize = true;
            this.rh_factor_label.Location = new System.Drawing.Point(24, 336);
            this.rh_factor_label.Name = "rh_factor_label";
            this.rh_factor_label.Size = new System.Drawing.Size(138, 32);
            this.rh_factor_label.TabIndex = 5;
            this.rh_factor_label.Text = "Rh Factor";
            // 
            // blood_type_label
            // 
            this.blood_type_label.AutoSize = true;
            this.blood_type_label.Location = new System.Drawing.Point(24, 245);
            this.blood_type_label.Name = "blood_type_label";
            this.blood_type_label.Size = new System.Drawing.Size(159, 32);
            this.blood_type_label.TabIndex = 2;
            this.blood_type_label.Text = "Blood Type";
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Location = new System.Drawing.Point(24, 158);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(82, 32);
            this.state_label.TabIndex = 0;
            this.state_label.Text = "State";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 1031);
            this.Controls.Add(this.search_groupbox);
            this.Controls.Add(this.search_listview);
            this.Name = "Search";
            this.Text = "Search";
            this.search_groupbox.ResumeLayout(false);
            this.search_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView search_listview;
        private System.Windows.Forms.GroupBox search_groupbox;
        private System.Windows.Forms.TextBox state_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.ComboBox blood_type;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label rh_factor_label;
        private System.Windows.Forms.Label blood_type_label;
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button return_box;
        private System.Windows.Forms.ComboBox rh_factor_box;
    }
}