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
    public partial class UserOperations : Form
    {
        // this class has a list view which you can populate, it updates dynamically, if you call 
        // the right method, and can refresh with new lsit aka one returned from the linq


        public UserOperations()
        {
            InitializeComponent();
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
