using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myproject2
{
    public partial class aboutus : UserControl
    {
        public aboutus()
        {
            InitializeComponent();
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://m.facebook.com/login/?locale2=ar_AR");
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/accounts/login/");

        }

        private void gmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/login?lang=ar");

        }

        private void whatsapp_Click(object sender, EventArgs e)
        {
            using (phone ph = new phone())
            {

                ph.ShowDialog();
            }
        }
    }
}
