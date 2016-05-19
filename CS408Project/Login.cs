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
    public partial class Login : Form
    {
        private Main main;

        public Login()
        {
            InitializeComponent();

            main = new Main();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // this is the text that was typed in for the username
            string test1 = username_input.Text;
            // this is password
            string test2 = password_input.Text;
            // do something with it
            main.Show();
            // Hide();
            this.Hide();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Close();

            //   if (e.CloseReason == CloseReason.WindowsShutDown)
            // Autosave and clear up ressources
        }
    }
}
