using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanielHurrDurr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "WAIT CLICK HERE!!!";
            button1.Size = new Size(520, 20);
            label1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Daniel smells";
            label1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
