#pragma checksum "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\Pages\Contacts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f806cb4bc38ca28a3684f7cdf25393baa8a676"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorChat_v4.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\_Imports.razor"
using BlazorChat_v4.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\_Imports.razor"
using BlazorChat_v4.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\_Imports.razor"
using RazorClassLibrary1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\Pages\Contacts.razor"
using BlazorChat_v4.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contacts")]
    public partial class Contacts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\Pages\Contacts.razor"
       
    private List<Contact> ContactList { get; set; } = new List<Contact>();

    protected override async Task OnInitializedAsync()
    {
     
       ContactList.Add(new Contact(0, "Nick", "Bondarev"));
        ContactList.Add(new Contact(1, "Michele", "Sergeeva"));
        ContactList.Add(new Contact(2, "Denis", "Semenets"));

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
