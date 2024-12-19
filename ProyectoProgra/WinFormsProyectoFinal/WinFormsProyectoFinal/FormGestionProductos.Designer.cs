namespace WinFormsProyectoFinal
{
    partial class FormGestionProductos
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
            panel1 = new Panel();
            btnCancelar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label6 = new Label();
            txtExistencias = new TextBox();
            label5 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtImagen = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtExistencias);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtImagen);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtId);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 513);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(121, 452);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(156, 42);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(121, 393);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(156, 41);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += button1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(121, 335);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(156, 36);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(20, 288);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 11;
            label6.Text = "Existencias: ";
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(144, 282);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(232, 27);
            txtExistencias.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(20, 230);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 9;
            label5.Text = "Precio: ";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(144, 228);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(232, 27);
            txtPrecio.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(20, 175);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 7;
            label4.Text = "Descripcion: ";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(144, 173);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(232, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(20, 122);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 5;
            label3.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 27);
            txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(20, 67);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 3;
            label2.Text = "Imagen: ";
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(144, 65);
            txtImagen.Name = "txtImagen";
            txtImagen.Size = new Size(232, 27);
            txtImagen.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 17);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 1;
            label1.Text = "ID: ";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(144, 15);
            txtId.Name = "txtId";
            txtId.Size = new Size(232, 27);
            txtId.TabIndex = 0;
            // 
            // FormGestionProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 516);
            Controls.Add(panel1);
            Name = "FormGestionProductos";
            Text = "FormGestionProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAgregar;
        private Label label6;
        private TextBox txtExistencias;
        private Label label5;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtImagen;
        private Label label1;
        private TextBox txtId;
        private Button btnCancelar;
        private Button btnModificar;
    }
}