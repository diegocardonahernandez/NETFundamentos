using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            isbn.Trim();
            int resSumaMultiplicaciones = 0;
            int resMultiplicacion = 0;

            if(isbn.Length < 10)
            {
                this.lblResultado.Text = "El ISBN debe contener almenos 10 caracteres";
            }

            else
            {
                for (int i = 0; i < isbn.Length; i++)
                {
                    char currentCaracter = isbn[i];
                    int caracter = int.Parse(currentCaracter.ToString());
                    resMultiplicacion = caracter * (i +1);
                    resSumaMultiplicaciones += resMultiplicacion;

                    int res = resSumaMultiplicaciones % 11;

                        if(res == 0)
                    {
                        this.lblResultado.Text = "ISBN Correcto !";
                    }
                    else
                    {
                        this.lblResultado.Text = "El ISBN Indicado es incorrecto";
                    }

                }
            }

        }
    }
}
