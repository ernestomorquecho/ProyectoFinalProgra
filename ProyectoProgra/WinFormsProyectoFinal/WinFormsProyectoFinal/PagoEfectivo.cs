using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoFinal
{
    public partial class PagoEfectivo : Form
    {
        public List<ProductosCompra> ProductosCompra { get; set; }
        public string Usuario { get; set; }
        public int Total { get; set; }

        public PagoEfectivo(List<ProductosCompra> productosCompra, string usuario, int total)
        {
            InitializeComponent();
            ProductosCompra = productosCompra;
            Usuario = usuario;
            Total = total;

            double totalConInteres = Total * 1.06;
            lblTotal.Text = $"Total con 6% de interés: ${totalConInteres:F2}";
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double efectivoRecibido = 0;
            if (double.TryParse(txtEfectivo.Text, out efectivoRecibido))
            {
                double totalConInteres = Total * 1.06;

                if (efectivoRecibido < totalConInteres)
                {
                    MessageBox.Show("El efectivo recibido es menor que el total de la compra con interés.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double cambio = efectivoRecibido - totalConInteres;
                lblCambio.Text = $"Cambio a devolver: ${cambio:F2}";

                DialogResult result = MessageBox.Show("Pago confirmado con éxito. ¿Deseas generar el ticket?", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    if (ProductosCompra != null && ProductosCompra.Count > 0)
                    {

                        GeneradorDeTickets.GenerarPDFPagoEfectivo(ProductosCompra, Usuario, Total, efectivoRecibido, cambio);
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
