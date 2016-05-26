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
            
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // http://www.dotnetperls.com/dictionary
            string password;
            // http://www.tutorialspoint.com/csharp/csharp_output_parameters.htm
            if (admins.TryGetValue(username_input.Text, out password))
            {
                if (password_input.Text.Equals(password))
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
            this.admins.Add("TannerS", "password");
            this.admins.Add("Admin", "admin");
        }
    }
}
