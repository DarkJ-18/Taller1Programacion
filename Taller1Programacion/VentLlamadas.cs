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
    public partial class VentLlamadas : Form
    {
        Llamadas llamadas = new Llamadas();

        public VentLlamadas()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {

           

            switch (cmbpaises.SelectedIndex.ToString())
            {
                case "1":
                    
                    if (llamadas.getMinutos() >= 15)
                    {
                                       
                        llamadas.setMinutos(double.Parse(txtminutos.Text));
                        lbltotal.Text = llamadas.descuetotal().ToString() + " Obtuviste un descuento del 20% ";
                        lbltotal.Visible = true;
                        
                        
                    }
                    else
                    {
                        if (llamadas.getMinutos() < 15)
                        {
                            llamadas.setMinutos(double.Parse(txtminutos.Text));
                            lbltotal.Text = llamadas.llamada1().ToString();
                            lbltotal.Visible = true;
                          
                        }
                    }
                    break;

                case "2":
                    
                    if (llamadas.getMinutos() >= 15)
                    {
                                              
                        llamadas.setMinutos(double.Parse(txtminutos.Text));
                        lbltotal.Text = llamadas.descuetota2().ToString() + " Obtuviste un descuento del 20%";
                        lbltotal.Visible = true;
                       

                    }
                    else
                    {
                        if (llamadas.getMinutos() < 15)
                        {
                            llamadas.setMinutos(double.Parse(txtminutos.Text));
                            lbltotal.Text = llamadas.llamada2().ToString();
                            lbltotal.Visible = true;
                           
                        }
                    }
                    break;

                   
                case "3":

                    if (llamadas.getMinutos() >= 15)
                    {
                        
                        llamadas.setMinutos(double.Parse(txtminutos.Text));
                        lbltotal.Text = llamadas.descuetota3().ToString() + " Obtuviste un descuento del 20% ";
                        lbltotal.Visible = true;
                       

                    }
                    else
                    {
                        if (llamadas.getMinutos() < 15)
                        {
                            llamadas.setMinutos(double.Parse(txtminutos.Text));
                            lbltotal.Text = llamadas.llamada3().ToString();
                            lbltotal.Visible = true;
                           
                        }
                    }
                    break;

                case "4":

                    if (llamadas.getMinutos() >= 15)
                    {
                        
                        llamadas.setMinutos(double.Parse(txtminutos.Text));
                        lbltotal.Text = llamadas.descuetota4().ToString() + " Obtuviste un descuento del 20% ";
                        lbltotal.Visible = true;
                       

                    }
                    else
                    {
                        if (llamadas.getMinutos() < 15)
                        {
                            llamadas.setMinutos(double.Parse(txtminutos.Text));
                            lbltotal.Text = llamadas.llamada4().ToString();
                            lbltotal.Visible = true;
                           
                        }
                    }
                    break;

                default:
                    MessageBox.Show("Debes seleccionar una opción válida");
                    break;
                   
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
