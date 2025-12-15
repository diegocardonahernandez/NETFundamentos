using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anio = int.Parse(this.txtAnio.Text);

            if(mes == 1)
            {
                mes = 13;
                anio = anio - 1;
            }else if(mes == 2)
            {
                mes = 14;
                anio = anio - 1;
            }

            int res1 = ((mes + 1) * 3) / 5;
            int res2 = anio / 4;
            int res3 = anio / 100;
            int res4 = anio / 400;

            int res5 = dia + (mes * 2) + anio + res1 + res2 - res3 + res4 + 2;

            int res6 = res5 / 7;
            int resultado = res5 - (res6 * 7);

            string textodia = "";

            if (resultado == 0)
            {
                textodia = "Sabado";
            }

            else if (resultado == 1)
            {
                textodia = "Domingo";
            }

            else if (resultado == 2)
            {
                textodia = "Lunes";
            }

            else if (resultado == 3)
            {
                textodia = "Martes";
            }

            else if (resultado == 4)
            {
                textodia = "Miercoles";
            }

            else if (resultado == 5)
            {
                textodia = "Jueves";
            }

            else if (resultado == 6)
            {
                textodia = "Viernes";
            }

            else
            {
                textodia = "No es correcto";
            }
            this.lblDiaResultado.Text = "El Día Es: " + textodia;
        }
    }
}
