using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado: Persona
    {

        protected int SalarioMinimo { get; set; }

        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 30;
        }
        public Empleado()
        {
            Debug.WriteLine("Contructor Empleado vacío");
            this.SalarioMinimo = 1600;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        public Empleado(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor Empleado con dos parámetros");
        }
    }
}
