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
    public partial class VentEdadEtapas : Form
    {
        EdadEtapas edadEtapas = new EdadEtapas();

        public VentEdadEtapas()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            edadEtapas.setEdad(int.Parse(txtedad.Text));
            txtedad.Text = "";

            if (edadEtapas.getEdad() <= 10)
            {
                MessageBox.Show("Es un niño.");
            }
            else
            {
                if (edadEtapas.getEdad() <= 14)
                {
                    MessageBox.Show("Es un pre-Adolescente.");
                }
                else
                {
                    if (edadEtapas.getEdad() <= 18)
                    {
                        MessageBox.Show("Es un Adolescente");
                    }
                    else
                    {
                        if (edadEtapas.getEdad() <= 25)
                        {
                            MessageBox.Show("Es un joven.");
                        }
                        else
                        {
                            if (edadEtapas.getEdad() <= 65)
                            {
                                MessageBox.Show("Es un Adulto.");
                            }
                            else
                            {
                                if (edadEtapas.getEdad() > 65)
                                {
                                    MessageBox.Show("Es un Anciano.");
                                }
                            }
                        }
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
