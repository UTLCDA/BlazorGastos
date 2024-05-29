using BlazorGastos.Shared.Entidades;

namespace BlazorGastos.Client.Repositorios
{
    public class Gasto : IGasto
    {
        public List<Ingresos> ObtenerListaIngresos()
        {
            return new List<Ingresos>()
            {
                    new Ingresos { descripcion = "Nomina", monto = 3795.00, fecha = new DateTime(2024, 5, 15), idUsuario =1},
                    new Ingresos { descripcion = "Nomina", monto = 3795.00, fecha = new DateTime(2024, 5, 22), idUsuario =1},
                    new Ingresos { descripcion = "Nomina", monto = 3795.00, fecha = new DateTime(2024, 5, 29), idUsuario =1},
                    new Ingresos { descripcion = "Nomina", monto = 3795.00, fecha = new DateTime(2024, 6, 5), idUsuario =1},
                    new Ingresos { descripcion = "Nomina", monto = 3795.00, fecha = new DateTime(2024, 6, 12), idUsuario =1},
                    new Ingresos { descripcion = "Nomina", monto = 3795.00, fecha = new DateTime(2024, 6, 19), idUsuario =1},
                    new Ingresos { descripcion = "Nomina", monto = 3795.00, fecha = new DateTime(2024, 6, 26), idUsuario =1},
                    new Ingresos { descripcion = "Nomina", monto = 3795.00, fecha = new DateTime(2024, 7, 1), idUsuario =1},
                    new Ingresos { descripcion = "Nomina", monto = 3795.00, fecha = new DateTime(2024, 7, 8), idUsuario =1},
                    new Ingresos { descripcion = "Nomina", monto = 3795.00, fecha = new DateTime(2024, 7, 15), idUsuario =1}
            };
        }
    }
}
