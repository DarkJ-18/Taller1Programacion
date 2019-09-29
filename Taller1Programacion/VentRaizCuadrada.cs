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
    public partial class VentRaizCuadrada : Form
    {
        RaizCuadrada raizCuadrada = new RaizCuadrada();
        public VentRaizCuadrada()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            raizCuadrada.setNum(double.Parse(txtnum.Text));
           
            txtnum.Text = "";

            if (raizCuadrada.getNum() < 0)
            {
                //  raizCuadrada.Resul(double.Parse(txtnum.Text));
                lbltotal.Text =  raizCuadrada.calcular().ToString();
                lbltotal.Visible = true;
                MessageBox.Show("La Raiz Cuadrada es: " + raizCuadrada.calcular().ToString());
            }
           else
           {
                if (raizCuadrada.getNum() == 0)
                {
                    lbltotal.Text = raizCuadrada.calcular().ToString();
                    lbltotal.Visible = true;
                    MessageBox.Show("El número no tiene raiz cuadrada.");
                }
                else
                {
                   lbltotal.Text =  raizCuadrada.calcular().ToString() ;
                    lbltotal.Visible = true;
                  MessageBox.Show("La Raiz Cuadrada es: " + raizCuadrada.calcular().ToString());
                }
           }


        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
