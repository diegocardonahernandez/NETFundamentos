using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelpersFiles
    {
        //Necestiamos dos métodos: Leer y escribir
        //Los métodos deben ser asíncronos
        //En los métodos de clase no gráfica debemos utilizar la clase TASK para metodos asyncronos
           //NO se utiliza VOID
                //Si es un void, se utliza task
                //Si es un return, utilizamos Task<Clasereturn>

        public async Task WriteFileAsync(string path, string content)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(content);
                await writer.FlushAsync();
                writer.Close();
            }
        }

        public async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            using(TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }

    }
}
