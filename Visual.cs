using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nodes;

namespace nodes
{
    public partial class Visual : Form
    {
        public Visual()
        {
            InitializeComponent();
            textBoxUnsortedEndNode1.Text = Convert.ToString(Form1.Node1);
            textBoxUnsortedEndNode2.Text = Convert.ToString(Form1.Node2);
            textBoxUnsortedEndNode3.Text = Convert.ToString(Form1.Node3);
            textBoxUnsortedEndNode4.Text = Convert.ToString(Form1.Node4);
            textBoxUnsortedStartNode1.Text = Convert.ToString(Form1.Node4);
            textBoxUnsortedStartNode2.Text = Convert.ToString(Form1.Node3);
            textBoxUnsortedStartNode3.Text = Convert.ToString(Form1.Node2);
            textBoxUnsortedStartNode4.Text = Convert.ToString(Form1.Node1);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUnsortedNode1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxUnsortedNode2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUnsortedNode3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUnsortedNode4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
