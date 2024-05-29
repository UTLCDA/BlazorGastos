using Microsoft.AspNetCore.Components;

namespace BlazorGastos.Client.Pages
{
    public partial class Counter
    {

        [Inject] ServiciosSingleton variableSingleton { get; set; } = null!;
        [Inject] ServiciosTransient variableTransient { get; set; } = null!;

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount += 2;
            variableSingleton.Valor = currentCount;
            variableTransient.Valor = currentCount;
        }
    }
}
