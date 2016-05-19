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
    public partial class Main : Form
    {
        Register reg;
        Search search;
        UserOperations donors;

        public Main()
        {
            InitializeComponent();
            reg = new Register();
            search = new Search();
            donors = new UserOperations();
        }


        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if (e.CloseReason == CloseReason.UserClosing)
            //  Close();


            this.FormClosing += new FormClosingEventHandler(test_closeForm);
        }

        private void test_closeForm(Object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


        // this.cl

        //   if (e.CloseReason == CloseReason.WindowsShutDown)
        // Autosave and clear up ressources
    

        private void register_button_Click(object sender, EventArgs e)
        {
            //reg.Parent = this;
            //reg.ShowDialog(this);
           // this.Close();


            reg.Show();
             Hide();
            //this.Hide();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            search.Show();
            // Hide();
            this.Hide();
        }

        private void view_button_Click(object sender, EventArgs e)
        {



            donors.Show();
            // Hide();
            this.Hide();
        }
    }
}
