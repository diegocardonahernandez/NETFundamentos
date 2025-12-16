using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.listElemetnos.Items.Add(elem);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.listElemetnos.SelectedIndex;
            this.listElemetnos.Items.RemoveAt(index);

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.listElemetnos.Items.Clear();
        }

        private void listElemetnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listElemetnos.SelectedIndex != -1)
            {
                this.lblIndex.Text = this.listElemetnos.SelectedIndex.ToString();
                this.lblItem.Text = this.listElemetnos.SelectedItem.ToString();
            }
        }
    }
}
