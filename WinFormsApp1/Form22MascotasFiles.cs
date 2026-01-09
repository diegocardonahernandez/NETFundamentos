using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Helpers;
using ProyectoClases.Models;

namespace WinFormsApp1
{
    public partial class Form22MascotasFiles : Form
    {

        HelperMascotas helper;

        private void DibujarMascota()
        {
            this.lstMascotas.Items.Clear();

            foreach (var m in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(m.Nombre);
            }
        }
        public Form22MascotasFiles()
        {
            InitializeComponent();
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombreMascota.Text;
            mascota.Raza = this.txtRazaMascota.Text;
            this.helper.Mascotas.Add(mascota);


        }
        private async Task btnWrite_Click(object sender, EventArgs e)
        {
            await this.helper.WriteMascotasAsync();
            this.lstMascotas.Items.Clear();

        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            await this.helper.ReadMascotasAsync();
            this.DibujarMascota();
        }
    }
}
