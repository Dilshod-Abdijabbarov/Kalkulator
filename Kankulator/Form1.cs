using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kankulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = "1";
            textBox1.Text += btn1.Text;
        }

        private void btnqush_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = "2";
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btnayir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void btnnol_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void btnkopayt_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void btnteng_Click(object sender, EventArgs e)
        {
            hisobla();
        }

        private void btnqush_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }
        void hisobla()
        {
            string matn = textBox1.Text;
            string yangijavob = "";

            //bo'lish
            int k = 0;
            for (int i = 0; i < matn.Length; i++)
            {
                if (matn[i] == '/')
                {
                    k++;
                }
            }
            while (k > 0)
            {
                string[] ajrat = matn.Split('+', '-', '*', '/');
                string[] soz = new string[2 * ajrat.Length - 1];
                int x = 0;
                int y = 0;
                for (int i = 0; i < matn.Length; i++)
                {
                    if (matn[i] == '+')
                    {
                        soz[x] += ajrat[y];
                        y++; x++;
                        soz[x] = "+";
                        x++;
                    }
                    if (matn[i] == '-')
                    {
                        soz[x] = ajrat[y];
                        y++; x++;
                        soz[x] = "-";
                        x++;
                    }
                    if (matn[i] == '*')
                    {
                        soz[x] = ajrat[y];
                        y++; x++;
                        soz[x] = "*";
                        x++;
                    }
                    if (matn[i] == '/')
                    {
                        soz[x] = ajrat[y];
                        y++; x++;
                        soz[x] = "/";
                        x++;
                    }
                }
                soz[x] = ajrat[y];

                //bo'linmani hisoblaydi
                double bolinma;
                int s1 = 0;
                string[] javob = new string[soz.Length];
                string soni = "";
                for (int i = 0; i < soz.Length; i++)
                {
                    if (soz[i] == "/")
                    {
                        soni += i + " ";
                        bolinma = double.Parse(soz[i - 1].ToString()) / double.Parse(soz[i + 1].ToString());
                        javob[s1] = bolinma.ToString(); s1++;
                    }
                }
                int l = 0;
                s1 = 0;
                string[] soniajrat = soni.Split(' ');
                {
                    for (int i = 0; i < soz.Length; i++)
                    {
                        if (int.Parse(soniajrat[l]) - 1 == i)
                        {
                            yangijavob += javob[s1]; s1++; i += 2;
                        }
                        else
                        {
                            yangijavob += soz[i];
                        }
                    }
                }
                k--;
                matn = yangijavob;
                yangijavob = "";
            }

            //kopaytma
            k = 0;
            for (int i = 0; i < matn.Length; i++)
            {
                if (matn[i] == '*')
                {
                    k++;
                }
            }
            while (k > 0)
            {
                string[] ajrat = matn.Split('+', '-', '*', '/');
                string[] soz = new string[2 * ajrat.Length - 1];
                int x = 0;
                int y = 0;
                for (int i = 0; i < matn.Length; i++)
                {
                    if (matn[i] == '+')
                    {
                        soz[x] += ajrat[y];
                        y++; x++;
                        soz[x] = "+";
                        x++;
                    }
                    if (matn[i] == '-')
                    {
                        soz[x] = ajrat[y];
                        y++; x++;
                        soz[x] = "-";
                        x++;
                    }
                    if (matn[i] == '*')
                    {
                        soz[x] = ajrat[y];
                        y++; x++;
                        soz[x] = "*";
                        x++;
                    }
                    if (matn[i] == '/')
                    {
                        soz[x] = ajrat[y];
                        y++; x++;
                        soz[x] = "/";
                        x++;
                    }
                }
                soz[x] = ajrat[y];

                //kopaytmani hisoblash
                double kopaytma;
                int s1 = 0;
                string[] javob = new string[soz.Length];
                string soni = "";
                for (int i = 0; i < soz.Length; i++)
                {
                    if (soz[i] == "*")
                    {
                        soni += i + " ";
                        kopaytma = double.Parse(soz[i - 1].ToString()) * double.Parse(soz[i + 1].ToString());
                        javob[s1] = kopaytma.ToString(); s1++;
                    }
                }
                int l = 0;
                s1 = 0;
                string[] soniajrat = soni.Split(' ');
                {
                    for (int i = 0; i < soz.Length; i++)
                    {
                        if (int.Parse(soniajrat[l]) - 1 == i)
                        {
                            yangijavob += javob[s1]; s1++; i += 2;
                        }
                        else
                        {
                            yangijavob += soz[i];
                        }
                    }
                }
                k--;
                matn = yangijavob;
                yangijavob = "";
            }
           
            // Qoshish va Ayirish
            {
                string[] ajrat = matn.Split('+', '-');
                string[] soz = new string[matn.Length];
                int x = 0;
                int y = 1,t=0;
                if (matn[0] != '-')
                {
                    for (int i = 0; i < matn.Length; i++)
                    {
                        if (matn[i] == '+')
                        {
                            soz[x] = ajrat[t];
                            t++; x++;
                            soz[x] = "+";
                            x++;
                        }         
                        if (matn[i] == '-')
                        {
                            soz[x] = ajrat[t];
                            t++; x++;
                            soz[x] = "-";
                            x++;
                        }
                    }
                    soz[x] = ajrat[t];
                }
                else
                {
                    for (int i = 0; i < matn.Length; i++)
                    {                      
                        if (matn[i] == '-')
                        {
                            soz[x] = "-";
                            x++;
                            soz[x] = ajrat[y];
                            y++; x++;
                        }
                        if (matn[i] == '+')
                        {
                            soz[x] = "+";
                            x++;
                            soz[x] = ajrat[y];
                            y++; x++;
                        }
                    }
                }
                int m = 0;
                double[] mat = new double[soz.Length / 2 + 1];
                if (soz[0] == "-")
                    for (int i = 0; i < soz.Length ; i += 2)
                    {
                        if (soz[i] == "-")
                        {
                            mat[m] = double.Parse(soz[i + 1].ToString()) * (-1);
                        }
                        else
                        if(soz[i] == "+")
                        {
                            mat[m] = double.Parse(soz[i + 1].ToString()) * 1;
                        }
                        m++;
                    }               
                 else
                 {
                     for (int i = 0; i < soz.Length; i += 2)
                     {
                         if (i == 2)
                         {
                             i = i - 1;
                         }
                         if (i == 0)
                         {
                             mat[m] = double.Parse(soz[0].ToString());
                             m++;
                         }
                         else
                         {
                             if (soz[i] =="-")
                             {
                                 mat[m] = double.Parse(soz[i + 1].ToString()) * (-1);
                             }
                             else
                             if(soz[i] == "+")
                             {
                                 mat[m] = double.Parse(soz[i + 1].ToString()) * 1;
                             }
                             m++;
                         }
                     }
                }              
                 double yigindi = 0;
                 for (int i = 0; i < mat.Length; i++)
                 {
                     yigindi += mat[i];
                 }
                 textBox1.Text = yigindi.ToString();
            }       
        }
        private void btnnuqta_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " " + Math.Sqrt((double.Parse(textBox1.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" + Math.Pow(double .Parse(textBox1.Text), 2);
        }
    }
}
