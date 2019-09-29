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
    public partial class VentPromedioNotas : Form
    {
        PromedioNotas promedioNotas = new PromedioNotas();
        public VentPromedioNotas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            promedioNotas.setNota1(double.Parse(txtnota1.Text));
            promedioNotas.setNota2(double.Parse(txtnota2.Text));
            promedioNotas.setNota3(double.Parse(txtnota3.Text));
            promedioNotas.setNota4(double.Parse(txtnota4.Text));

            lbltotal.Text = promedioNotas.total().ToString();
            lbltotal.Visible = true;
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtnota4.Text = "";

            if (promedioNotas.total() < 2.99)
            {
                MessageBox.Show("Deficiente.");
            }
            else
            {
                if (promedioNotas.total() < 3.99)
                {
                    MessageBox.Show("Bien.");
                }
                else
                {
                    if (promedioNotas.total() >=4 && promedioNotas.total() <=5)
                    {
                        MessageBox.Show("Excelente.");
                    }
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
