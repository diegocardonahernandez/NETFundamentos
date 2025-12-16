using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            this.listElemetnos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.listElemetnos.Items.Add(elem);
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";

            for (int i = 0; i < this.listElemetnos.Items.Count; i++)
            {
                object cosa = this.listElemetnos.Items[i];
                string texto = cosa.ToString();
            }

            foreach (string item in this.listElemetnos.SelectedItems)
            {
                items += item + ",";
            }

            foreach (int index in this.listElemetnos.SelectedIndices)
            {
                indices += index + ",";
            }

            this.lblIndex.Text = indices.Trim(',');
            this.lblItem.Text = items.Trim(',');

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numElementos = this.listElemetnos.SelectedIndices.Count - 1;

            for(int i = numElementos; i >= 0; i--)
            {
                int index = this.listElemetnos.SelectedIndices[i];
                this.listElemetnos.Items.RemoveAt(index);
            }
        }   

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.listElemetnos.Items.Clear();
        }
    }
}
