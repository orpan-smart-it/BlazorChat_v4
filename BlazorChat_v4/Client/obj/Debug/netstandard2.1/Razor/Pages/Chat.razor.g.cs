#pragma checksum "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a80506af786afe444d1852dfd47138f414008288"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Users\orpan\source\repos\BlazorChat_v4\BlazorChat_v4\Client\Pages\Chat.razor"
using BlazorChat_v4.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat/selectedContact.ContactId")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"col-12\">\r\n   \r\n\r\n\r\n</div>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div style=""border:0px;height:90vh;"">
    <div class=""panel panel-primary"" style=""height:100%;"">
        <div class=""panel-heading top-bar"">
            <div class=""col-md-8 col-xs-8"">
                <h3 class=""panel-title"">
            
                </h3>
            </div>
        </div>
        <div id=""divMessageContainerBase"" class=""panel-body msg_container_base"">

        </div>
        
        <div class=""panel-footer"">
            <div class=""input-group"" id=""myForm"">
                <input id=""txtMessageInput"" type=""text"" class=""form-control input-sm chat_input"" placeholder=""Write your message here..."">
            </div>
        </div>

    </div>
    
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactListBase ContactListBase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
