using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nodes
{
    public partial class Form1 : Form
    {
        int Node1;
        int Node2;
        int Node3;
        int Node4;  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNode1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string stringNode1 = textBox1.Text;
            string stringNode2 = textBox2.Text;
            string stringNode3 = textBox3.Text;
            string stringNode4 = textBox4.Text;
            Visual visual = new Visual();
            
            try
            {
                Node1 = Convert.ToInt32(stringNode1);
                Node2 = Convert.ToInt32(stringNode2);
                Node3 = Convert.ToInt32(stringNode3);
                Node4 = Convert.ToInt32(stringNode4);
                /*
               [node1]->[node2]->[node3]->[node4] -> NULL
               []       []       []       [] 
                */
                MyList list = new MyList();
                //list.AddToEnd(Node1);
                //list.AddToEnd(Node2);
                //list.AddToEnd(Node3);
                //list.AddToEnd(Node4);
                //list.AddToBeginning(7);
                //list.AddToBeginning(5);
                //list.AddToBeginning(9);
                //list.AddToBeginning(11);
                list.AddSorted(Node1);
                list.AddSorted(Node2);
                list.AddSorted(Node3);
                list.AddSorted(Node4);
                list.Print();
                visual.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input, Enter only integers","Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
            }

        }
    }
    public class MyList 
    {
        public Node headNode;
        public MyList() 
        {
            headNode = null;
        }

        public void AddToEnd(int data) 
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else 
            {
                headNode.AddToEnd(data);
            }
        }
        public void AddToBeginning(int data) 
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else 
            {
                Node temp = new Node(data); // Create a temp node to store the data
                temp.next = headNode;
                headNode = temp;
            }
        }
        public void AddSorted(int data) 
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToBeginning(data);
            }
            else 
            {
                headNode.AddSorted(data);
            }
        }

        public void Print() 
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }
    }
    public class Node 
    {
        public int data;
        public Node next;
        public Node(int i) 
        {
            data = i;
            next = null;
        }
        public void Print() 
        {
            Console.Write("|" + data + "|->"); // Prints the first node
            if (next != null) // Recursion used here to print next nodes
            {
                next.Print();
            }
            else 
            {
                Console.WriteLine("NULL");
            }
        }
        public void AddToEnd(int data) 
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else 
            {
                next.AddToEnd(data); // Recursion here once again
            }
        }
        public void AddSorted(int data) 
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else 
            {
                next.AddSorted(data);  
            }
        }
    }
    
}
