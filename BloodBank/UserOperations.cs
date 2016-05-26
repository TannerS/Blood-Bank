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
    public partial class UserOperations : Form, Util
    {
        // list of donors
        private List<Donors> list;
        // list to hold information for each donor
        // on the forms list view
        private ListViewItem list_view;

        public UserOperations()
        {
            InitializeComponent();
        }


        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form is Main)
                {
                    form.Show();
                    return;
                }
            }
        }

        public void setDonors(List<Donors> donors)
        {
            list = donors;
        }


        public void setUpList()
        {
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string sex = (list[i].Sex) ? "Male" : "Female";
                    string Rh = (list[i].Rh) ? "Positive" : "Negative";

                    list_view = new ListViewItem(new[]
                    {
                        list[i].Name.Trim(),
                        list[i].Age.ToString(),
                        list[i].ID.Trim(),
                        sex,
                        list[i].Phone.Trim(),
                        list[i].Address.Trim(),
                        list[i].City.Trim(),
                        list[i].State.Trim(),
                        Rh,
                        list[i].BloodAmount.ToString(),
                        list[i].BloodType.Trim()
                    });

                    donor_listview.Items.Add(list_view);
                }

                
            }

        }




    }
}

