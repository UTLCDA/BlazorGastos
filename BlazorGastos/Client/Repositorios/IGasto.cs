using BlazorGastos.Shared.Entidades;

namespace BlazorGastos.Client.Repositorios
{
    public interface IGasto
    {
        List<Ingresos> ObtenerListaIngresos();
    }
}
