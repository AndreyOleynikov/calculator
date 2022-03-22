using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool plus, minus, div, multi, sqr = false;
        int dot_num = 0;
        private void button_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                return;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (dot_num == 0
                &&
                (textBox1.Text.EndsWith('1')
                || textBox1.Text.EndsWith('2')
                || textBox1.Text.EndsWith('3')
                || textBox1.Text.EndsWith('4')
                || textBox1.Text.EndsWith('5')
                || textBox1.Text.EndsWith('6')
                || textBox1.Text.EndsWith('7')
                || textBox1.Text.EndsWith('8')
                || textBox1.Text.EndsWith('9')
                || textBox1.Text.EndsWith('0')
                )
                )
            {
                textBox1.Text = textBox1.Text + ",";
                dot_num += 1;
            }
            else
            {
                return;
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith('1')
               || textBox1.Text.EndsWith('2')
               || textBox1.Text.EndsWith('3')
               || textBox1.Text.EndsWith('4')
               || textBox1.Text.EndsWith('5')
               || textBox1.Text.EndsWith('6')
               || textBox1.Text.EndsWith('7')
               || textBox1.Text.EndsWith('8')
               || textBox1.Text.EndsWith('9')
               || textBox1.Text.EndsWith('0')
               )
            {
                plus = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                dot_num = 0;
            }
            else
            {
                return;
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith('1')
              || textBox1.Text.EndsWith('2')
              || textBox1.Text.EndsWith('3')
              || textBox1.Text.EndsWith('4')
              || textBox1.Text.EndsWith('5')
              || textBox1.Text.EndsWith('6')
              || textBox1.Text.EndsWith('7')
              || textBox1.Text.EndsWith('8')
              || textBox1.Text.EndsWith('9')
              || textBox1.Text.EndsWith('0')
              )
            {
                minus = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                dot_num = 0;
            }
            else
            {
                return;
            }

        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith('1')
               || textBox1.Text.EndsWith('2')
               || textBox1.Text.EndsWith('3')
               || textBox1.Text.EndsWith('4')
               || textBox1.Text.EndsWith('5')
               || textBox1.Text.EndsWith('6')
               || textBox1.Text.EndsWith('7')
               || textBox1.Text.EndsWith('8')
               || textBox1.Text.EndsWith('9')
               || textBox1.Text.EndsWith('0')
               )
            {
                multi = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                dot_num = 0;
            }
            else
            {
                return;
            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith('1')
               || textBox1.Text.EndsWith('2')
               || textBox1.Text.EndsWith('3')
               || textBox1.Text.EndsWith('4')
               || textBox1.Text.EndsWith('5')
               || textBox1.Text.EndsWith('6')
               || textBox1.Text.EndsWith('7')
               || textBox1.Text.EndsWith('8')
               || textBox1.Text.EndsWith('9')
               || textBox1.Text.EndsWith('0')
               )
            {
                div = true;
                textBox1.Tag = textBox1.Text;
                textBox1.Text = "";
                dot_num = 0;
            }
            else
            {
                return;
            }
        }

        private void button_sqr_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith('1')
               || textBox1.Text.EndsWith('2')
               || textBox1.Text.EndsWith('3')
               || textBox1.Text.EndsWith('4')
               || textBox1.Text.EndsWith('5')
               || textBox1.Text.EndsWith('6')
               || textBox1.Text.EndsWith('7')
               || textBox1.Text.EndsWith('8')
               || textBox1.Text.EndsWith('9')
               || textBox1.Text.EndsWith('0')
               )
            {
                if (textBox1.Text == "")
                {
                    return;
                }
                else
                {
                    sqr = true;
                    textBox1.Tag = textBox1.Text;
                    textBox1.Text = "";
                    dot_num = 0;
                }
            }
            else
            {
                return;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            int cancel = textBox1.Text.Length - 1;
            if (textBox1.Text.Length != 0)
            {
                if (textBox1.Text.EndsWith(','))
                {
                    dot_num = 0;
                }
                textBox1.Text = textBox1.Text.Remove(cancel);
            }
            else
            {
                return;
            }
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dot_num = 0;
        }

        private void button_per_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith('1')
               || textBox1.Text.EndsWith('2')
               || textBox1.Text.EndsWith('3')
               || textBox1.Text.EndsWith('4')
               || textBox1.Text.EndsWith('5')
               || textBox1.Text.EndsWith('6')
               || textBox1.Text.EndsWith('7')
               || textBox1.Text.EndsWith('8')
               || textBox1.Text.EndsWith('9')
               || textBox1.Text.EndsWith('0')
               )
            {
                double x;
                x = Convert.ToDouble(textBox1.Text) / 100;
                textBox1.Text = Convert.ToString(x);
                dot_num = 0;
            }
            else
            {
                return;
            }
        }


        private void button_equal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith('1')
               || textBox1.Text.EndsWith('2')
               || textBox1.Text.EndsWith('3')
               || textBox1.Text.EndsWith('4')
               || textBox1.Text.EndsWith('5')
               || textBox1.Text.EndsWith('6')
               || textBox1.Text.EndsWith('7')
               || textBox1.Text.EndsWith('8')
               || textBox1.Text.EndsWith('9')
               || textBox1.Text.EndsWith('0')
               )
            {
                if (plus)
                {
                    double pl = Convert.ToDouble(textBox1.Tag) + Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(pl);
                    plus = false;
                }
                if (minus)
                {
                    double mn = Convert.ToDouble(textBox1.Tag) - Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(mn);
                    minus = false;
                }
                if (div)
                {
                    double dv = Convert.ToDouble(textBox1.Tag) / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(dv);
                    div = false;
                }
                if (multi)
                {
                    double mt = Convert.ToDouble(textBox1.Tag) * Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(mt);
                    multi = false;
                }
                if (sqr)
                {
                    double sr = Math.Pow(Convert.ToDouble(textBox1.Tag), Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(sr);
                    sqr = false;
                }


            }
            else
            {
                return;
            }
        }

        /* private void button_lbracket_Click(object sender, EventArgs e)
         {
             textBox1.Text = textBox1.Text + "(";
             dot_num = 0;
         }

         private void button_rbracket_Click(object sender, EventArgs e)
         {
             textBox1.Text = textBox1.Text + ")";
             dot_num = 0;
         } */

        private void button_1divx_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith('1')
               || textBox1.Text.EndsWith('2')
               || textBox1.Text.EndsWith('3')
               || textBox1.Text.EndsWith('4')
               || textBox1.Text.EndsWith('5')
               || textBox1.Text.EndsWith('6')
               || textBox1.Text.EndsWith('7')
               || textBox1.Text.EndsWith('8')
               || textBox1.Text.EndsWith('9')
               || textBox1.Text.EndsWith('0')
               )
            {
                if (textBox1.Text == "" || textBox1.Text == "0")
                {
                    return;
                }
                else
                {
                    double x;
                    x = 1 / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(x);
                    dot_num = 0;
                }
            }
            else
            {
                return;
            }
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                double x;
                x = Math.Sqrt(Convert.ToDouble(textBox1.Text));
                textBox1.Text = Convert.ToString(x);
                dot_num = 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((e.KeyChar < 40 || e.KeyChar > 57)
                && symbol != 8 /*BackSpace*/
                && symbol != 27 /*Esc*/
                && symbol != 37 /* % */
                && symbol != 61 /* = */
                && symbol != 94
                )
            {
                e.Handled = true;
            }

        }
    }
}
