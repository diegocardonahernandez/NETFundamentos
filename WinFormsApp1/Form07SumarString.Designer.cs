namespace WinFormsApp1
{
    partial class Form07SumarString
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
            txtNumeros = new TextBox();
            btnSumar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(336, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(115, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Introduzca Números";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(294, 59);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(191, 23);
            txtNumeros.TabIndex = 2;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(294, 107);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(191, 26);
            btnSumar.TabIndex = 3;
            btnSumar.Text = "Sumar Números";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(354, 167);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "lblResultado";
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnSumar);
            Controls.Add(txtNumeros);
            Controls.Add(lblTitulo);
            Name = "Form07SumarString";
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNumeros;
        private Button btnSumar;
        private Label lblResultado;
    }
}