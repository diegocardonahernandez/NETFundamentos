using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor Director");
            this.SalarioMinimo += 200;
        }

        public override int GetDiasVacaciones()
        {
            int vacasEmplpeado = base.GetDiasVacaciones();
            Debug.WriteLine("GetVacaciones() Director");
            return vacasEmplpeado + 8;
        }
    }
}
