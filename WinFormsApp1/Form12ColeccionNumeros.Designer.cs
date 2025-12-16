namespace WinFormsApp1
{
    partial class Form12ColeccionNumeros
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
            lblTitulo = new Label();
            listElementos = new ListBox();
            btnGenerar = new Button();
            btnMostrar = new Button();
            lblSumar = new Label();
            lblPares = new Label();
            lblImpares = new Label();
            txtSumar = new TextBox();
            txtPares = new TextBox();
            txtImpares = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(59, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "label1";
            // 
            // listElementos
            // 
            listElementos.FormattingEnabled = true;
            listElementos.Location = new Point(59, 77);
            listElementos.Name = "listElementos";
            listElementos.Size = new Size(120, 154);
            listElementos.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(208, 77);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(118, 23);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar Números";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(365, 77);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(118, 23);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar Datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblSumar
            // 
            lblSumar.AutoSize = true;
            lblSumar.Location = new Point(241, 134);
            lblSumar.Name = "lblSumar";
            lblSumar.Size = new Size(41, 15);
            lblSumar.TabIndex = 4;
            lblSumar.Text = "Sumar";
            // 
            // lblPares
            // 
            lblPares.AutoSize = true;
            lblPares.Location = new Point(241, 172);
            lblPares.Name = "lblPares";
            lblPares.Size = new Size(35, 15);
            lblPares.TabIndex = 5;
            lblPares.Text = "Pares";
            // 
            // lblImpares
            // 
            lblImpares.AutoSize = true;
            lblImpares.Location = new Point(241, 208);
            lblImpares.Name = "lblImpares";
            lblImpares.Size = new Size(49, 15);
            lblImpares.TabIndex = 6;
            lblImpares.Text = "Impares";
            // 
            // txtSumar
            // 
            txtSumar.Location = new Point(321, 134);
            txtSumar.Name = "txtSumar";
            txtSumar.Size = new Size(100, 23);
            txtSumar.TabIndex = 7;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(321, 172);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 8;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(321, 208);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 9;
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtImpares);
            Controls.Add(txtPares);
            Controls.Add(txtSumar);
            Controls.Add(lblImpares);
            Controls.Add(lblPares);
            Controls.Add(lblSumar);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(listElementos);
            Controls.Add(lblTitulo);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ListBox listElementos;
        private Button btnGenerar;
        private Button btnMostrar;
        private Label lblSumar;
        private Label lblPares;
        private Label lblImpares;
        private TextBox txtSumar;
        private TextBox txtPares;
        private TextBox txtImpares;
    }
}