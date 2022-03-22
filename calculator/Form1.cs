using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
        }

        Form2 frm2;
        double num, ans;
        int count;
        int dot_num = 0;
        string history = "";

        public void on()
        {
            button_off.Show();
            button_on.Hide();
            textBox1.Enabled = true;
            button_1.Enabled = true;
            button_2.Enabled = true;
            button_3.Enabled = true;
            button_4.Enabled = true;
            button_5.Enabled = true;
            button_6.Enabled = true;
            button_7.Enabled = true;
            button_8.Enabled = true;
            button_9.Enabled = true;
            button_0.Enabled = true;
            button_per.Enabled = true;
            button_dot.Enabled = true;
            button_c.Enabled = true;
            button_div.Enabled = true;
            button_multi.Enabled = true;
            button_cancel.Enabled = true;
            button_minus.Enabled = true;
            button_plus.Enabled = true;
            button_equal.Enabled = true;
            button_sqr.Enabled = true;
            button_1divx.Enabled = true;
            button_sqrt.Enabled = true;
            button_history.Enabled = true;
        }

        public void off()
        {
            textBox1.Clear();
            button_on.Show();
            button_off.Hide();
            textBox1.Enabled = false;
            button_1.Enabled = false;
            button_2.Enabled = false;
            button_3.Enabled = false;
            button_4.Enabled = false;
            button_5.Enabled = false;
            button_6.Enabled = false;
            button_7.Enabled = false;
            button_8.Enabled = false;
            button_9.Enabled = false;
            button_0.Enabled = false;
            button_per.Enabled = false;
            button_dot.Enabled = false;
            button_c.Enabled = false;
            button_div.Enabled = false;
            button_multi.Enabled = false;
            button_cancel.Enabled = false;
            button_minus.Enabled = false;
            button_plus.Enabled = false;
            button_equal.Enabled = false;
            button_sqr.Enabled = false;
            button_1divx.Enabled = false;
            button_sqrt.Enabled = false;
            button_history.Enabled = false;
            dot_num = 0;
        }

        public void press_dot()
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

        public void press_cancel()
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

        public void press_plus()
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
                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
                label1.Text = num.ToString() + '+';
                history += label1.Text; 
                dot_num = 0;
            }
            else
            {
                return;
            }
        }
       
        public void press_minus()
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
                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
                label1.Text = num.ToString() + '-';
                history += label1.Text;
                dot_num = 0;
            }
            else
            {
                return;
            }
        }

        public void press_multi()
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
                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 3;
                label1.Text = num.ToString() + '*';
                history += label1.Text;
                dot_num = 0;
            }
            else
            {
                return;
            }
        }

        public void press_div()
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
                num = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 4;
                label1.Text = num.ToString() + '/';
                history += label1.Text;
                dot_num = 0;
            }
            else
            {
                return;
            }
        }

        public void press_sqr()
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
                    num = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                    count = 5;
                    label1.Text = num.ToString() + '^';
                    history += label1.Text;
                    dot_num = 0;
                }
            }
            else
            {
                return;
            }
        }

        public void press_1divx ()
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
                    num = Double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                    count = 7;
                    label1.Text = " 1/" + num.ToString();
                    history += label1.Text;
                    dot_num = 0;
                    compute();
                }
            }
            else
            {
                return;
            }
        }

        public void press_sqrt()
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
                    num = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                    count = 6;
                    label1.Text = " Sqrt " + num.ToString();
                    history += label1.Text;
                    dot_num = 0;
                    compute();
                }
            }
            else
            {
                return;
            }
        }

        public void press_equal()
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
                compute();
                label1.Text = "";
            }
            else
            {
                return;
            }
        }

        private void button_on_Click(object sender, EventArgs e)
        {
            on();
        }

        private void button_off_Click(object sender, EventArgs e)
        {
            off();
        }

        private void button_history_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            
        }
        private void Logs()
        {
            DateTime dateTime = DateTime.Now;
            using (StreamWriter w = new StreamWriter("history.txt", true))
            {
                w.WriteLine(Convert.ToString(dateTime));
                w.WriteLine(history);
                w.WriteLine();

            }
        }
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
            press_dot();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            press_cancel();
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            history = "";
            dot_num = 0;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            press_plus();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            press_minus();
        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            press_multi();
        }
        
        private void button_div_Click(object sender, EventArgs e)
        {
            press_div();
        }

        private void button_1divx_Click(object sender, EventArgs e)
        {
            press_1divx();
        }

        private void button_sqr_Click(object sender, EventArgs e)
        {
            press_sqr();
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            press_sqrt();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            press_equal();
            Logs();
            history = "";

        }

        public void compute()
        { 
            switch(count)
            { 
                case 1:
                    ans = num + double.Parse(textBox1.Text);
                    history += textBox1.Text;
                    textBox1.Text = ans.ToString();
                    history = history + "=" + textBox1.Text;
                    break;

                case 2:
                    ans = num - double.Parse(textBox1.Text);
                    history += textBox1.Text;
                    textBox1.Text = ans.ToString();
                    history = history + "=" + textBox1.Text;
                    break;

                case 3:
                    ans = num * double.Parse(textBox1.Text);
                    history += textBox1.Text;
                    textBox1.Text = ans.ToString();
                    history = history + "=" + textBox1.Text;
                    break;

                case 4:
                    ans = num / double.Parse(textBox1.Text);
                    history += textBox1.Text;
                    textBox1.Text = ans.ToString();
                    history = history + "=" + textBox1.Text;
                    break;

                case 5:
                    ans = Math.Pow(num, double.Parse(textBox1.Text));
                    history += textBox1.Text;
                    textBox1.Text = ans.ToString();
                    history = history + "=" + textBox1.Text;
                    break;

                case 6:
                  
                    textBox1.Text = Math.Sqrt(num).ToString();
                    history = history + "=" + textBox1.Text;
                    break;

                case 7:

                    double x;
                    x = 1 / num;
                    textBox1.Text = x.ToString();
                    history = history + "=" + textBox1.Text;
                    break;

                default:
                    break;

                
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
            if ((e.KeyChar < 42 || e.KeyChar > 57)
                && symbol != 8 /*BackSpace*/
                && symbol != 27 /*Esc*/
                && symbol != 37 /* % */
                && symbol != 61 /* = */
                && symbol != 94 /* ^ */
                && symbol != 13 /* Enter */)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 46 || e.KeyChar == 44)
            {
                press_dot();
                e.Handled = true;
                textBox1.Select(textBox1.Text.Length, 0);
            }
            if (e.KeyChar == 8)
            {
                press_cancel();
                e.Handled = true;
                textBox1.Select(textBox1.Text.Length, 0);
            }
            if (e.KeyChar == 43)
            {
                press_plus();
                e.Handled = true;
                textBox1.Select(textBox1.Text.Length, 0);
            }
            if (e.KeyChar == 45)
            {
                press_minus();
                e.Handled = true;
                textBox1.Select(textBox1.Text.Length, 0);
            }
            if (e.KeyChar == 42)
            {
                press_multi();
                e.Handled = true;
                textBox1.Select(textBox1.Text.Length, 0);
            }
            if (e.KeyChar == 47)
            {
                press_div();
                e.Handled = true;
                textBox1.Select(textBox1.Text.Length, 0);
            }
            if (e.KeyChar == 61 || e.KeyChar == 13)
            {
                press_equal();
                e.Handled = true;
                textBox1.Select(textBox1.Text.Length, 0);
            }
            if (e.KeyChar == 94)
            {
                press_sqr();
                e.Handled = true;
                textBox1.Select(textBox1.Text.Length, 0);
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        
        }


        private void kd_del(object sender, KeyEventArgs e)
        {
          
        }

     }
}
