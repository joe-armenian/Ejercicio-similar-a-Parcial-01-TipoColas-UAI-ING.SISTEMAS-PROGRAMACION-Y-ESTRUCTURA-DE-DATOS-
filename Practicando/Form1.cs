using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicando
{
    public partial class Form1 : Form
    {
        miCola _clientes = new miCola();

        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            /*if (txtImporteNodo.Text.Length<0 ||txtNombreNodo.Text.Length == 0 || txtImporteNodo.Text.Length == 0 || txtCodigoNodo.Text.Length == 0 || !System.Text.RegularExpressions.Regex.IsMatch(txtImporteNodo.Text,@"^\d+$") || System.Text.RegularExpressions.Regex.IsMatch(txtNombreNodo.Text,@"\d"))*/
            if (ValidarLetra(txtNombreNodo.Text) && ValidarNumero(txtImporteNodo.Text) && ValidarNumero(txtCodigoNodo.Text))
            {
                

                Nodo unNuevoNodo = new Nodo();
                unNuevoNodo.Nombre = txtNombreNodo.Text;
                unNuevoNodo.Importe = txtImporteNodo.Text;
                unNuevoNodo.Codigo = txtCodigoNodo.Text;

                _clientes.AgregarCliente(unNuevoNodo);
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Debe ingresar un campo valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static bool ValidarNumero (string palabra)
        {
            return Regex.IsMatch(palabra, "^[0-9]+$");
        }

        public static bool ValidarLetra(string palabra)
        {
            return Regex.IsMatch(palabra, "^[a-zA-Z]+$");
        }



        private void btnCobrarCliente_Click(object sender, EventArgs e)
        {
            if (_clientes.Vacia())
            {
                MessageBox.Show("La cola esta vacia!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                double importeCobrado = double.Parse(_clientes._inicio().Importe);
                total += importeCobrado;
                lblTotal.Text = total.ToString();
                _clientes.CobrarCliente();
                MostrarLista();
                



            }
           
            


        }
        private void btnCobrarCliente_Click1(object sender, EventArgs e)
        {
            

        }



        public void MostrarLista()
        {
            lstColaClientes.Items.Clear();
            if (_clientes._inicio()!=null)
            {
                AgregarClientesAcola(_clientes._inicio());
            }
            
        }

        public void AgregarClientesAcola(Nodo unNodo)
        {
            if (unNodo!=null)
            {
                lstColaClientes.Items.Add("Nombre:  " + unNodo.Nombre);
                lstColaClientes.Items.Add("Codigo:  " + unNodo.Codigo);
                lstColaClientes.Items.Add("Importe  " + unNodo.Importe);
                lstColaClientes.Items.Add("===========================");

              if (unNodo.Siguiente!=null)
                {
                    AgregarClientesAcola(unNodo.Siguiente);
                }
            }
        }

        private void tengoUnErrorEnMiCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recuerda que los codigos son alfanumericos y es necesario ingresar correctamente el codigo de su respectiva compra. Chequea los datos y reintente!","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void miImporteNoEsValidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los importes solo aceptan valores numericos y no negativos!","Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nombreInvalidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recuerda que el nombre no puede contener caracteres de tipo numerico.","Error", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
