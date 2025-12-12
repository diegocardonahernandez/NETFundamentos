namespace WinFormsApp1
{
    partial class Form02ColoresPosicion
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
            lbl1 = new Label();
            lbl2 = new Label();
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            btnCambiarPosicion = new Button();
            lblRojo = new Label();
            lblVerde = new Label();
            lblAzul = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnCambiarFondo = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(101, 110);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(62, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Posicion X";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(101, 191);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(62, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "Posicion Y";
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(101, 149);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(100, 23);
            txtPosX.TabIndex = 2;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(101, 228);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(100, 23);
            txtPosY.TabIndex = 3;
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(89, 275);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(129, 23);
            btnCambiarPosicion.TabIndex = 4;
            btnCambiarPosicion.Text = "Cambiar Posicion";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // lblRojo
            // 
            lblRojo.AutoSize = true;
            lblRojo.Location = new Point(367, 128);
            lblRojo.Name = "lblRojo";
            lblRojo.Size = new Size(31, 15);
            lblRojo.TabIndex = 5;
            lblRojo.Text = "Rojo";
            // 
            // lblVerde
            // 
            lblVerde.AutoSize = true;
            lblVerde.Location = new Point(367, 172);
            lblVerde.Name = "lblVerde";
            lblVerde.Size = new Size(36, 15);
            lblVerde.TabIndex = 6;
            lblVerde.Text = "Verde";
            // 
            // lblAzul
            // 
            lblAzul.AutoSize = true;
            lblAzul.Location = new Point(367, 211);
            lblAzul.Name = "lblAzul";
            lblAzul.Size = new Size(30, 15);
            lblAzul.TabIndex = 7;
            lblAzul.Text = "Azul";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(453, 125);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 8;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(453, 164);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 9;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(453, 203);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 10;
            // 
            // btnCambiarFondo
            // 
            btnCambiarFondo.Location = new Point(432, 275);
            btnCambiarFondo.Name = "btnCambiarFondo";
            btnCambiarFondo.Size = new Size(142, 27);
            btnCambiarFondo.TabIndex = 11;
            btnCambiarFondo.Text = "Cambiar Fondo";
            btnCambiarFondo.UseVisualStyleBackColor = true;
            btnCambiarFondo.Click += btnCambiarFondo_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarFondo);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(lblAzul);
            Controls.Add(lblVerde);
            Controls.Add(lblRojo);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox txtPosX;
        private TextBox txtPosY;
        private Button btnCambiarPosicion;
        private Label lblRojo;
        private Label lblVerde;
        private Label lblAzul;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnCambiarFondo;
    }
}