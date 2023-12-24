﻿using Microsoft.JSInterop;

namespace PruebaIngresoFMP.Client.Helpers
{
    public static class IJSExtensions
    {
        public static ValueTask<object> GuardarComo(this IJSRuntime js, string nombreArchivo, byte[] archivo)
        {
            return js.InvokeAsync<object>("saveAsFile",
                nombreArchivo,
                Convert.ToBase64String(archivo));
        }
    }
}
