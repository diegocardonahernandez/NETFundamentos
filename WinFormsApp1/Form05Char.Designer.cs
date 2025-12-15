namespace WinFormsApp1
{
    partial class Form05Char
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
            lblLetras = new Label();
            txtLetras = new TextBox();
            txtSimbolos = new TextBox();
            lblSimbolos = new Label();
            txtNumeros = new TextBox();
            lblNumeros = new Label();
            txtPuntuacion = new TextBox();
            lblPuntuacion = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Location = new Point(49, 27);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(38, 15);
            lblLetras.TabIndex = 0;
            lblLetras.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(49, 67);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(268, 104);
            txtLetras.TabIndex = 1;
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(49, 237);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(268, 104);
            txtSimbolos.TabIndex = 3;
            // 
            // lblSimbolos
            // 
            lblSimbolos.AutoSize = true;
            lblSimbolos.Location = new Point(49, 197);
            lblSimbolos.Name = "lblSimbolos";
            lblSimbolos.Size = new Size(56, 15);
            lblSimbolos.TabIndex = 2;
            lblSimbolos.Text = "Simbolos";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(455, 67);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(268, 104);
            txtNumeros.TabIndex = 5;
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(500, 27);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(56, 15);
            lblNumeros.TabIndex = 4;
            lblNumeros.Text = "Numeros";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(455, 237);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(268, 104);
            txtPuntuacion.TabIndex = 7;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Location = new Point(455, 197);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(68, 15);
            lblPuntuacion.TabIndex = 6;
            lblPuntuacion.Text = "Puntuacion";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(317, 377);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(130, 32);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run ASCII";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRun);
            Controls.Add(txtPuntuacion);
            Controls.Add(lblPuntuacion);
            Controls.Add(txtNumeros);
            Controls.Add(lblNumeros);
            Controls.Add(txtSimbolos);
            Controls.Add(lblSimbolos);
            Controls.Add(txtLetras);
            Controls.Add(lblLetras);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLetras;
        private TextBox txtLetras;
        private TextBox txtSimbolos;
        private Label lblSimbolos;
        private TextBox txtNumeros;
        private Label lblNumeros;
        private TextBox txtPuntuacion;
        private Label lblPuntuacion;
        private Button btnRun;
    }
}