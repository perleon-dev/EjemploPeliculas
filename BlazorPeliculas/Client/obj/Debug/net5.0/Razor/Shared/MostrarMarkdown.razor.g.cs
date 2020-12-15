#pragma checksum "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Shared\MostrarMarkdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de834e85c98613435bc76e9ca641f335ab75d949"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Shared
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
#nullable restore
#line 1 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Shared\MostrarMarkdown.razor"
using Markdig;

#line default
#line hidden
#nullable disable
    public partial class MostrarMarkdown : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Shared\MostrarMarkdown.razor"
 if (string.IsNullOrEmpty(ContenidoHTML))
{
    if (PlantillaCarga != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Shared\MostrarMarkdown.razor"
         PlantillaCarga

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Shared\MostrarMarkdown.razor"
                       
    }
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 12 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Shared\MostrarMarkdown.razor"
      (MarkupString)ContenidoHTML

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 12 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Shared\MostrarMarkdown.razor"
                                  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Aplicaciones\net Core\BlazorPeliculas-6\BlazorPeliculas\Client\Shared\MostrarMarkdown.razor"
       
    [Parameter] public string ContenidoMarkdown { get; set; }
    [Parameter] public RenderFragment PlantillaCarga { get; set; }
    private string ContenidoHTML;

    protected override void OnParametersSet()
    {
        if (ContenidoMarkdown != null)
        {
            ContenidoHTML = Markdown.ToHtml(ContenidoMarkdown);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
