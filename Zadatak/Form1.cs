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
            listBox1.Items.Add("The SUM of the numbers is: " + listTotal); 

            int lowestNumber = numberList.Min();      
            listBox1.Items.Add("Lowest number is: " + lowestNumber);       
            int highestNumber = numberList.Max();         
            listBox1.Items.Add("Highest number is: " + highestNumber);

            double averageValue = numberList.Average();listBox1.Items.Add("Average of all values is: " + averageValue); 

            bool doesContain = numberList.Contains(3);listBox1.Items.Add("Contains the number 3: " + doesContain);
            int elementValue = numberList.ElementAt(1); listBox1.Items.Add("The element at array position 1 is: " + elementValue);

            int firstElement = numberList.First(); 
            listBox1.Items.Add("First Array Value = " + firstElement);   
            int lastElement = numberList.Last();     
            listBox1.Items.Add("Last Array Value = " + lastElement);

            listbox:listBox1.Items.Add("==================================");listBox1.Items.Add("ARRAY ITEMS: 1, 1, 2, 2, 3, 4, 5, 5");    
            listBox1.Items.Add("REMOVE DUPLICATES FROM ARRAY"); 
            listBox1.Items.Add("==================================");

             int[] aryNums = new int[8] { 1, 1, 2, 2, 3, 4, 5, 5 };
             var distinctNums = aryNums.Distinct(); 

             foreach (var num in distinctNums)      
                   {    
                      listBox1.Items.Add(num.ToString());        
                                        }
        }

    }
}
