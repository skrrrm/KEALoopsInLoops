using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEALoopsInLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Øvelse 1
        private void button1_Click(object sender, EventArgs e)
        {
            // clearing text box
            richTextBoxResult.Clear();
            richTextBoxResult.Visible = true;
            listBoxResult.Visible = false;

            // Variables
            string newline = "\r\n";
            string star = "*";  // String.Concat(Enumerable.Repeat("*", 30)); used for a solution with only one loop
            string everything = "";


            for (int i = 1; i <= 10; i++)
            {
                everything = everything + newline;

                for (int n = 1; n <= 30; n++)
                    everything = everything + star;
            }
            richTextBoxResult.Text = everything.Trim(); // Trimming space off in front and end of the string
        }

        // Øvelse 2
        private void button2_Click(object sender, EventArgs e)
        {
            // clearing text box
            richTextBoxResult.Clear();
            richTextBoxResult.Visible = false;
            listBoxResult.Visible = true;

            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        listBoxResult.Items.Add($"{a}{b}{c}");
                    }
                }
            }

        }
    }
}
