using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collins_FibonacciSeries
{
    public partial class Form1 : Form
    {
        int i, n;

        private void button1_Click(object sender, EventArgs e)  // reset button
        {
            i = 0;  //resets value i for for/if loops
            n = 0;  // resets value n for array
            Answer_textbox.Text = null;  // clears results
            NumberN_textbox.Text = null;  // sets input to 0
            Answer_textbox.Visible = false;  // makes answer label disappear
            Answer_label.Visible = false;  //makes answer box disappear
            button1.Visible = false;  // makes reset button disappear
            Calculate_button.Enabled = true;  // makes calculate button usable again
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            Answer_textbox.Visible = true;
            Answer_label.Visible = true;
            Calculate_button.Enabled = false;
            button1.Visible = true;
            n = Convert.ToInt32(NumberN_textbox.Text);
            int[] fibArr = new int[n]; // array for fib sequence 

            for (i = 0; i < n; ++i)
            {
                if (i == 0)
                {
                    fibArr[0] = 0; // establishing first digits 
                }
                else if (i == 1)
                {
                    fibArr[1] = 1; // establishing digit at index 2
                }
                else
                {
                    fibArr[i] = fibArr[i - 1] + fibArr[i - 2]; // filling the rest of the fib sequence
                }
            }
            string output = " "; // output string 
            string temp;         // string for int to string conversion
            int j = 0;           // offeset index for the comma insertion
            int length;          // intger for establishing the length of each number in sequence
            
            for(i = 0; i < n; i++) // for loop to create the ouput string
            {   
                temp = Convert.ToString(fibArr[i]);   // defining the conversion variable
                length = temp.Length;                 
                output = output.Insert(j, temp);
                output = output.Insert(j + length, ", ");
                j = j + length + 1;                   // offset variable is reset to 1 plus the size of the most recent value in the sequence
            }         
            Answer_textbox.Text = output;         // output  
        }
            public Form1()
        {
            InitializeComponent();
        }

        private void NumberN_textbox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
