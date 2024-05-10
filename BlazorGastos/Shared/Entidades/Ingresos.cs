using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorGastos.Shared.Entidades
{
    public class Ingresos
    {
        //public int id { get; set; } Como es 1,1 no se agrega
        public string descripcion { get; set; } = null!;
        public double monto { get; set; }
        public DateTime fecha { get; set; }
        public int idUsuario { get; set; }
    }
}
