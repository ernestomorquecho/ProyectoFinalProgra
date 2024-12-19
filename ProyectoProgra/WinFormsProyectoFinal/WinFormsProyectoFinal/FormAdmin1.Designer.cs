namespace WinFormsAppIdeaProy
{
    partial class FormAdmin1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin1));
            buttonAnadir = new Button();
            labelPVCafe = new Label();
            buttonEliminar = new Button();
            buttonModificar = new Button();
            btnVentas = new Button();
            button10 = new Button();
            panel1 = new Panel();
            panelProductos = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAnadir
            // 
            buttonAnadir.FlatStyle = FlatStyle.Flat;
            buttonAnadir.Font = new Font("Tahoma", 12F);
            buttonAnadir.ForeColor = SystemColors.ButtonHighlight;
            buttonAnadir.Location = new Point(37, 219);
            buttonAnadir.Margin = new Padding(3, 5, 3, 5);
            buttonAnadir.Name = "buttonAnadir";
            buttonAnadir.Size = new Size(160, 59);
            buttonAnadir.TabIndex = 19;
            buttonAnadir.Text = "Añadir";
            buttonAnadir.UseVisualStyleBackColor = true;
            buttonAnadir.Click += buttonAnadir_Click;
            buttonAnadir.MouseEnter += buttonAnadir_MouseEnter;
            buttonAnadir.MouseLeave += ButtonAnadir_MouseLeave;
            // 
            // labelPVCafe
            // 
            labelPVCafe.BackColor = Color.FromArgb(90, 90, 90);
            labelPVCafe.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPVCafe.ForeColor = SystemColors.ButtonHighlight;
            labelPVCafe.ImageAlign = ContentAlignment.TopCenter;
            labelPVCafe.Location = new Point(256, 12);
            labelPVCafe.Name = "labelPVCafe";
            labelPVCafe.RightToLeft = RightToLeft.No;
            labelPVCafe.Size = new Size(565, 41);
            labelPVCafe.TabIndex = 0;
            labelPVCafe.Text = "Administrador officetemas\r\n";
            labelPVCafe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonEliminar
            // 
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Tahoma", 12F);
            buttonEliminar.ForeColor = SystemColors.ButtonHighlight;
            buttonEliminar.Location = new Point(37, 438);
            buttonEliminar.Margin = new Padding(3, 5, 3, 5);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(160, 59);
            buttonEliminar.TabIndex = 29;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            buttonEliminar.MouseEnter += buttonEliminar_MouseEnter;
            buttonEliminar.MouseLeave += buttonEliminar_MouseLeave;
            // 
            // buttonModificar
            // 
            buttonModificar.FlatStyle = FlatStyle.Flat;
            buttonModificar.Font = new Font("Tahoma", 12F);
            buttonModificar.ForeColor = SystemColors.ButtonHighlight;
            buttonModificar.Location = new Point(37, 327);
            buttonModificar.Margin = new Padding(3, 5, 3, 5);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(158, 59);
            buttonModificar.TabIndex = 33;
            buttonModificar.Text = "Actualizar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click_1;
            buttonModificar.MouseEnter += buttonModificar_MouseEnter;
            buttonModificar.MouseLeave += buttonModificar_MouseLeave;
            // 
            // btnVentas
            // 
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = SystemColors.ButtonHighlight;
            btnVentas.Location = new Point(13, 12);
            btnVentas.Margin = new Padding(3, 5, 3, 5);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(125, 41);
            btnVentas.TabIndex = 35;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            btnVentas.MouseEnter += btnVentas_MouseEnter;
            btnVentas.MouseLeave += btnVentas_MouseLeave;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(949, 12);
            button10.Margin = new Padding(3, 5, 3, 5);
            button10.Name = "button10";
            button10.Size = new Size(110, 41);
            button10.TabIndex = 36;
            button10.Text = "Logout";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            button10.MouseEnter += button10_MouseEnter;
            button10.MouseLeave += button10_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(panelProductos);
            panel1.Controls.Add(labelPVCafe);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(buttonModificar);
            panel1.Controls.Add(buttonEliminar);
            panel1.Controls.Add(buttonAnadir);
            panel1.Location = new Point(-1, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 691);
            panel1.TabIndex = 37;
            panel1.Paint += Panel1_Paint;
            // 
            // panelProductos
            // 
            panelProductos.AutoScroll = true;
            panelProductos.Location = new Point(229, 72);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(779, 560);
            panelProductos.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1071, 63);
            panel2.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(13, 15);
            label2.Name = "label2";
            label2.Size = new Size(175, 23);
            label2.TabIndex = 2;
            label2.Text = "OFFICETEMAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(604, 20);
            label1.Name = "label1";
            label1.Size = new Size(339, 18);
            label1.TabIndex = 1;
            label1.Text = "Con officetemas, tus ideas no tienen dilemas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(949, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormAdmin1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 750);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdmin1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonAnadir;
        private Label labelPVCafe;
        private Button buttonEliminar;
        private Button buttonModificar;
        private Button btnVentas;
        private Button button10;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panelProductos;
    }
}
