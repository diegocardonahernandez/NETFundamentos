namespace WinFormsApp1
{
    partial class Form20TestClases
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
            btnCrearPersona = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            btnEmpleado = new Button();
            btnDirector = new Button();
            SuspendLayout();
            // 
            // btnCrearPersona
            // 
            btnCrearPersona.Location = new Point(65, 357);
            btnCrearPersona.Name = "btnCrearPersona";
            btnCrearPersona.Size = new Size(179, 29);
            btnCrearPersona.TabIndex = 0;
            btnCrearPersona.Text = "Crear Persona";
            btnCrearPersona.UseVisualStyleBackColor = true;
            btnCrearPersona.Click += btnCrearPersona_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 35);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Crear Persona";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(60, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(641, 264);
            listBox1.TabIndex = 2;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(250, 357);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(160, 29);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnDirector
            // 
            btnDirector.Location = new Point(416, 357);
            btnDirector.Name = "btnDirector";
            btnDirector.Size = new Size(141, 29);
            btnDirector.TabIndex = 4;
            btnDirector.Text = "Director";
            btnDirector.UseVisualStyleBackColor = true;
            btnDirector.Click += btnDirector_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDirector);
            Controls.Add(btnEmpleado);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(btnCrearPersona);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearPersona;
        private Label label1;
        private ListBox listBox1;
        private Button btnEmpleado;
        private Button btnDirector;
    }
}