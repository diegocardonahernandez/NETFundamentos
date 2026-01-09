namespace WinFormsApp1
{
    partial class Form24ColeccionMascotas
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
            txtEdad = new TextBox();
            label3 = new Label();
            txtRaza = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            lstMascotas = new ListBox();
            btnLeerMascotas = new Button();
            btnGuardarMascotas = new Button();
            btnNuevaMascota = new Button();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(60, 244);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(94, 23);
            txtEdad.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 207);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 10;
            label3.Text = "Edad";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(60, 149);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(149, 23);
            txtRaza.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 112);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 8;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(60, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 40);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "label4";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(330, 78);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(183, 199);
            lstMascotas.TabIndex = 13;
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(531, 78);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(125, 32);
            btnLeerMascotas.TabIndex = 14;
            btnLeerMascotas.Text = "Leer Mascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(531, 149);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(125, 30);
            btnGuardarMascotas.TabIndex = 15;
            btnGuardarMascotas.Text = "Guardar Mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            btnGuardarMascotas.Click += btnGuardarMascotas_Click;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(60, 309);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(149, 23);
            btnNuevaMascota.TabIndex = 16;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(330, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(531, 207);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(125, 27);
            btnExaminar.TabIndex = 18;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form24ColeccionMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNuevaMascota);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(btnLeerMascotas);
            Controls.Add(lstMascotas);
            Controls.Add(label4);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form24ColeccionMascotas";
            Text = "Form24ColeccionMascotas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEdad;
        private Label label3;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnLeerMascotas;
        private Button btnGuardarMascotas;
        private Button btnNuevaMascota;
        private PictureBox pictureBox1;
        private Button btnExaminar;
        private OpenFileDialog openFileDialog1;
    }
}