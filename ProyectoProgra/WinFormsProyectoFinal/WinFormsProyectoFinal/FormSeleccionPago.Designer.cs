namespace WinFormsProyectoFinal
{
    partial class FormSeleccionPago
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
            btnPagoTarjeta = new Button();
            btnPagoEfectivo = new Button();
            btnPagoQR = new Button();
            label1 = new Label();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // btnPagoTarjeta
            // 
            btnPagoTarjeta.FlatStyle = FlatStyle.Flat;
            btnPagoTarjeta.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnPagoTarjeta.ForeColor = SystemColors.ButtonHighlight;
            btnPagoTarjeta.Location = new Point(157, 152);
            btnPagoTarjeta.Name = "btnPagoTarjeta";
            btnPagoTarjeta.Size = new Size(94, 44);
            btnPagoTarjeta.TabIndex = 0;
            btnPagoTarjeta.Text = "Tarjeta";
            btnPagoTarjeta.UseVisualStyleBackColor = true;
            btnPagoTarjeta.Click += btnPagoTarjeta_Click;
            // 
            // btnPagoEfectivo
            // 
            btnPagoEfectivo.FlatStyle = FlatStyle.Flat;
            btnPagoEfectivo.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnPagoEfectivo.ForeColor = SystemColors.ButtonHighlight;
            btnPagoEfectivo.Location = new Point(157, 229);
            btnPagoEfectivo.Name = "btnPagoEfectivo";
            btnPagoEfectivo.Size = new Size(94, 45);
            btnPagoEfectivo.TabIndex = 1;
            btnPagoEfectivo.Text = "Efectivo";
            btnPagoEfectivo.UseVisualStyleBackColor = true;
            btnPagoEfectivo.Click += btnPagoEfectivo_Click;
            // 
            // btnPagoQR
            // 
            btnPagoQR.FlatStyle = FlatStyle.Flat;
            btnPagoQR.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnPagoQR.ForeColor = SystemColors.ButtonHighlight;
            btnPagoQR.Location = new Point(157, 312);
            btnPagoQR.Name = "btnPagoQR";
            btnPagoQR.Size = new Size(94, 40);
            btnPagoQR.TabIndex = 2;
            btnPagoQR.Text = "OXXO";
            btnPagoQR.UseVisualStyleBackColor = true;
            btnPagoQR.Click += btnPagoQR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(33, 65);
            label1.Name = "label1";
            label1.Size = new Size(353, 41);
            label1.TabIndex = 3;
            label1.Text = "METODOS DE PAGO";
            // 
            // btnAtras
            // 
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnAtras.ForeColor = SystemColors.ButtonHighlight;
            btnAtras.Location = new Point(24, 389);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 41);
            btnAtras.TabIndex = 4;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // FormSeleccionPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(430, 451);
            Controls.Add(btnAtras);
            Controls.Add(label1);
            Controls.Add(btnPagoQR);
            Controls.Add(btnPagoEfectivo);
            Controls.Add(btnPagoTarjeta);
            Name = "FormSeleccionPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSeleccionPago";
            Load += FormSeleccionPago_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPagoTarjeta;
        private Button btnPagoEfectivo;
        private Button btnPagoQR;
        private Label label1;
        private Button btnAtras;
    }
}