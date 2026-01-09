namespace WinFormsApp1
{
    partial class Form23ObjetoMascotalXML
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
            txtNombre = new TextBox();
            label2 = new Label();
            txtRaza = new TextBox();
            txtEdad = new TextBox();
            label3 = new Label();
            btnLeerClase = new Button();
            btnGuardar = new Button();
            btnSelecImagen = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(51, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 109);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(51, 146);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(149, 23);
            txtRaza.TabIndex = 3;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(51, 241);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(94, 23);
            txtEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 204);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // btnLeerClase
            // 
            btnLeerClase.Location = new Point(261, 61);
            btnLeerClase.Name = "btnLeerClase";
            btnLeerClase.Size = new Size(126, 35);
            btnLeerClase.TabIndex = 6;
            btnLeerClase.Text = "Leer Clase";
            btnLeerClase.UseVisualStyleBackColor = true;
            btnLeerClase.Click += btnLeerClase_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(261, 146);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 35);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar Clase";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSelecImagen
            // 
            btnSelecImagen.Location = new Point(261, 231);
            btnSelecImagen.Name = "btnSelecImagen";
            btnSelecImagen.Size = new Size(126, 33);
            btnSelecImagen.TabIndex = 8;
            btnSelecImagen.Text = "Seleciconar Imagen";
            btnSelecImagen.UseVisualStyleBackColor = true;
            btnSelecImagen.Click += btnSelecImagen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(51, 298);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 127);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form23ObjetoMascotalXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnSelecImagen);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeerClase);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form23ObjetoMascotalXML";
            Text = "Form23ObjetoMascotalXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private TextBox txtEdad;
        private Label label3;
        private Button btnLeerClase;
        private Button btnGuardar;
        private Button btnSelecImagen;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}