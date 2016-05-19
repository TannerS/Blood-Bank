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
    public partial class Search : Form
    {
        public Search()
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
