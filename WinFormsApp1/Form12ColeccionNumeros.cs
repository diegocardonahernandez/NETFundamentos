using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.listElementos.Items.Clear();

            for (int i = 1; i < 10; i++)
            {
                Random random = new Random();
                string numRandom = random.Next(1, 50).ToString();
                this.listElementos.Items.Add(numRandom);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int sumaNumeros = 0;
            int sumaPares = 0;
            int sumaImpares = 0;

            foreach(string numero in this.listElementos.Items)
            {
                int currentNum = int.Parse(numero.ToString());
                sumaNumeros += currentNum;

                if(currentNum % 2 == 0)
                {
                    sumaPares += currentNum;
                }
                else
                {
                    sumaImpares += currentNum;
                }

            }
            this.txtSumar.Text = sumaNumeros.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
             
        }
    }
}
