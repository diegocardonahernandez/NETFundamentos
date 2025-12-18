using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<TextBox> textos;
        List<Button> botones;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();

            this.textos = new List<TextBox>();
            this.botones = new List<Button>();

                foreach(Control control in this.Controls)
            {
                if(control is Button)
                {
                    botones.Add((Button)control);
                    control.Click += showTabla;
                }else if(control is TextBox)
                {
                    textos.Add((TextBox)control);
                }
            }

            textos.Reverse();

        }

        private void showTabla(object? sender, EventArgs e)
        {
            int numCajas = textos.Count();
            Button numPulsado = (Button)sender;
            int num = int.Parse(numPulsado.Text);

          for(int i =0; i < this.textos.Count; i++)
            {
                this.textos[i].Text = (num * (i + 1)).ToString();
            }

        }
    }
}
