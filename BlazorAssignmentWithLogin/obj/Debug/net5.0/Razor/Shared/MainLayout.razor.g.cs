#pragma checksum "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49901609f64beeac6cdb41178602a7a23a8b0902"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginExample.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\Shared\MainLayout.razor"
using LoginComponent;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<LoginExample.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "top-row px-4");
            __builder.OpenComponent<LoginComponent.Login>(8);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddContent(12, 
#nullable restore
#line 16 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\Shared\MainLayout.razor"
       

    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        var user = (await AuthStat).User;
        if(!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/Login");
            // NavigationManager.NavigateTo($"/Login?returnUrl={Uri.EscapeDataString(NavigationManager.Uri)}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
