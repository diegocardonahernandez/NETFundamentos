namespace WinFormsApp1
{
    partial class Form17SumarBotones
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
            lblSuma = new Label();
            txtSuma = new TextBox();
            btnIniciarApp = new Button();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(212, 49);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(37, 15);
            lblSuma.TabIndex = 0;
            lblSuma.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(321, 46);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 1;
            txtSuma.Text = "0";
            // 
            // btnIniciarApp
            // 
            btnIniciarApp.Location = new Point(474, 46);
            btnIniciarApp.Name = "btnIniciarApp";
            btnIniciarApp.Size = new Size(96, 25);
            btnIniciarApp.TabIndex = 2;
            btnIniciarApp.Text = "Iniciar App";
            btnIniciarApp.UseVisualStyleBackColor = true;
            btnIniciarApp.Click += btnIniciarApp_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(212, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 113);
            panel1.TabIndex = 3;
            // 
            // button8
            // 
            button8.Location = new Point(280, 57);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(280, 15);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(199, 57);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(109, 57);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(16, 57);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(199, 15);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(109, 15);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(16, 15);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form17SumarBotones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnIniciarApp);
            Controls.Add(txtSuma);
            Controls.Add(lblSuma);
            Name = "Form17SumarBotones";
            Text = "Form17SumarBotones";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSuma;
        private TextBox txtSuma;
        private Button btnIniciarApp;
        private Panel panel1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}