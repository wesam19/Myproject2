﻿using System;
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
    public partial class products : UserControl
    {
        Stack stack = new Stack();
        public products()
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            using (detalies d = new detalies())
            {

                d.ShowDialog();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            using (detalies d = new detalies())
            {

                d.ShowDialog();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
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

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            using (detalies d = new detalies())
            {

                d.ShowDialog();
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            using (buy d = new buy())
            {

                d.ShowDialog();
            }
            stack.Push(112233);
            MessageBox.Show("Product ID Added to Your Stack", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            using (buy d = new buy())
            {

                d.ShowDialog();
            }
            stack.Push(112233);
            MessageBox.Show("Product ID Added to Your Stack", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
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
