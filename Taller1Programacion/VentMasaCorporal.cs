using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1Programacion
{
    public partial class VentMasaCorporal : Form
    {
         MasaCorporal masaCorporal = new MasaCorporal();
      

        public VentMasaCorporal()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
           
             masaCorporal.setEstatura(double.Parse(txtestatura.Text));
             masaCorporal.setPeso(double.Parse(txtpeso.Text));
            lbltotal.Text = masaCorporal.CalculoIMC().ToString();
            lbltotal.Visible = true;
            txtestatura.Text = "";
            txtpeso.Text = "";
           

            if (masaCorporal.CalculoIMC() < 18.5)
            {
                MessageBox.Show("Usted tiene bajo peso");

            }
            else
            {
                if (masaCorporal.CalculoIMC() < 24.9)
                {
                    MessageBox.Show("Usted tiene peso normal");
                }
                else
                {
                    if (masaCorporal.CalculoIMC() < 29.9)
                    {
                        MessageBox.Show("Usted tiene sobrepeso");
                    }
                    else
                    {
                        if (masaCorporal.CalculoIMC() < 34.9)
                        {
                            MessageBox.Show("Usted tiene obecidad tipo 1");
                        }
                        else
                        {
                            if (masaCorporal.CalculoIMC() < 39.9)
                            {
                                MessageBox.Show("Usted tiene obecidad tipo 2");
                            }
                            else
                            {
                                if (masaCorporal.CalculoIMC() < 40)
                                {
                                    MessageBox.Show("Usted tiene obecidad tipo 3");
                                }
                                else
                                {
                                    MessageBox.Show("Usted tiene obecidad tipo 4");
                                }
                            }
                        }
                    }
                }
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}