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
    delegate void passDonors(List<Donors> donors);

    public partial class Main : Form
    {
        private Register reg;
        private Search search;
        private UserOperations donors;
        private List<Donors> list;

        public Main()
        {
            InitializeComponent();
            list = new List<Donors>();
            setTestContacts(ref list);

  

            // declare delegate
            passDonors pass_contacts;
            // declare forms
            reg = new Register();
            search = new Search();
            donors = new UserOperations();


            // set deletgates to work on these methods
            // for each class at same time
            //  pass_contacts = new passDonors(reg.setDonors);


            pass_contacts = reg.setDonors;
            pass_contacts += search.setDonors;
            pass_contacts += donors.setDonors;
            // call and set array lsit for all
           
           

            pass_contacts(list);

            donors.setUpList();

        }

        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
          
                Application.Exit();
   
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            reg.Show();
            Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            search.Show();
            this.Close();
           
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            donors.Show();
            this.Close();
           
        }

        private void log_out_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form is Login)
                {
                    form.Show();
                    return;
                }
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setTestContacts(ref List<Donors> donors)
        {
            Donors temp;

            for (int i = 0; i < 3; i++)
            {
                //System.Windows.Forms.MessageBox.Show("FULLING ARRAY");

                temp = new Donors();
                temp.Name = "Name_" + i;
                temp.Phone = "Phone_" + i;
                temp.Age = (short)(i * 10);
                temp.ID = "ID_" + i;
                temp.BloodAmount = (short)(i * 5 - 23 / 4);
                temp.BloodType = "BloodType_" + (i + 1);
                temp.Rh = true;
                temp.Sex = false;
                temp.Address = "Address_" + i;
                temp.City = "City_" + i;
                temp.State = "State_" + i;
                donors.Add(temp);
            }

        }
    }
}
