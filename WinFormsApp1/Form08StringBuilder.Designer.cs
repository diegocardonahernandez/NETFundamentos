namespace WinFormsApp1
{
    partial class Form08StringBuilder
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
            txt = new RichTextBox();
            lblTiempo = new Label();
            btnInvertir = new Button();
            btnInvertirBuilder = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(325, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(137, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Copie texto para trabajar";
            // 
            // txt
            // 
            txt.Location = new Point(23, 65);
            txt.Name = "txt";
            txt.Size = new Size(745, 258);
            txt.TabIndex = 1;
            txt.Text = "";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(23, 355);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(60, 15);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "lblTiempo";
            // 
            // btnInvertir
            // 
            btnInvertir.Location = new Point(264, 347);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(131, 23);
            btnInvertir.TabIndex = 3;
            btnInvertir.Text = "Invertir String";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // btnInvertirBuilder
            // 
            btnInvertirBuilder.Location = new Point(447, 347);
            btnInvertirBuilder.Name = "btnInvertirBuilder";
            btnInvertirBuilder.Size = new Size(131, 23);
            btnInvertirBuilder.TabIndex = 4;
            btnInvertirBuilder.Text = "Invertir StringBuilder";
            btnInvertirBuilder.UseVisualStyleBackColor = true;
            btnInvertirBuilder.Click += btnInvertirBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInvertirBuilder);
            Controls.Add(btnInvertir);
            Controls.Add(lblTiempo);
            Controls.Add(txt);
            Controls.Add(lblTitulo);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private RichTextBox txt;
        private Label lblTiempo;
        private Button btnInvertir;
        private Button btnInvertirBuilder;
    }
}