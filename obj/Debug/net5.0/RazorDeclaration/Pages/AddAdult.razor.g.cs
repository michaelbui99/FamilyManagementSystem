// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNPAssignment1FamilyManagementSystem.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using DNPAssignment1FamilyManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using DNPAssignment1FamilyManagementSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
using DNPAssignment1FamilyManagementSystem.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult/{StreetName}/{HouseNumber:int}")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Pages\AddAdult.razor"
       

    [Parameter]
    public string StreetName { get; set; }

    [Parameter]
    public int HouseNumber { get; set; }

    private Adult _newAdult = new Adult() {JobTitle = new Job()};

    private string _selectedSex;


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
    }

    private void AddAdultToFamily()
    {
        Family familyOfAdult = FamilyService.GetFamily(StreetName, HouseNumber);
        _newAdult.Sex = _selectedSex;
        FamilyService.AddAdultToFamily(familyOfAdult, _newAdult);
        NavigationManager.NavigateTo("/Families");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
