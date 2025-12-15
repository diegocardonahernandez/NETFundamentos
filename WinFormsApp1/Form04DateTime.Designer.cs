namespace WinFormsApp1
{
    partial class Form04DateTime
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
            lblFecha = new Label();
            txtFechaActual = new TextBox();
            chkFormarto = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnios = new RadioButton();
            lblIncremento = new Label();
            txtIncremento = new TextBox();
            btnIncremento = new Button();
            lblFechaFinal = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(53, 28);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(75, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(53, 63);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(219, 23);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFormarto
            // 
            chkFormarto.AutoSize = true;
            chkFormarto.Location = new Point(53, 114);
            chkFormarto.Name = "chkFormarto";
            chkFormarto.Size = new Size(119, 19);
            chkFormarto.TabIndex = 2;
            chkFormarto.Text = "Cambiar Formato";
            chkFormarto.UseVisualStyleBackColor = true;
            chkFormarto.CheckedChanged += chkFormarto_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(53, 155);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(53, 197);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnios
            // 
            rdbAnios.AutoSize = true;
            rdbAnios.Location = new Point(53, 241);
            rdbAnios.Name = "rdbAnios";
            rdbAnios.Size = new Size(52, 19);
            rdbAnios.TabIndex = 5;
            rdbAnios.TabStop = true;
            rdbAnios.Text = "Años";
            rdbAnios.UseVisualStyleBackColor = true;
            // 
            // lblIncremento
            // 
            lblIncremento.AutoSize = true;
            lblIncremento.Location = new Point(377, 57);
            lblIncremento.Name = "lblIncremento";
            lblIncremento.Size = new Size(68, 15);
            lblIncremento.TabIndex = 6;
            lblIncremento.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(478, 49);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 7;
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(377, 101);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(201, 23);
            btnIncremento.TabIndex = 8;
            btnIncremento.Text = "Incrementar";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Location = new Point(377, 160);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(66, 15);
            lblFechaFinal.TabIndex = 9;
            lblFechaFinal.Text = "Fecha FInal";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(377, 197);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(201, 23);
            txtFechaFinal.TabIndex = 10;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFechaFinal);
            Controls.Add(lblFechaFinal);
            Controls.Add(btnIncremento);
            Controls.Add(txtIncremento);
            Controls.Add(lblIncremento);
            Controls.Add(rdbAnios);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(chkFormarto);
            Controls.Add(txtFechaActual);
            Controls.Add(lblFecha);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private TextBox txtFechaActual;
        private CheckBox chkFormarto;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnios;
        private Label lblIncremento;
        private TextBox txtIncremento;
        private Button btnIncremento;
        private Label lblFechaFinal;
        private TextBox txtFechaFinal;
    }
}