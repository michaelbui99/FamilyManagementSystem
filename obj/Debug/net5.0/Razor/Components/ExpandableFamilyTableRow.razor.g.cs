#pragma checksum "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2925c861baa48038ebc71e7faf7611955e6721d9"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssignment1FamilyManagementSystem.Components
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
#line 1 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
using DNPAssignment1FamilyManagementSystem.Data;

#line default
#line hidden
#nullable disable
    public partial class ExpandableFamilyTableRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
 if (Family != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "tr");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
                   ExpandView

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "b-3xlak414es");
            __builder.OpenElement(3, "td");
            __builder.AddAttribute(4, "b-3xlak414es");
            __builder.OpenElement(5, "span");
            __builder.AddAttribute(6, "class", 
#nullable restore
#line 9 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
                      iconClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "b-3xlak414es");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "td");
            __builder.AddAttribute(10, "b-3xlak414es");
            __builder.AddContent(11, 
#nullable restore
#line 11 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
         Family.StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "td");
            __builder.AddAttribute(14, "b-3xlak414es");
            __builder.AddContent(15, 
#nullable restore
#line 12 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
         Family.HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "b-3xlak414es");
            __builder.AddContent(19, 
#nullable restore
#line 13 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
         Family.Adults.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " Adults; ");
            __builder.AddContent(21, 
#nullable restore
#line 13 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
                                      Family.Children.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " Children; ");
            __builder.AddContent(23, 
#nullable restore
#line 13 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
                                                                       Family.Pets.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, " Pets");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "b-3xlak414es");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
                          () => { FamilyService.DeleteFamily(Family.StreetName, Family.HouseNumber); Family = null; StateHasChanged();}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "b-3xlak414es");
            __builder.AddMarkupContent(31, "<i class=\"fas fa-trash\" b-3xlak414es></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
     if (_isCollapsed == false)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, 
#nullable restore
#line 22 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
         ChildContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 22 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
                     
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Shark\Documents\Coding\DotNet\DNP1\FamilyManagementSystem\Components\ExpandableFamilyTableRow.razor"
       
    private string iconClass = "oi oi-collapse-down";
    private bool _isCollapsed = true;
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public Family Family { get; set; }

    public void ExpandView()
    {
        if (_isCollapsed)
        {
            _isCollapsed = false;
            iconClass = "oi oi-collapse-up";
        }
        else
        {
            _isCollapsed = true;
            iconClass = "oi oi-collapse-down"; 
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591