namespace WinFormsProyectoFinal
{
    partial class FormBienvenida
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
            lblBienvenida = new Label();
            lblDPermisos = new Label();
            lblPermisos = new Label();
            btn1 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblBienvenida.ForeColor = SystemColors.ButtonHighlight;
            lblBienvenida.Location = new Point(217, 19);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(329, 18);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "!Bienvenido, Usuario (Nombre de Usuario)!";
            // 
            // lblDPermisos
            // 
            lblDPermisos.AutoSize = true;
            lblDPermisos.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblDPermisos.ForeColor = SystemColors.ButtonHighlight;
            lblDPermisos.Location = new Point(54, 100);
            lblDPermisos.Name = "lblDPermisos";
            lblDPermisos.Size = new Size(442, 18);
            lblDPermisos.TabIndex = 1;
            lblDPermisos.Text = "Te recoradmos que en esta cuenta solo podrás hacer esto: ";
            // 
            // lblPermisos
            // 
            lblPermisos.AutoSize = true;
            lblPermisos.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPermisos.ForeColor = SystemColors.ButtonHighlight;
            lblPermisos.Location = new Point(54, 145);
            lblPermisos.Name = "lblPermisos";
            lblPermisos.Size = new Size(375, 18);
            lblPermisos.TabIndex = 2;
            lblPermisos.Text = "En este label aparecera el usuario y sus permisos";
            // 
            // btn1
            // 
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Tahoma", 12F);
            btn1.ForeColor = SystemColors.ButtonHighlight;
            btn1.Location = new Point(637, 209);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(114, 40);
            btn1.TabIndex = 3;
            btn1.Text = "Siguiente";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click_1;
            btn1.MouseEnter += btn1_MouseEnter;
            btn1.MouseLeave += btn1_MouseLeave;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 209);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 40);
            button1.TabIndex = 4;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // FormBienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(763, 262);
            Controls.Add(button1);
            Controls.Add(btn1);
            Controls.Add(lblPermisos);
            Controls.Add(lblDPermisos);
            Controls.Add(lblBienvenida);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormBienvenida";
            Text = "Form2";
            Load += FormBienvenida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label lblDPermisos;
        private Label lblPermisos;
        private Button btn1;
        private Button button1;
    }
}