// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Registro1_Ap2.Pages.Registro
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using Registro1_Ap2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using Registro1_Ap2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\Pages\Registro\RPersonas.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\Pages\Registro\RPersonas.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Personas")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Personas/{PersonaId:int}")]
    public partial class RPersonas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Lina\Desktop\APLICADA II\Registro1_Ap2\Pages\Registro\RPersonas.razor"
 
    

    [Parameter]
    public int PersonaId { get; set; }

    private Personas persona = new Personas();
    //private Personas persona = new Personas();

    protected override void OnInitialized()
    {
        Nuevo();
        //@* persona.FechaNacimiento = DateTime.Now;*@
        Buscar();
    }

    private void Nuevo()
    {
        persona = new Personas();
        //persona.FechaNacimiento = DateTime.Now;
    }

    private void Guardar()
    {
         bool guardado;

        guardado = PersonasBLL.Guardar(persona);

        if (guardado)
        {
            Nuevo();
            toast.ShowSuccess("Guardado correctamente");
        }
        else
            toast.ShowError("No fue posible guardar");
    }

    private void Buscar()
    {
         if (persona.PersonaId > 0)
         {
             var encontrado = PersonasBLL.Buscar(persona.PersonaId);
             if (encontrado != null)
                 persona = encontrado;
             else
                 toast.ShowWarning("La persona no fue encontrado");
         }       
    }

    private void Eliminar()
    {
        bool elimino;

        elimino = PersonasBLL.Eliminar(persona.PersonaId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Persona eliminada correctamente");
        }
        else
            toast.ShowError("No fue posible eliminarla persona");     
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591