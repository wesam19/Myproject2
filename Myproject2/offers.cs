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

    public partial class offers : UserControl
    {
        Stack stack = new Stack();

        public offers()
        {
            InitializeComponent();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            using (detalies d = new detalies())
            {

                d.ShowDialog();
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            using (detalies d = new detalies())
            {

                d.ShowDialog();
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            using (detalies d = new detalies())
            {

                d.ShowDialog();
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            using (detalies d = new detalies())
            {

                d.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (buy d = new buy())
            {

                d.ShowDialog();
            }
            stack.Push(112233);
            MessageBox.Show("Product ID Added to Your Stack", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (buy d = new buy())
            {

                d.ShowDialog();
            }
            stack.Push(112233);
            MessageBox.Show("Product ID Added to Your Stack", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (buy d = new buy())
            {

                d.ShowDialog();
            }
            stack.Push(112233);
            MessageBox.Show("Product ID Added to Your Stack", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (buy d = new buy())
            {

                d.ShowDialog();
            }
            stack.Push(112233);
            MessageBox.Show("Product ID Added to Your Stack", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
