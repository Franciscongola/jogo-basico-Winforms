using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int n01 = 0;
        int n02 = 0;
        int pontos = 0;
        public Form1()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        
        List<string> p = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                switch (lb_operador.Text)
                {
                    case "+":
                        int somar = int.Parse(valor01.Text) + int.Parse(valor02.Text);
                        if (int.Parse(textBox1.Text) == somar)
                        {
                            lb_pontos.Text = Convert.ToString(pontos += 1);
                            lb_pontos.ForeColor = Color.Green;
                            if (int.Parse(lb_pontos.Text) == 50)
                            {
                                MessageBox.Show("Continue assim", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                           
                        }
                        else
                        {
                            lb_pontos.Text = Convert.ToString(pontos = pontos - 2);
                            MessageBox.Show("O seu Placar está descer", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (int.Parse(lb_pontos.Text) <= 0)
                            {
                                lb_pontos.ForeColor = Color.Red;
                                MessageBox.Show("O seu Placar é menor igual a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        break;
                    //___________________________________________________________________________________________
                    //_________________Subtrair___________________________________________
                    case "-":
                        int subtarir = int.Parse(valor01.Text) - int.Parse(valor02.Text);
                        if (int.Parse(textBox1.Text) == subtarir)
                        {
                            lb_pontos.Text = Convert.ToString(pontos += 1);
                            lb_pontos.ForeColor = Color.Green;
                            if (int.Parse(lb_pontos.Text) == 50)
                            {
                                MessageBox.Show("Continue assim", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                           
                        }
                        else
                        {
                            lb_pontos.Text = Convert.ToString(pontos = pontos - 2);
                            MessageBox.Show("O seu Placar está descer", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (int.Parse(lb_pontos.Text) <= 0)
                            {
                                lb_pontos.ForeColor = Color.Red;
                                MessageBox.Show("O seu Placar é menor igual a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        break;
                    //___________________________________________________________________________________________
                    //_________________Dividir___________________________________________
                    case "/":
                        int dividir = int.Parse(valor01.Text) / int.Parse(valor02.Text);
                        if (int.Parse(textBox1.Text) == dividir)
                        {
                            lb_pontos.Text = Convert.ToString(pontos += 1);
                            lb_pontos.ForeColor = Color.Green;
                            if (int.Parse(lb_pontos.Text) == 50)
                            {
                                MessageBox.Show("Continue assim", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                           
                        }
                        else
                        {
                            lb_pontos.Text = Convert.ToString(pontos = pontos - 2);
                            MessageBox.Show("O seu Placar está descer", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (int.Parse(lb_pontos.Text) <= 0)
                            {
                                lb_pontos.ForeColor = Color.Red;
                                MessageBox.Show("O seu Placar é menor igual a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        break;
                    //___________________________________________________________________________________________
                    //_________________Muiltiplicar___________________________________________
                    case "x":
                        int multi = int.Parse(valor01.Text) * int.Parse(valor02.Text);
                        if (int.Parse(textBox1.Text) == multi)
                        {
                            lb_pontos.Text = Convert.ToString(pontos += 1);
                            lb_pontos.ForeColor = Color.Green;
                            if (int.Parse(lb_pontos.Text) == 50)
                            {
                                MessageBox.Show("Continue assim", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                           
                        }
                        else
                        {
                            lb_pontos.Text = Convert.ToString(pontos = pontos - 2);
                            MessageBox.Show("O seu Placar está descer", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (int.Parse(lb_pontos.Text) <= 0)
                            {
                                lb_pontos.ForeColor = Color.Red;
                                MessageBox.Show("O seu Placar é menor igual a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        break;
                }
            }
            textBox1.Clear();
            textBox1.Focus();
            atulizar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atulizar();
        }
        private void atulizar()
        {
            Random rdp = new Random();
            p.Add("-");
            p.Add("+");
            p.Add("/");
            p.Add("x");

            lb_operador.Text = p[rdp.Next(0, p.Count)];
            n01 = rd.Next(0, 100);
            n02 = rd.Next(0, 100);

            valor01.Text = n01.ToString();
            valor02.Text = n02.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
