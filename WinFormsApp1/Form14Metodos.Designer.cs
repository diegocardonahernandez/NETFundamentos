namespace WinFormsApp1
{
    partial class Form14Metodos
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnDoble = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            lblSoloNumeros = new Label();
            lblSoloLetras = new Label();
            lblRaton = new Label();
            txtSoloNumeros = new TextBox();
            txtSoloLetras = new TextBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(25, 37);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(25, 67);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(25, 114);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "lblResultado";
            // 
            // btnDoble
            // 
            btnDoble.Location = new Point(190, 42);
            btnDoble.Name = "btnDoble";
            btnDoble.Size = new Size(129, 23);
            btnDoble.TabIndex = 3;
            btnDoble.Text = "Doble Valor";
            btnDoble.UseVisualStyleBackColor = true;
            btnDoble.Click += btnDoble_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(190, 87);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(129, 23);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(190, 138);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(129, 23);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // lblSoloNumeros
            // 
            lblSoloNumeros.AutoSize = true;
            lblSoloNumeros.Location = new Point(456, 48);
            lblSoloNumeros.Name = "lblSoloNumeros";
            lblSoloNumeros.Size = new Size(82, 15);
            lblSoloNumeros.TabIndex = 6;
            lblSoloNumeros.Text = "Solo Números";
            // 
            // lblSoloLetras
            // 
            lblSoloLetras.AutoSize = true;
            lblSoloLetras.Location = new Point(456, 93);
            lblSoloLetras.Name = "lblSoloLetras";
            lblSoloLetras.Size = new Size(64, 15);
            lblSoloLetras.TabIndex = 7;
            lblSoloLetras.Text = "Solo Letras";
            // 
            // lblRaton
            // 
            lblRaton.AutoSize = true;
            lblRaton.Location = new Point(482, 215);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(38, 15);
            lblRaton.TabIndex = 8;
            lblRaton.Text = "label1";
            lblRaton.MouseMove += label1_MouseMove;
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(594, 48);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(100, 23);
            txtSoloNumeros.TabIndex = 9;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(594, 93);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(100, 23);
            txtSoloLetras.TabIndex = 10;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoloLetras);
            Controls.Add(txtSoloNumeros);
            Controls.Add(lblRaton);
            Controls.Add(lblSoloLetras);
            Controls.Add(lblSoloNumeros);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDoble);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnDoble;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label lblSoloNumeros;
        private Label lblSoloLetras;
        private Label lblRaton;
        private TextBox txtSoloNumeros;
        private TextBox txtSoloLetras;
    }
}