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
    public partial class VentVolumen : Form
    {
        VolumenCaja volumenCaja = new VolumenCaja();
        public VentVolumen()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            volumenCaja.setA(double.Parse(txta.Text));
            volumenCaja.setB(double.Parse(txtb.Text));
            volumenCaja.setC(double.Parse(txtc.Text));

            lbltotal.Text = volumenCaja.Volumcaja().ToString();
            lbltotal.Visible = true;
            lbltotal.Text = "";
            MessageBox.Show("El volumen de es: " + volumenCaja.Volumcaja().ToString());

        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
