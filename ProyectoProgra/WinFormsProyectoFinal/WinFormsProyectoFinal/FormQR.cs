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
    public partial class FormQR : Form
    {
        public List<ProductosCompra> ProductosCompra { get; set; }
        public string Usuario { get; set; }

        public FormQR()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "El pago se ha realizado correctamente.",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            if (resultado == DialogResult.OK)
            {
                if (ProductosCompra != null && ProductosCompra.Count > 0)
                {
                    GeneradorDeTickets.GenerarPDF(ProductosCompra, Usuario);
                }
                this.Close();
            }


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
