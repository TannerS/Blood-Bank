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

        private void create_button_Click(object sender, EventArgs e)
        {

        }

        public void setDonors(List<Donors> donors)
        {
            list = donors;
        }
    }
}
