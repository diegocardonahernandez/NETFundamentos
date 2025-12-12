using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtPosX.Text);
            int y = int.Parse(this.txtPosY.Text);

            this.btnCambiarPosicion.Location = new Point(x, y);
        }

        private void btnCambiarFondo_Click(object sender, EventArgs e)
        {
            int color1 = int.Parse(this.txtRojo.Text);
            int color2 = int.Parse(this.txtVerde.Text);
            int color3 = int.Parse(this.txtAzul.Text);

            this.BackColor = Color.FromArgb(color1, color2, color3);


        }
    }
}
