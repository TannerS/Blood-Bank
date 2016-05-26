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
        private Dictionary<string, string> admins;


        public Login()
        {
            InitializeComponent();
            admins = new Dictionary<string, string>();
            setAdmins();
            main = new Main();
            admins = new Dictionary<string, string>();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("debug 1");
            // http://www.dotnetperls.com/dictionary
            string password;
            // http://www.tutorialspoint.com/csharp/csharp_output_parameters.htm
            if (admins.TryGetValue(username_input.Text.Trim(), out password))
            {
                MessageBox.Show("Incorrect Login");
                if (password_input.Text.Trim().Equals(password))
                {
                    main.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Incorrect Password");
            }
            else
                MessageBox.Show("Incorrect Username");


        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
    
        }

        private void setAdmins()
        {
            admins.Add("TannerS", "password");
            admins.Add("Admin", "admin");
        }
    }
}
