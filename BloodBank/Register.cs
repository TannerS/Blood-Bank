using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS408Project
{
    public partial class Register : Form, Util
    {
        private List<Donors> list;
        
        public Register()
        {
            InitializeComponent();
        }

        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form is Main)
                {
                    form.Show();
                    return;
                }
            }
        }


        private void create_button_Click(object sender, EventArgs e)
        {
            Donors donor = new Donors();

            short age = 3;

            if (Int16.TryParse(age_box.Text.Trim(), out age))
            {
                short amount;

                if (Int16.TryParse(amount_donated_box.Text.Trim(), out amount))
                {
                    donor.FName = fname_box.Text.Trim();
                    donor.LName = lname_box.Text.Trim();
                    donor.ID = id_box.Text.Trim();
                    donor.Age = age;
                    donor.Phone = phone_box.Text.Trim();
                    donor.Address = address_box.Text.Trim();
                    donor.City = city_box.Text.Trim();
                    donor.State = state_box.Text.Trim();
                    donor.BloodAmount = amount;
                    donor.BloodType = blood_type_list.Text;

                    if (male_radio_button.Checked)
                        donor.Sex = "Male";
                    else if (female_radio_button.Checked)
                        donor.Sex = "female";
                    else
                        donor.Sex = "";

                    if (pos_radio_button.Checked)
                        donor.Rh = "Positive";
                    else if (neg_radio_button.Checked)
                        donor.Rh = "Negative";
                    else
                        donor.Rh = "";

                    list.Add(donor);

                }
                else
                {
                    MessageBox.Show("Incorrect Amount");
                    return;
                }
            }
            else
            { 
                MessageBox.Show("Incorrect Age");
                return;
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is Main)
                {
                    passDonors pass_contacts;
                    Main temp = (Main)form;
                    pass_contacts = temp.setDonors;
                    pass_contacts(list);
                    form.Show();
                    Hide();
                    return;
                }
            }
        }

        public void setDonors(List<Donors> donors)
        {
            list = donors;
        }
        private void male_radio_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void neg_pos_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pos_radio_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
