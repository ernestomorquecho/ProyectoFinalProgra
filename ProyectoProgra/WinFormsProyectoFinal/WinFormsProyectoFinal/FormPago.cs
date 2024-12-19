using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsProyectoFinal


{
    public partial class FormPago : Form
    {
        public List<ProductosCompra> ProductosCompra { get; set; }
        public bool PagoConfirmado { get; private set; } = false;
        public string NumeroTarjeta { get; private set; } = "";
        public string NIP { get; private set; } = "";
        public string Usuario { get; set; }

        public FormPago()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El pago ha sido cancelado.", "Pago Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string tarjeta = txtTarjeta.Text.Trim();
            string nip = txtNIP.Text.Trim();

            if (!Regex.IsMatch(tarjeta, @"^\d{16}$"))
            {
                MessageBox.Show("El número de tarjeta debe contener 16 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(nip, @"^\d{4}$"))
            {
                MessageBox.Show("El NIP debe contener 4 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PagoConfirmado = true;
            NumeroTarjeta = tarjeta;
            NIP = nip;

            DialogResult result = MessageBox.Show("Pago confirmado con éxito. ¿Deseas generar el ticket?", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                // Se hace el PDF cuando se le al boton de OK
                if (ProductosCompra != null && ProductosCompra.Count > 0)
                {
                    GeneradorDeTickets.GenerarPDF(ProductosCompra, Usuario);
                }
            }
            this.Close();
        }
    }
}