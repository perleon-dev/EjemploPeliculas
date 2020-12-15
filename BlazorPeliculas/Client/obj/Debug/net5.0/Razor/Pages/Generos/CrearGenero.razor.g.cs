#pragma checksum "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Pages\Generos\CrearGenero.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "383b3f7c7d4695dd0a448bc5794988513ce74d90"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Pages.Generos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/generos/crear")]
    public partial class CrearGenero : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Crear Genero</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorPeliculas.Client.Pages.Generos.FormularioGenero>(1);
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Pages\Generos\CrearGenero.razor"
                                 Crear

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Genero", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorPeliculas.Shared.Entidades.Genero>(
#nullable restore
#line 8 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Pages\Generos\CrearGenero.razor"
                                                Genero

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Pages\Generos\CrearGenero.razor"
        private Genero Genero = new Genero();

    private async Task Crear()
    {
        var httpResponse = await repositorio.Post("api/generos", Genero);

        if (httpResponse.Error)
        {
            var body = await httpResponse.GetBody();
            await mostrarMensajes.MostrarMensajeError(body);
        }
        else
        {
            navigationManager.NavigateTo("/generos");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
