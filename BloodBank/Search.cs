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
    public partial class Search : Form, Util
    {
        private List<Donors> list;

        public Search()
        {
            InitializeComponent();
        }

        public void setDonors(List<Donors> donors)
        {
            list = donors;
        }

        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void return_box_Click(object sender, EventArgs e)
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

        private void search_button_Click(object sender, EventArgs e)
        {

            if (id_box.Text.Trim() != string.Empty)
            {
                MessageBox.Show("DEBUG");
                setResults(searchComboOne(id_box.Text.Trim()));
            }
            else if ((lname_box.Text.Trim() != string.Empty) && (city_box.Text.Trim() != string.Empty))
            {
                MessageBox.Show("DEBUG111");
                setResults(searchComboTwo(lname_box.Text.Trim(), city_box.Text.Trim()));
            }
            else if ((lname_box.Text.Trim() != string.Empty) && (state_box.Text.Trim() != string.Empty))
            {
                MessageBox.Show("DEBUG222");
                setResults(searchComboThree(lname_box.Text.Trim(), state_box.Text.Trim()));
            }
            else if ((lname_box.Text.Trim() != string.Empty) && (blood_type_box.Text.Trim() != string.Empty))
            {
                MessageBox.Show("DEBUG333");
                setResults(searchComboThree(lname_box.Text.Trim(), blood_type_box.Text.Trim()));
            }
            else
            {
                MessageBox.Show("Information not properly inserted");
                return;
            }


            


        }

        private IEnumerable<Donors> searchComboOne(string ID)
        {
            return list.Where(test => test.ID.Equals(ID));
        }

        private IEnumerable<Donors> searchComboTwo(string lname, string city)
        {
            return list.Where(test => test.LName.Equals(lname) && test.City.Equals(city));
        }

        private IEnumerable<Donors> searchComboThree(string lname, string state)
        {
            return list.Where(test => test.LName.Equals(lname) && test.City.Equals(state));
        }

        private IEnumerable<Donors> searchComboFour(string lname, string type)
        {
            return list.Where(test => test.LName.Equals(lname) && test.City.Equals(type));
        }

        private void setResults(IEnumerable<Donors> temp)
        {
            if (search_listview != null)
                search_listview.Items.Clear();
            ListViewItem list_view;

            foreach (Donors d in temp)
            {
                list_view = new ListViewItem(new[]
                {
                    d.FName,
                    d.LName,
                    d.Age.ToString(),
                    d.ID,
                    d.Sex,
                    d.Phone,
                    d.Address,
                    d.City,
                    d.State,
                    d.Rh,
                    d.BloodAmount.ToString(),
                    d.BloodType
                });

                search_listview.Items.Add(list_view);
            }
        }

    }



}
