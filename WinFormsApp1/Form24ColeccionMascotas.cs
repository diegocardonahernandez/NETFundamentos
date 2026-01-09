using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class Form24ColeccionMascotas : Form
    {
        XmlSerializer serializer;
        ColeccionMascotas mascotaslist;
        public Form24ColeccionMascotas()
        {
            InitializeComponent();

            this.serializer = new XmlSerializer(typeof(ColeccionMascotas));
            this.mascotaslist = new ColeccionMascotas();
        }

        public void DibujarMascota()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.mascotaslist)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);
            this.mascotaslist.Add(mascota);
            this.DibujarMascota();
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
        }

        private void btnLeerMascotas_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("listamascotas.xml"))
            {
                this.mascotaslist = (ColeccionMascotas)
                    this.serializer.Deserialize(reader);
                reader.Close();
                this.DibujarMascota();
            }
        }

        private async void btnGuardarMascotas_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("listamascotas.xml"))
            {
                this.serializer.Serialize(writer, this.mascotaslist);
                await writer.FlushAsync();
                writer.Close();
                this.lstMascotas.Items.Clear();
                this.mascotaslist.Clear();
            }

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //Abir el openfile para seleccionar la imagen
            this.openFileDialog1.ShowDialog();
            //Recuperamos la ruta de la imagen
            string path = this.openFileDialog1.FileName;
            //Dibujamos la imagen en el form
            this.pictureBox1.Image = Image.FromFile(path);
        }
    }
}
