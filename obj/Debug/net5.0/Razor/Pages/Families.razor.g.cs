#pragma checksum "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2941bef5f18597fca7c0b13964f87e9f9551ea07"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssignment1FamilyManagementSystem.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using DNPAssignment1FamilyManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\_Imports.razor"
using DNPAssignment1FamilyManagementSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
using DNPAssignment1FamilyManagementSystem.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Families")]
    public partial class Families : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h3 b-2chmzdkc7s>Families</h3>");
#nullable restore
#line 9 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
         if (_families is null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(3, "<p b-2chmzdkc7s><em b-2chmzdkc7s>Loading...</em></p>");
#nullable restore
#line 14 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
        }
        else if (!_families.Any())
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(4, "<p b-2chmzdkc7s><em b-2chmzdkc7s>No Families has been created yet.</em></p>");
#nullable restore
#line 20 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table");
                __builder2.AddAttribute(7, "b-2chmzdkc7s");
                __builder2.AddMarkupContent(8, "<thead b-2chmzdkc7s><tr b-2chmzdkc7s><th b-2chmzdkc7s></th>\r\n                    <th b-2chmzdkc7s>Street Name</th>\r\n                    <th b-2chmzdkc7s>House No</th>\r\n                    <th b-2chmzdkc7s>Member Count</th></tr></thead>\r\n                ");
                __builder2.OpenElement(9, "tbody");
                __builder2.AddAttribute(10, "b-2chmzdkc7s");
#nullable restore
#line 33 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                 foreach (var f in _families)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(11, "tr");
                __builder2.AddAttribute(12, "b-2chmzdkc7s");
                __builder2.AddMarkupContent(13, "<td b-2chmzdkc7s><span class=\"oi oi-collapse-down\" b-2chmzdkc7s></span></td>\r\n                        ");
                __builder2.OpenElement(14, "td");
                __builder2.AddAttribute(15, "b-2chmzdkc7s");
                __builder2.AddContent(16, 
#nullable restore
#line 37 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                             f.StreetName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                        ");
                __builder2.OpenElement(18, "td");
                __builder2.AddAttribute(19, "b-2chmzdkc7s");
                __builder2.AddContent(20, 
#nullable restore
#line 38 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                             f.HouseNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "td");
                __builder2.AddAttribute(23, "b-2chmzdkc7s");
                __builder2.AddContent(24, 
#nullable restore
#line 39 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                             f.Adults.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(25, " Adults; ");
                __builder2.AddContent(26, 
#nullable restore
#line 39 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                                     f.Children.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(27, " Children; ");
                __builder2.AddContent(28, 
#nullable restore
#line 39 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                                                                                 f.Pets.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(29, " Pets");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 41 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 44 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Pages\Families.razor"
       
    private IList<Family> _families;

    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }


    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo("/Login");
        }
        else
        {
            _families = FamilyService.GetFamilies();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
