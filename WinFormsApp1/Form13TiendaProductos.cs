using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.listProductos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            string nuevoProducto = this.txtNuevoProducto.Text;

            if (!this.listProductos.Items.Contains(nuevoProducto))
            {
                this.listProductos.Items.Add(nuevoProducto);
            }
            else
            {
                MessageBox.Show("EL Producto ya ha sido añadido");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numElementos = this.listProductos.SelectedItems.Count - 1;

            for (int i = numElementos; i >= 0; i--)
            {
                int index = this.listProductos.SelectedIndices[i];
                this.listProductos.Items.RemoveAt(index);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.listProductos.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {

            int numElementos = this.listProductos.SelectedItems.Count - 1;

            foreach (string selectedItem in this.listProductos.SelectedItems)
            {
                this.listAlmacen.Items.Add(selectedItem);
            }

            for (int i = numElementos; i >= 0; i--)
            {
                int index = this.listProductos.SelectedIndices[i];
                this.listProductos.Items.RemoveAt(index);
            }

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (string item in this.listProductos.Items)
            {
                this.listAlmacen.Items.Add(item);
            }

            this.listProductos.Items.Clear();
        }
    }
}
