using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numberList = new int[5] { 1, 2, 3, 4, 5 };
            listBox1.Items.Add("ARRAY ITEMS: 1, 2, 3, 4, 5"); 
            listBox1.Items.Add("========================");
            int listTotal = numberList.Sum();

            int lowestNumber = numberList.Min();      
            listBox1.Items.Add("Lowest number is: " + lowestNumber);       
            int highestNumber = numberList.Max();         
            listBox1.Items.Add("Highest number is: " + highestNumber);
        }
    }
}
