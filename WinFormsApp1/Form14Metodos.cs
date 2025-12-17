using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        int GetDobleValor(int numero)
        {
            return numero * 2;
        }

        private void btnDoble_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            int res = this.GetDobleValor(num);
            this.lblResultado.Text = res.ToString();

        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.LightGoldenrodYellow;
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnDoble);
        }

        void GetDobleReferencia(ref int numero)
        {
            numero = numero + 2;
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDobleReferencia(ref num);
            this.lblResultado.Text = num.ToString();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = $"X {e.X}, Y {e.Y}";
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;

            if(char.IsDigit(e.KeyChar)== false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;

            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
