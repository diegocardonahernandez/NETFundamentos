namespace WinFormsApp1
{
    partial class Form01SumarNumeros
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
            btnSumar = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            lblRes = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.BackColor = SystemColors.Highlight;
            btnSumar.Location = new Point(434, 170);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(193, 55);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(54, 62);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "label1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(54, 130);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(38, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "label2";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(54, 92);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 3;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(54, 170);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 4;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Location = new Point(54, 229);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(38, 15);
            lblRes.TabIndex = 5;
            lblRes.Text = "label1";
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRes);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnSumar);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Label lbl1;
        private Label lbl2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label lblRes;
    }
}