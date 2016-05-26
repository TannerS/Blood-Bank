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
            this.and_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.or_label_three = new System.Windows.Forms.Label();
            this.or_label_two = new System.Windows.Forms.Label();
            this.city_box = new System.Windows.Forms.TextBox();
            this.blood_type_label = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.state_box = new System.Windows.Forms.TextBox();
            this.state_label = new System.Windows.Forms.Label();
            this.blood_type_box = new System.Windows.Forms.TextBox();
            this.or_label = new System.Windows.Forms.Label();
            this.return_box = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.id_box = new System.Windows.Forms.TextBox();
            this.lname_box = new System.Windows.Forms.TextBox();
            this.lname_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.fname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.liters = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search_groupbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_listview
            // 
            this.search_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fname,
            this.lname,
            this.age,
            this.sex,
            this.phone,
            this.address,
            this.city,
            this.state,
            this.rh,
            this.liters,
            this.type});
            this.search_listview.GridLines = true;
            this.search_listview.Location = new System.Drawing.Point(804, 28);
            this.search_listview.Name = "search_listview";
            this.search_listview.Size = new System.Drawing.Size(1605, 978);
            this.search_listview.TabIndex = 0;
            this.search_listview.UseCompatibleStateImageBehavior = false;
            this.search_listview.View = System.Windows.Forms.View.Details;
            // 
            // search_groupbox
            // 
            this.search_groupbox.Controls.Add(this.and_label);
            this.search_groupbox.Controls.Add(this.panel1);
            this.search_groupbox.Controls.Add(this.or_label);
            this.search_groupbox.Controls.Add(this.return_box);
            this.search_groupbox.Controls.Add(this.search_button);
            this.search_groupbox.Controls.Add(this.id_box);
            this.search_groupbox.Controls.Add(this.lname_box);
            this.search_groupbox.Controls.Add(this.lname_label);
            this.search_groupbox.Controls.Add(this.id_label);
            this.search_groupbox.Location = new System.Drawing.Point(25, 28);
            this.search_groupbox.Name = "search_groupbox";
            this.search_groupbox.Size = new System.Drawing.Size(752, 978);
            this.search_groupbox.TabIndex = 1;
            this.search_groupbox.TabStop = false;
            this.search_groupbox.Text = "Search";
            // 
            // and_label
            // 
            this.and_label.AutoSize = true;
            this.and_label.Location = new System.Drawing.Point(438, 249);
            this.and_label.Name = "and_label";
            this.and_label.Size = new System.Drawing.Size(74, 32);
            this.and_label.TabIndex = 32;
            this.and_label.Text = "AND";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.or_label_three);
            this.panel1.Controls.Add(this.or_label_two);
            this.panel1.Controls.Add(this.city_box);
            this.panel1.Controls.Add(this.blood_type_label);
            this.panel1.Controls.Add(this.city_label);
            this.panel1.Controls.Add(this.state_box);
            this.panel1.Controls.Add(this.state_label);
            this.panel1.Controls.Add(this.blood_type_box);
            this.panel1.Location = new System.Drawing.Point(15, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 354);
            this.panel1.TabIndex = 33;
            // 
            // or_label_three
            // 
            this.or_label_three.AutoSize = true;
            this.or_label_three.Location = new System.Drawing.Point(423, 207);
            this.or_label_three.Name = "or_label_three";
            this.or_label_three.Size = new System.Drawing.Size(57, 32);
            this.or_label_three.TabIndex = 33;
            this.or_label_three.Text = "OR";
            // 
            // or_label_two
            // 
            this.or_label_two.AutoSize = true;
            this.or_label_two.Location = new System.Drawing.Point(423, 93);
            this.or_label_two.Name = "or_label_two";
            this.or_label_two.Size = new System.Drawing.Size(57, 32);
            this.or_label_two.TabIndex = 32;
            this.or_label_two.Text = "OR";
            // 
            // city_box
            // 
            this.city_box.Location = new System.Drawing.Point(179, 28);
            this.city_box.Name = "city_box";
            this.city_box.Size = new System.Drawing.Size(528, 38);
            this.city_box.TabIndex = 30;
            // 
            // blood_type_label
            // 
            this.blood_type_label.AutoSize = true;
            this.blood_type_label.Location = new System.Drawing.Point(9, 264);
            this.blood_type_label.Name = "blood_type_label";
            this.blood_type_label.Size = new System.Drawing.Size(159, 32);
            this.blood_type_label.TabIndex = 23;
            this.blood_type_label.Text = "Blood Type";
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(9, 34);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(64, 32);
            this.city_label.TabIndex = 2;
            this.city_label.Text = "City";
            // 
            // state_box
            // 
            this.state_box.Location = new System.Drawing.Point(179, 147);
            this.state_box.Name = "state_box";
            this.state_box.Size = new System.Drawing.Size(528, 38);
            this.state_box.TabIndex = 27;
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Location = new System.Drawing.Point(9, 153);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(82, 32);
            this.state_label.TabIndex = 22;
            this.state_label.Text = "State";
            // 
            // blood_type_box
            // 
            this.blood_type_box.Location = new System.Drawing.Point(179, 258);
            this.blood_type_box.Name = "blood_type_box";
            this.blood_type_box.Size = new System.Drawing.Size(528, 38);
            this.blood_type_box.TabIndex = 28;
            // 
            // or_label
            // 
            this.or_label.AutoSize = true;
            this.or_label.Location = new System.Drawing.Point(438, 119);
            this.or_label.Name = "or_label";
            this.or_label.Size = new System.Drawing.Size(57, 32);
            this.or_label.TabIndex = 31;
            this.or_label.Text = "OR";
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
            this.id_box.Location = new System.Drawing.Point(194, 60);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(528, 38);
            this.id_box.TabIndex = 15;
            // 
            // lname_box
            // 
            this.lname_box.Location = new System.Drawing.Point(194, 196);
            this.lname_box.Name = "lname_box";
            this.lname_box.Size = new System.Drawing.Size(528, 38);
            this.lname_box.TabIndex = 14;
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Location = new System.Drawing.Point(24, 202);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(151, 32);
            this.lname_label.TabIndex = 6;
            this.lname_label.Text = "Last Name";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(24, 66);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(42, 32);
            this.id_label.TabIndex = 0;
            this.id_label.Text = "ID";
            // 
            // fname
            // 
            this.fname.Text = "FName";
            this.fname.Width = 180;
            // 
            // lname
            // 
            this.lname.Text = "LName";
            this.lname.Width = 180;
            // 
            // age
            // 
            this.age.Text = "Age";
            this.age.Width = 80;
            // 
            // sex
            // 
            this.sex.Text = "Sex";
            this.sex.Width = 120;
            // 
            // phone
            // 
            this.phone.Text = "Phone";
            this.phone.Width = 180;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 300;
            // 
            // city
            // 
            this.city.Text = "City";
            this.city.Width = 200;
            // 
            // state
            // 
            this.state.Text = "Dtate";
            this.state.Width = 100;
            // 
            // rh
            // 
            this.rh.Text = "Rh";
            this.rh.Width = 100;
            // 
            // liters
            // 
            this.liters.Text = "Liters";
            this.liters.Width = 100;
            // 
            // type
            // 
            this.type.Text = "Type";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2451, 1031);
            this.Controls.Add(this.search_groupbox);
            this.Controls.Add(this.search_listview);
            this.Name = "Search";
            this.Text = "Search";
            this.search_groupbox.ResumeLayout(false);
            this.search_groupbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView search_listview;
        private System.Windows.Forms.GroupBox search_groupbox;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox lname_box;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button return_box;
        private System.Windows.Forms.TextBox blood_type_box;
        private System.Windows.Forms.TextBox state_box;
        private System.Windows.Forms.Label blood_type_label;
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.TextBox city_box;
        private System.Windows.Forms.Label and_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label or_label;
        private System.Windows.Forms.Label or_label_two;
        private System.Windows.Forms.Label or_label_three;
        private System.Windows.Forms.ColumnHeader fname;
        private System.Windows.Forms.ColumnHeader lname;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader rh;
        private System.Windows.Forms.ColumnHeader liters;
        private System.Windows.Forms.ColumnHeader type;
    }
}