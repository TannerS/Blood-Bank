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
            linqSearch(name_box.Text.Trim(),
                id_box.Text.Trim(), 
                city_box.Text.Trim(), 
                state_box.Text.Trim(), 
                blood_type_box.Text.Trim() );
        }

        private void linqSearch(string name, string ID, string city, string state, string type)
        {

            


        }
        private void search(string data1)
        {

        }




        private void search(string data1)
        {

        }

        private void search(string data1, string data2)
        {

        }

        private void search(string data1, string data2, string data3)
        {

        }

        private void search(string data1, string data2, string data3, string data4)
        {

        }

        private void search(string data1, string data2, string data3, string data4, string data5)
        {

        }


    }



}
