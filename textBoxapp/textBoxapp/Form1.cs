using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textBoxapp
{
    public partial class Roxie : Form
    {

    
        public Roxie()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello Party People!");
            string words = txtBox1.Text;
            label1.Text = words;





        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Today is Monday :)");
            string words = txtBox1.Text;
            label2.Text = words;

            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string words = textBox2.Text;
            label3.Text = words;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string four = txtBox4.Text;
            lbl4.Text = four;
        }
    }
}
