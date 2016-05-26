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


    public partial class Main : Form, Util
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
            //passDonors pass_contacts;
            // declare forms
            reg = new Register();
            search = new Search();
            donors = new UserOperations();
            // set deletgates to work on these methods
            // for each class at same time
            //  pass_contacts = new passDonors(reg.setDonors);
            //pass_contacts = reg.setDonors;
            //pass_contacts += search.setDonors;
            //pass_contacts += donors.setDonors;
            // call and set array lsit for all
            //pass_contacts(list);
        }

        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
          
                Application.Exit();
   
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            passDonors pass_contacts;
            pass_contacts = reg.setDonors;
            pass_contacts(list);
            reg.Show();
            Hide();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            passDonors pass_contacts;
            pass_contacts = search.setDonors;
            pass_contacts(list);
            search.Show();
            Hide();

        }

        private void view_button_Click(object sender, EventArgs e)
        {
            passDonors pass_contacts;
            pass_contacts = donors.setDonors;
            pass_contacts(list);
            donors.Show();
            Hide();
        }

        private void log_out_button_Click(object sender, EventArgs e)
        {
            Hide();

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

            for (int i = 0; i < 5; i++)
            {
                temp = new Donors();
                temp.FName = "First_Name_" + i;
                temp.LName = "Last_Name_" + i;
                temp.Phone = "Phone_" + i;
                temp.Age = (short)(i * 10);
                temp.ID = "ID_" + i;
                temp.BloodAmount = (short)(i * 5 - 23 / 4);
                temp.BloodType = "BloodType_" + (i + 1);
                temp.Rh = "Positive";
                temp.Sex = "Male";
                temp.Address = "Address_" + i;
                temp.City = "City_" + i;
                temp.State = "State_" + i;
                donors.Add(temp);
            }

            temp = new Donors();
            temp.FName = "Chris";
            temp.LName = "Hemsworth";
            temp.Phone = "123456789";
            temp.Age = (short)32;
            temp.ID = "987654321";
            temp.BloodAmount = (short)10;
            temp.BloodType = "O";
            temp.Rh = "Positive";
            temp.Sex = "Male";
            temp.Address = "Fake Street";
            temp.City = "Fake City";
            temp.State = "Fake State";
            donors.Add(temp);

            temp = new Donors();
            temp.FName = "Chris";
            temp.LName = "Evans";
            temp.Phone = "4342424";
            temp.Age = (short)54;
            temp.ID = "954353";
            temp.BloodAmount = (short)30;
            temp.BloodType = "A";
            temp.Rh = "Positive";
            temp.Sex = "Male";
            temp.Address = "Fake Street";
            temp.City = "Fake City";
            temp.State = "Fake State";
            donors.Add(temp);

            temp = new Donors();
            temp.FName = "Chris";
            temp.LName = "Pratt";
            temp.Phone = "0000000";
            temp.Age = (short)54;
            temp.ID = "99999";
            temp.BloodAmount = (short)30;
            temp.BloodType = "A";
            temp.Rh = "Positive";
            temp.Sex = "Male";
            temp.Address = "Fake Street";
            temp.City = "Fake City";
            temp.State = "Fake State";
            donors.Add(temp);

            temp = new Donors();
            temp.FName = "Tanner";
            temp.LName = "Summers";
            temp.Phone = "111111";
            temp.Age = (short)24;
            temp.ID = "2222222";
            temp.BloodAmount = (short)6;
            temp.BloodType = "O";
            temp.Rh = "Positive";
            temp.Sex = "Male";
            temp.Address = "Fake Street";
            temp.City = "Fake City";
            temp.State = "Fake State";
            donors.Add(temp);

            temp = new Donors();
            temp.FName = "Terry";
            temp.LName = "Summers";
            temp.Phone = "3333333";
            temp.Age = (short)54;
            temp.ID = "44444";
            temp.BloodAmount = (short)26;
            temp.BloodType = "A";
            temp.Rh = "Positive";
            temp.Sex = "Male";
            temp.Address = "Fake Street";
            temp.City = "Fake City";
            temp.State = "Fake State";
            donors.Add(temp);

            temp = new Donors();
            temp.FName = "Trisha";
            temp.LName = "Summers";
            temp.Phone = "4444444";
            temp.Age = (short)54;
            temp.ID = "555555";
            temp.BloodAmount = (short)29;
            temp.BloodType = "A";
            temp.Rh = "Positive";
            temp.Sex = "Female";
            temp.Address = "Fake Street";
            temp.City = "Fake City";
            temp.State = "Fake State";
            donors.Add(temp);

        }

        public void setDonors(List<Donors> donors)
        {
            list = donors;
        }
    }
}
