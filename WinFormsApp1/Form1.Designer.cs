namespace WinFormsApp1
{
    partial class Form1
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
            btnPulsar = new Button();
            lblTitulo = new Label();
            txtCaja = new TextBox();
            SuspendLayout();
            // 
            // btnPulsar
            // 
            btnPulsar.Location = new Point(330, 92);
            btnPulsar.Name = "btnPulsar";
            btnPulsar.Size = new Size(138, 47);
            btnPulsar.TabIndex = 0;
            btnPulsar.Text = "Pulsar";
            btnPulsar.UseVisualStyleBackColor = true;
            btnPulsar.Click += btnPulsar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(345, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(123, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Intrpduzca su nombre";
            // 
            // txtCaja
            // 
            txtCaja.BackColor = Color.White;
            txtCaja.Location = new Point(294, 43);
            txtCaja.Name = "txtCaja";
            txtCaja.Size = new Size(231, 23);
            txtCaja.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(800, 456);
            Controls.Add(txtCaja);
            Controls.Add(lblTitulo);
            Controls.Add(btnPulsar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPulsar;
        private Label lblTitulo;
        private TextBox txtCaja;
    }
}
