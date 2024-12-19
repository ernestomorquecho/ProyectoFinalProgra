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
    public partial class FormSeleccionPago : Form
    {
        public List<ProductosCompra> ProductosCompra { get; set; }
        public string Usuario { get; set; }
        public int Total { get; set; }

        public FormSeleccionPago(List<ProductosCompra> productosCompra, string usuario, int totalCompra)
        {
            InitializeComponent();
            ProductosCompra = productosCompra;
            Usuario = usuario;
            Total = totalCompra;
        }
        private void btnPagoTarjeta_Click(object sender, EventArgs e)
        {
            FormPago formPago = new FormPago();
            formPago.ProductosCompra = ProductosCompra;
            formPago.Usuario = Usuario;
            formPago.ShowDialog();
            this.Close();
        }

        private void btnPagoEfectivo_Click(object sender, EventArgs e)
        {
            PagoEfectivo pagoEfectivo = new PagoEfectivo(ProductosCompra, Usuario, Total);
            pagoEfectivo.ShowDialog();
            this.Close();
        }

        private void btnPagoQR_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de pago con QR
            FormQR formQR = new FormQR
            {
                ProductosCompra = ProductosCompra,
                Usuario = Usuario
            };
            formQR.ShowDialog();
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSeleccionPago_Load(object sender, EventArgs e)
        {

        }
    }
}
