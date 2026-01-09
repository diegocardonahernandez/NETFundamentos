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
    public partial class Form23ObjetoMascotalXML : Form
    {
        XmlSerializer serializer;

        string rutaImagen;
        public Form23ObjetoMascotalXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);
            mascota.Imagen = ImagenABytes(this.pictureBox1.Image);

            //Las clasesque utilizn son tipo stream
            //Para escribir necesitamos la clase StreamWriter
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
                   }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
            this.pictureBox1.Image = null;

        }

        private void btnLeerClase_Click(object sender, EventArgs e)
        {

            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Edad.ToString();
                this.pictureBox1.Image = BytesAImagen(mascota.Imagen);
            }
        }

        private byte[] ImagenABytes(Image imagen)
        {
            if (imagen == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, imagen.RawFormat);
                return ms.ToArray();
            }
        }

        private Image BytesAImagen(byte[] bytes)
        {
            if (bytes == null) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void btnSelecImagen_Click(object sender, EventArgs e)
        {
            //Abir el openfile para seleccionar la imagen
            this.openFileDialog1.ShowDialog();
            //Recuperamos la ruta de la imagen
            this.rutaImagen = this.openFileDialog1.FileName;
            //Dibujamos la imagen en el form
            this.pictureBox1.Image = Image.FromFile(this.rutaImagen);
        }
    }
}
