using Microsoft.JSInterop;

namespace BlazorGastos.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        // metodo asyncrono que nos permite mandar llamar en funciones JS en todo el proyecto
        public static async ValueTask<bool> Confirmar(this IJSRuntime js, string mensaje)
        {
            return await js.InvokeAsync<bool>("confirm", mensaje);
        }
    }
}
