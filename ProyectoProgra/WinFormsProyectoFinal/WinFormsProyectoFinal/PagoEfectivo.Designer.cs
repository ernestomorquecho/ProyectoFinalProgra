namespace WinFormsProyectoFinal
{
    partial class PagoEfectivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblCambio = new Label();
            txtEfectivo = new TextBox();
            btnAceptar = new Button();
            btnAtras = new Button();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(36, 52);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(352, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PAGO EN EFECTIVO";
            lblTitulo.Click += lblTotal_Click;
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCambio.ForeColor = SystemColors.ButtonFace;
            lblCambio.Location = new Point(50, 291);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(85, 24);
            lblCambio.TabIndex = 1;
            lblCambio.Text = "Cambio";
            // 
            // txtEfectivo
            // 
            txtEfectivo.Location = new Point(134, 222);
            txtEfectivo.MaxLength = 4;
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(125, 27);
            txtEfectivo.TabIndex = 2;
            txtEfectivo.TextChanged += txtEfectivo_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnAceptar.ForeColor = SystemColors.ButtonHighlight;
            btnAceptar.Location = new Point(278, 374);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 46);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAtras
            // 
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnAtras.ForeColor = SystemColors.ButtonHighlight;
            btnAtras.Location = new Point(50, 374);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 46);
            btnAtras.TabIndex = 5;
            btnAtras.Text = "Cancelar";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ButtonFace;
            lblTotal.Location = new Point(47, 153);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(88, 24);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Compra";
            // 
            // PagoEfectivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(422, 450);
            Controls.Add(btnAtras);
            Controls.Add(lblTotal);
            Controls.Add(btnAceptar);
            Controls.Add(txtEfectivo);
            Controls.Add(lblCambio);
            Controls.Add(lblTitulo);
            Name = "PagoEfectivo";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCambio;
        private TextBox txtEfectivo;
        private Button btnAceptar;
        private Button btnAtras;
        private Label lblTotal;
    }
}