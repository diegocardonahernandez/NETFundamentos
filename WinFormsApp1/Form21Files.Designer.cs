namespace WinFormsApp1
{
    partial class Form21Files
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
            lblContenido = new Label();
            txtContenido = new TextBox();
            label2 = new Label();
            txtNuevoNombre = new TextBox();
            btnNuevoNombre = new Button();
            btnLeer = new Button();
            btnEscribir = new Button();
            label3 = new Label();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // lblContenido
            // 
            lblContenido.AutoSize = true;
            lblContenido.Location = new Point(47, 35);
            lblContenido.Name = "lblContenido";
            lblContenido.Size = new Size(105, 15);
            lblContenido.TabIndex = 0;
            lblContenido.Text = "Contenido Fichero";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(47, 64);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(217, 355);
            txtContenido.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 44);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(336, 79);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(100, 23);
            txtNuevoNombre.TabIndex = 3;
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(336, 124);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(100, 23);
            btnNuevoNombre.TabIndex = 4;
            btnNuevoNombre.Text = "Nuevo nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(336, 165);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(100, 23);
            btnLeer.TabIndex = 5;
            btnLeer.Text = "Leer File";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnEscribir
            // 
            btnEscribir.Location = new Point(336, 208);
            btnEscribir.Name = "btnEscribir";
            btnEscribir.Size = new Size(100, 23);
            btnEscribir.TabIndex = 6;
            btnEscribir.Text = "Write File";
            btnEscribir.UseVisualStyleBackColor = true;
            btnEscribir.Click += btnEscribir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 44);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(548, 79);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(222, 334);
            lstNombres.TabIndex = 8;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(btnEscribir);
            Controls.Add(btnLeer);
            Controls.Add(btnNuevoNombre);
            Controls.Add(txtNuevoNombre);
            Controls.Add(label2);
            Controls.Add(txtContenido);
            Controls.Add(lblContenido);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContenido;
        private TextBox txtContenido;
        private Label label2;
        private TextBox txtNuevoNombre;
        private Button btnNuevoNombre;
        private Button btnLeer;
        private Button btnEscribir;
        private Label label3;
        private ListBox lstNombres;
    }
}