using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        //Queremos almacenar  de forma física a las mascotas en files

        private HelpersFiles helper;
        private string path;

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelpersFiles();
            this.path = "mascotas.txt";
        }

        private void ConvertirMascotasList(string data)
        {
            //Convertir el string del read a list
                //EJ: GARFIELD,GATO@PLUTO,PERRO
            this.Mascotas.Clear();
            //SEPARAMOS CADA MASCOTA CON @
            string[] datosMascota = data.Split('@');
                foreach(string stringMascota in datosMascota)
            {
                //Separamos las propiedades mediande ,
                string [] propiedadades = stringMascota.Split(',');
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedadades[0];
                mascota.Raza= propiedadades[1];

            }

        }

        public async Task ReadMascotasAsync()
        {
                //Leemos el fichero de mascotas
             string data = await this.helper.ReadFileAsync(this.path);
            //Convertimos el string en list
            this.ConvertirMascotasList(data);

        }

        private string ConvertirMascotasString()
        {
            string data = "";
            foreach(Mascota mascota in this.Mascotas)
            {
                //Separamos las propiedades mediante ,
                string propiedades = mascota.Nombre + ", " + mascota.Raza;
                data += propiedades + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }

        public async Task WriteMascotasAsync()
        {
            //Convertimos la colecicon a string
            string data = this.ConvertirMascotasString();
            //Escribimos los datos en file
            await this.helper.WriteFileAsync(this.path, data);
        }

    }
}
