using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302213089
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.label1.Text == null)
            {
                this.label1.Text = "+";
            } else 
            {
                this.label1.Text = this.label1.Text + "+";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "label1")
            {
                this.label1.Text = this.label1.Text + "0";
            }
            else
            {
                this.label1.Text = "0";
            }
        }
    }
}
