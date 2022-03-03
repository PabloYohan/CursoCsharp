using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aw9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Single Soma;

                Soma = 0;

                if (checkBox1.Checked)
                    Soma = Soma + 9;

                if (checkBox2.Checked)
                    Soma = Soma + 8;

                if (checkBox3.Checked)
                    Soma = Soma + 11;

                if (checkBox4.Checked)
                    Soma = Soma + 10;

                if (checkBox5.Checked)
                    Soma = Soma + 12;
                textBox1.Text = Convert.ToString(Soma);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Single Soma;

                Soma = 0;

                if (checkBox6.Checked)
                    Soma = Soma + 6;

                if (checkBox7.Checked)
                    Soma = Soma + 5;

                if (checkBox8.Checked)
                    Soma = Soma + 3;
                textBox2.Text = Convert.ToString(Soma);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                Single Pastel, Bebida, Total, Desconto;

                Pastel = 0;
                Bebida = 0;
                Total = 0;
                Desconto = 0;

                Pastel = Convert.ToSingle(textBox1.Text);
                Bebida = Convert.ToSingle(textBox2.Text);

                Total = Pastel + Bebida;
                textBox3.Text = Convert.ToString(Total);

                if (radioButton1.Checked)
                    Desconto = Total * 10 / 100;

                if (radioButton2.Checked)
                    Desconto = Total * 5 / 100;

                if (radioButton3.Checked)
                    Desconto = 0;

                textBox4.Text = Convert.ToString(Desconto);

                Total = Total - Desconto;
                textBox5.Text = Convert.ToString(Total);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
