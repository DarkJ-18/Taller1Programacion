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
    public partial class VentEdadSegundos : Form
    {
        EdadSegundos EdadSegundos = new EdadSegundos();

        public VentEdadSegundos()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            EdadSegundos.setEdad(int.Parse(txtaño.Text));

            lblsegundos.Text = EdadSegundos.segundos().ToString();
            lblsegundos.Visible = true;

            lbledad.Text = EdadSegundos.calcular().ToString();
            lbledad.Visible = true;

        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
