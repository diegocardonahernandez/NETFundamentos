namespace WinFormsApp1
{
    partial class Form03DiaNacimiento
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
            lblDia = new Label();
            lblMes = new Label();
            lblAnio = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnio = new TextBox();
            btnMostrar = new Button();
            lblDiaResultado = new Label();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(269, 46);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(24, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "Día";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(399, 46);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mes";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(553, 46);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(29, 15);
            lblAnio.TabIndex = 2;
            lblAnio.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(228, 93);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(372, 93);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 4;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(516, 93);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 5;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(345, 159);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(147, 23);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "Mostrar Día";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblDiaResultado
            // 
            lblDiaResultado.AutoSize = true;
            lblDiaResultado.Location = new Point(399, 235);
            lblDiaResultado.Name = "lblDiaResultado";
            lblDiaResultado.Size = new Size(0, 15);
            lblDiaResultado.TabIndex = 7;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDiaResultado);
            Controls.Add(btnMostrar);
            Controls.Add(txtAnio);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblAnio);
            Controls.Add(lblMes);
            Controls.Add(lblDia);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblMes;
        private Label lblAnio;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnio;
        private Button btnMostrar;
        private Label lblDiaResultado;
    }
}