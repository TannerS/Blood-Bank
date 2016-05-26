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
            this.return_box = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.id_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.blood_type_box = new System.Windows.Forms.TextBox();
            this.state_box = new System.Windows.Forms.TextBox();
            this.blood_type_label = new System.Windows.Forms.Label();
            this.state_label = new System.Windows.Forms.Label();
            this.city_box = new System.Windows.Forms.TextBox();
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
            this.search_groupbox.Controls.Add(this.city_box);
            this.search_groupbox.Controls.Add(this.blood_type_box);
            this.search_groupbox.Controls.Add(this.state_box);
            this.search_groupbox.Controls.Add(this.blood_type_label);
            this.search_groupbox.Controls.Add(this.state_label);
            this.search_groupbox.Controls.Add(this.return_box);
            this.search_groupbox.Controls.Add(this.search_button);
            this.search_groupbox.Controls.Add(this.id_box);
            this.search_groupbox.Controls.Add(this.name_box);
            this.search_groupbox.Controls.Add(this.name_label);
            this.search_groupbox.Controls.Add(this.city_label);
            this.search_groupbox.Controls.Add(this.id_label);
            this.search_groupbox.Location = new System.Drawing.Point(25, 28);
            this.search_groupbox.Name = "search_groupbox";
            this.search_groupbox.Size = new System.Drawing.Size(752, 978);
            this.search_groupbox.TabIndex = 1;
            this.search_groupbox.TabStop = false;
            this.search_groupbox.Text = "Search";
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
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(324, 152);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(398, 38);
            this.id_box.TabIndex = 15;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(324, 74);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(398, 38);
            this.name_box.TabIndex = 14;
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
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(24, 245);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(64, 32);
            this.city_label.TabIndex = 2;
            this.city_label.Text = "City";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(24, 158);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(42, 32);
            this.id_label.TabIndex = 0;
            this.id_label.Text = "ID";
            // 
            // blood_type_box
            // 
            this.blood_type_box.Location = new System.Drawing.Point(324, 402);
            this.blood_type_box.Name = "blood_type_box";
            this.blood_type_box.Size = new System.Drawing.Size(398, 38);
            this.blood_type_box.TabIndex = 28;
            // 
            // state_box
            // 
            this.state_box.Location = new System.Drawing.Point(324, 321);
            this.state_box.Name = "state_box";
            this.state_box.Size = new System.Drawing.Size(398, 38);
            this.state_box.TabIndex = 27;
            // 
            // blood_type_label
            // 
            this.blood_type_label.AutoSize = true;
            this.blood_type_label.Location = new System.Drawing.Point(24, 408);
            this.blood_type_label.Name = "blood_type_label";
            this.blood_type_label.Size = new System.Drawing.Size(159, 32);
            this.blood_type_label.TabIndex = 23;
            this.blood_type_label.Text = "Blood Type";
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Location = new System.Drawing.Point(24, 327);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(82, 32);
            this.state_label.TabIndex = 22;
            this.state_label.Text = "State";
            // 
            // city_box
            // 
            this.city_box.Location = new System.Drawing.Point(324, 239);
            this.city_box.Name = "city_box";
            this.city_box.Size = new System.Drawing.Size(398, 38);
            this.city_box.TabIndex = 30;
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
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button return_box;
        private System.Windows.Forms.TextBox blood_type_box;
        private System.Windows.Forms.TextBox state_box;
        private System.Windows.Forms.Label blood_type_label;
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.TextBox city_box;
    }
}