// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LoginComponent
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
#line 3 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\Pages\Login.razor"
using LoginExample.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\alin\Desktop\BlazorAssignmentWithLogin\BlazorAssignmentWithLogin-main\BlazorAssignmentWithLogin-main\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin() {
        errorMessage = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
        } catch (Exception e) {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout() {
        errorMessage = "";
        username = "";
        password = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        } catch (Exception e) { }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
