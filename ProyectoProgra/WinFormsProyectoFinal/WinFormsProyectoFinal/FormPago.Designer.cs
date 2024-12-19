namespace WinFormsProyectoFinal
{
    partial class FormPago
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
            label1 = new Label();
            txtTarjeta = new TextBox();
            label2 = new Label();
            txtNIP = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 178);
            label1.Name = "label1";
            label1.Size = new Size(199, 24);
            label1.TabIndex = 0;
            label1.Text = "Numero de Tarjeta";
            // 
            // txtTarjeta
            // 
            txtTarjeta.AllowDrop = true;
            txtTarjeta.Location = new Point(217, 179);
            txtTarjeta.MaxLength = 16;
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new Size(125, 27);
            txtTarjeta.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(90, 232);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 2;
            label2.Text = "NIP";
            // 
            // txtNIP
            // 
            txtNIP.AllowDrop = true;
            txtNIP.Location = new Point(217, 229);
            txtNIP.MaxLength = 4;
            txtNIP.Name = "txtNIP";
            txtNIP.Size = new Size(125, 27);
            txtNIP.TabIndex = 3;
            txtNIP.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnAceptar.ForeColor = SystemColors.ButtonHighlight;
            btnAceptar.Location = new Point(137, 302);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 49);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(137, 372);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(25, 56);
            label3.Name = "label3";
            label3.Size = new Size(305, 41);
            label3.TabIndex = 6;
            label3.Text = "Pago con Tarjeta";
            // 
            // FormPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(364, 450);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNIP);
            Controls.Add(label2);
            Controls.Add(txtTarjeta);
            Controls.Add(label1);
            Name = "FormPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTarjeta;
        private Label label2;
        private TextBox txtNIP;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label3;
    }
}