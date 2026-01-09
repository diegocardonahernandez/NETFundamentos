using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace WinFormsApp1
{
    public partial class Form21Files : Form
    {
        public string Path { get; set; }
        HelpersFiles helper;

        public Form21Files()
        {
            InitializeComponent();

            this.Path = "file1.txt";

        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNuevoNombre.Text);
            this.txtNuevoNombre.SelectAll();
            this.txtNuevoNombre.Focus();
        }

        private async void btnEscribir_Click(object sender, EventArgs e)
        {
            string content = this.GetNombresLista();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Datos almacenados");

        }

        public string GetNombresLista()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + " ";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            string content = await this.helper.ReadFileAsync(this.Path);
            this.txtContenido.Text = content;
            string[] nombres = content.Split(',');
            this.lstNombres.Items.Clear();
            foreach(string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }
    }
}
