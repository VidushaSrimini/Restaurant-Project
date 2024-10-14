using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true) 
            {
                textBox1.Enabled = true;

            }
            if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;

            }
            if (checkBox2.Checked == false)
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;

            }
            if (checkBox3.Checked == false)
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;

            }
            if (checkBox4.Checked == false)
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;

            }
            if (checkBox5.Checked == false)
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;

            }
            if (checkBox6.Checked == false)
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;

            }
            if (checkBox7.Checked == false)
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Enabled = true;

            }
            if (checkBox8.Checked == false)
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";

            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox9.Enabled = true;

            }
            if (checkBox9.Checked == false)
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";

            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox10.Enabled = true;

            }
            if (checkBox10.Checked == false)
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";

            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox11.Enabled = true;

            }
            if (checkBox11.Checked == false)
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";

            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox12.Enabled = true;

            }
            if (checkBox12.Checked == false)
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //unit prices of different meals and drinks
        double friesup = 50, burgerup = 80, saladup = 100, sandwitchup = 75, chickenup=100, cheeseup = 80;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text + " Subtotal " + label21.Text + " Tax: " + label21.Text + " Grand Total " + label22.Text,new Font("Century Gothic",12,FontStyle.Regular),Brushes.Blue,new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;

        }

        double waterup = 15, teaup = 15, colaup = 20, chocolateup = 25, pancakeup = 30, orangeup = 25;

        double friestp, burgertp, saladtp, sandwitchtp, chickentp, cheesetp, watertp, teatp, colatp, chocolatetp, pancaketp, orangetp;
        double SubTotal = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(textBox1.Text);
            burgertp = burgerup * Convert.ToDouble(textBox2.Text);
            saladtp = saladup * Convert.ToDouble(textBox3.Text);
            sandwitchtp = sandwitchup * Convert.ToDouble(textBox4.Text);
            chickentp = chickenup * Convert.ToDouble(textBox5.Text);
            cheesetp = cheeseup * Convert.ToDouble(textBox6.Text);
            orangetp = orangeup * Convert.ToDouble(textBox7.Text);
            pancaketp = pancakeup * Convert.ToDouble(textBox8.Text);
            chocolatetp = chocolateup * Convert.ToDouble(textBox9.Text);
            watertp = waterup * Convert.ToDouble(textBox10.Text);
            colatp = colaup * Convert.ToDouble(textBox11.Text);
            teatp = teaup * Convert.ToDouble(textBox12.Text);

            richTextBox1.Clear();
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("\t\tCODESPACE REATAURENT" +Environment.NewLine);
            richTextBox1.AppendText("\t\t********************************\t\t" +Environment.NewLine);
            if(checkBox1.Checked == true)
            {
                richTextBox1.AppendText("\tFries:\t" +friestp+" Rs"+Environment.NewLine);
                SubTotal = SubTotal + friestp;
                label21.Text = "" + SubTotal;
            }
            if (checkBox2.Checked == true)
            {
                richTextBox1.AppendText("\tBurger:\t" + burgertp + " Rs" + Environment.NewLine);
                SubTotal = SubTotal + burgertp;
                label21.Text = "" + SubTotal;
            }
            if (checkBox3.Checked == true)
            {
                richTextBox1.AppendText("\tSalad:\t" + saladtp + " Rs" + Environment.NewLine);
                SubTotal = SubTotal + saladtp;
                label21.Text = "" + SubTotal;
            }
            if (checkBox4.Checked == true)
            {
                richTextBox1.AppendText("\tSandwitch:\t" + sandwitchtp + " Rs" + Environment.NewLine);
                SubTotal = SubTotal + sandwitchtp;
                label21.Text = "" + SubTotal;
            }
            if (checkBox5.Checked == true)
            {
                richTextBox1.AppendText("\tChicken:\t" + chickentp + "  Rs" + Environment.NewLine);
                SubTotal = SubTotal + chickentp;
                label21.Text = "" + SubTotal;
            }
            if (checkBox6.Checked == true)
            {
                richTextBox1.AppendText("\tCheese:\t" + cheesetp + "  Rs" + Environment.NewLine);
                SubTotal = SubTotal + cheesetp;
                label21.Text = "" + SubTotal;
            }
            if (checkBox7.Checked == true)
            {
                richTextBox1.AppendText("\tOrange:\t" + orangetp + " Rs" + Environment.NewLine);
                SubTotal = SubTotal + orangetp;
                label21.Text = "" + SubTotal;
            }
            if (checkBox8.Checked == true)
            {
                richTextBox1.AppendText("\tPancakes:\t" + pancaketp + "  Rs" + Environment.NewLine);
                SubTotal = SubTotal + pancaketp;
                label21.Text = "" + SubTotal;
            }
            if (checkBox9.Checked == true)
            {
                richTextBox1.AppendText("\tChocolate:\t" + chocolatetp + " Rs" + Environment.NewLine);
                SubTotal = SubTotal + chocolatetp;
                label21.Text = "" + SubTotal;
            }
            if (checkBox10.Checked == true)
            {
                richTextBox1.AppendText("\tWater:\t" + watertp + " Rs" + Environment.NewLine);
                SubTotal = SubTotal + watertp;
                label21.Text = "" + SubTotal;
            }
            if (checkBox11.Checked == true)
            {
                richTextBox1.AppendText("\tCola:\t" + colatp + " Rs" + Environment.NewLine);
                SubTotal = SubTotal + colatp;
                label21.Text = "" + SubTotal;
            }
            if (checkBox12.Checked == true)
            {
                richTextBox1.AppendText("\tTea:\t" + teatp + " Rs" + Environment.NewLine);
                SubTotal = SubTotal + teatp;
                label21.Text = "" + SubTotal;
            }
            double tax = SubTotal * 0.16;
            double grdTotal = SubTotal + tax;
            label22.Text = "Rs " + tax;
            label23.Text = "Rs " + grdTotal;


        }



    }
}
