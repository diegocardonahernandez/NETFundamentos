using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    public interface IFactura
    {
        //Solo tiebe estructura de declaración de elemenntos
        int PrecioBase { get; set; }
        int PrecioTotal { get; set; }
        void CalculaIva() {}
        void OdioHacienda(int mucho) { }
    }
}
