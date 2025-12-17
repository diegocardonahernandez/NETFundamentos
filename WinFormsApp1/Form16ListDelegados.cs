using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form16ListDelegados : Form
    {
        int contador;
        public Form16ListDelegados()
        {
            InitializeComponent();
            this.contador = 0;
            List<Button> botones = new List<Button>();
            //botones.Add(this.button1);
            //botones.Add(this.button2);
            //botones.Add(this.button3);
            //botones.Add(this.button4);
            //botones.Add(this.button5);
            //botones.Add(this.button6);

            foreach(Button boton in botones)
            {
                boton.Click += PulsarBoton; ;
            }

        }

        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador++;
            this.textBox1.Text = contador.ToString();
            ((Button)sender).BackColor = Color.CadetBlue;
        }        
    }
}
