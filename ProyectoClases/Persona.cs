using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    #region Enumeraciones
    //Las enumeraciones están dentro del namespace
    public enum TipoGenero { Masculino = 0, Femenino = 1};
    public enum Paises { Espana, Francia, Alemania, Andorra, Colombia}

    #endregion
    public class Persona
    {

        #region Constructor
        public Persona()
        {
            Debug.WriteLine("Contructor persona Vacío");
        }

        //public Persona(string nombre, string apellidos)
        //{
        //    this.Nombre = nombre;
        //    this.Apellidos = apellidos;
        //    Debug.WriteLine("Constructor Persona con dos parámetros");
        //}

        #endregion

        #region Propiedades

        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set { Random random = new Random();
                int dato = random.Next(1, 0);
                this._DescripcionThis = "Descripcion " + dato;
            } 
        }

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        public TipoGenero _Genero;

        public TipoGenero Genero
            {
                get { return this._Genero; }
           set
           {
                if (value != TipoGenero.Femenino &&
                    value != TipoGenero.Masculino)
                {
                    throw new Exception("Donde vas, listo...");
                }
                    
            }
           }
        public Paises Nacionalidad { get; set;}


        public string Nombre;
        public string Apellidos;

        //Campo de propiedad
        private int _Edad;
        public int Edad {
            //Devolvemos el valor
            get { return this._Edad; }

            //Establecemos el valor
            //PROGRAMADOR: persona.Edad = -25;
            set {
                    
                if(value < 0)
                {
                    //No nos gusta? Lo solcionamos en silencio;
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }

            }
        }

        #endregion

        #region Metodos

        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }

        public string GetNombreCompleto(int num1)
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }

        public string GetNombreCompleto(int num1, int num2)
        {
            return (this.Nombre + " " + this.Apellidos).ToLower();
        }

        public void GetNombreCompleto(string dato)
        {

        }

        #endregion

    }
}
