namespace WinFormsApp1
{
    partial class Form22MascotasFiles
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
            txtNombreMascota = new TextBox();
            txtRazaMascota = new TextBox();
            label2 = new Label();
            btnNuevaMascota = new Button();
            btnRead = new Button();
            btnWrite = new Button();
            label3 = new Label();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombreMascota
            // 
            txtNombreMascota.Location = new Point(47, 79);
            txtNombreMascota.Name = "txtNombreMascota";
            txtNombreMascota.Size = new Size(125, 23);
            txtNombreMascota.TabIndex = 1;
            // 
            // txtRazaMascota
            // 
            txtRazaMascota.Location = new Point(47, 167);
            txtRazaMascota.Name = "txtRazaMascota";
            txtRazaMascota.Size = new Size(125, 23);
            txtRazaMascota.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 132);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(47, 222);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(125, 23);
            btnNuevaMascota.TabIndex = 4;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(47, 261);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(125, 23);
            btnRead.TabIndex = 5;
            btnRead.Text = "Read File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(47, 302);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(125, 23);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 43);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(333, 79);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(227, 244);
            lstMascotas.TabIndex = 8;
            // 
            // Form22MascotasFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 373);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtRazaMascota);
            Controls.Add(label2);
            Controls.Add(txtNombreMascota);
            Controls.Add(label1);
            Name = "Form22MascotasFiles";
            Text = "Form22MascotasFiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreMascota;
        private TextBox txtRazaMascota;
        private Label label2;
        private Button btnNuevaMascota;
        private Button btnRead;
        private Button btnWrite;
        private Label label3;
        private ListBox lstMascotas;
    }
}