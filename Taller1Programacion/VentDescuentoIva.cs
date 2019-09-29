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
    public partial class VentDescuentoIva : Form
    {
        DescuentoIva descuentoIva = new DescuentoIva();

        public VentDescuentoIva()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            descuentoIva.setMonto(double.Parse(txtprecio.Text));

            lbldescuento.Text = descuentoIva.descuento().ToString();
            lbltotal.Text = descuentoIva.total().ToString();
            lbltotal.Visible = true;
            lbldescuento.Visible = true;
           // MessageBox.Show("Preco total a pagar: " + descuentoIva.ivatotal().ToString());

        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
