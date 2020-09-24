using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teclado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        string a;
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            String[] letras = { "2", "a", "b", "c" };
            count++;
            for (int i = 0; i <=letras.Length; i++)
            {
                textBox1.Text =  letras[count-1];
                a = textBox1.Text;
            }
            if (count == letras.Length)
                count = 0;
            else
            {
                textBox1.Text = letras[count].ToString();
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String[] letras = { "3", "d", "e", "f" };
            count++;
            for (int i = 0; i <= 4; i++)
            {
                textBox1.Text = letras[count - 1];
            }
            if (count == 4)
                count = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String[] letras = { "4", "g", "h", "i" };
            count++;
            for (int i = 0; i <= 4; i++)
            {
                textBox1.Text = letras[count - 1];
            }
            if (count == 4)
                count = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String[] letras = { "5", "j", "k", "l" };
            count++;
            for (int i = 0; i <= 4; i++)
            {
                textBox1.Text = letras[count - 1];
            }
            if (count == 4)
                count = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String[] letras = { "6", "m", "n", "o" };
            count++;
            for (int i = 0; i <= 4; i++)
            {
                textBox1.Text = letras[count - 1];
            }
            if (count == 4)
                count = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String[] letras = { "7", "p", "q", "r","s" };
            count++;
            for (int i = 0; i <=5 ; i++)
            {
                textBox1.Text = letras[count - 1];
            }
            if (count == 5)
                count = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String[] letras = { "8", "t", "u", "v" };
            count++;
            for (int i = 0; i <= 4; i++)
            {
                textBox1.Text = letras[count - 1];
            }
            if (count == 4)
                count = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String[] letras = { "9", "w", "x", "y","z"};
            count++;
            for (int i = 0; i <= 5; i++)
            {
                textBox1.Text = letras[count - 1];
            }
            if (count == 5)
                count = 0;
        }
    }
}
