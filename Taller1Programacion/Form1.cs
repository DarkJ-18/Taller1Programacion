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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnmasa_Click(object sender, EventArgs e)
        {
            VentMasaCorporal ventMasaCorporal = new VentMasaCorporal();
            ventMasaCorporal.Show();
            this.Hide();
        }

        private void Btnllamadas_Click(object sender, EventArgs e)
        {
            VentLlamadas ventLlamadas = new VentLlamadas();
            ventLlamadas.Show();
            this.Hide();
        }

        private void Btnnotas_Click(object sender, EventArgs e)
        {
            VentPromedioNotas ventPromedioNotas = new VentPromedioNotas();
            ventPromedioNotas.Show();
            this.Hide();
        }

        private void Btnvolumen_Click(object sender, EventArgs e)
        {
            VentVolumen ventVolumen = new VentVolumen();
            ventVolumen.Show();
            this.Hide();
        }

        private void Btnraiz_Click(object sender, EventArgs e)
        {
            VentRaizCuadrada ventRaizCuadrada = new VentRaizCuadrada();
            ventRaizCuadrada.Show();
            this.Hide();
        }

        private void Btnsegundos_Click(object sender, EventArgs e)
        {
            VentEdadSegundos ventEdadSegundos = new VentEdadSegundos();
            ventEdadSegundos.Show();
            this.Hide();
        }

        private void Btndescuento_Click(object sender, EventArgs e)
        {
            VentDescuentoIva ventDescuentoIva = new VentDescuentoIva();
            ventDescuentoIva.Show();
            this.Hide();
        }

     
        private void Btnedad_Click(object sender, EventArgs e)
        {
            VentEdadEtapas ventEdad = new VentEdadEtapas();
            ventEdad.Show();
            this.Hide();
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
