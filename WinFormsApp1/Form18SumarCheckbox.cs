using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> cajas;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.cajas = new List<CheckBox>();

            foreach (CheckBox caja in this.panel.Controls)
            {
                this.cajas.Add(caja);
                caja.Click += SumarValor;
            }
        }

        private void SumarValor(object? sender, EventArgs e)
        {
            CheckBox cajaPulsada = (CheckBox)sender;
            int valor = int.Parse(cajaPulsada.Text);
            int suma = int.Parse(this.txtSuma.Text);

            if (cajaPulsada.Checked)
            {            
                suma += valor;
                this.txtSuma.Text = suma.ToString();
            }
            else
            {
                suma -= valor;
                this.txtSuma.Text = suma.ToString();

            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            foreach(CheckBox c in cajas)
            {
                int aleatorio = random.Next(1, 50);
                c.Text = aleatorio.ToString();
            }
        }
    }
}
