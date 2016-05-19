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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        /*
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Close();

             //   if (e.CloseReason == CloseReason.WindowsShutDown)
        // Autosave and clear up ressources
        }

    */


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

    }
}
