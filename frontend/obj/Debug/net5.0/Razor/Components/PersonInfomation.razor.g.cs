#pragma checksum "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9cbcca9eb71f78d8b31bde464590eb24bca639c"
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
#line 11 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
using DNPAssignment1FamilyManagementSystem.Data.Impl;

#line default
#line hidden
#nullable disable
    public partial class PersonInfomation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
 if (Person != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Policy", "IsUser");
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "p");
                __builder2.AddAttribute(4, "b-oe6jo7838c");
                __builder2.AddContent(5, "Name: ");
                __builder2.AddContent(6, 
#nullable restore
#line 10 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                      Person.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, " ");
                __builder2.AddContent(8, 
#nullable restore
#line 10 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                                        Person.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(9, "  ");
                __builder2.OpenElement(10, "button");
                __builder2.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                                                                           DeletePerson

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "b-oe6jo7838c");
                __builder2.AddMarkupContent(13, "<i class=\"fas fa-trash\" b-oe6jo7838c></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "p");
                __builder2.AddAttribute(16, "b-oe6jo7838c");
                __builder2.AddContent(17, "Age: ");
                __builder2.AddContent(18, 
#nullable restore
#line 11 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                     Person.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "p");
                __builder2.AddAttribute(21, "b-oe6jo7838c");
                __builder2.AddContent(22, "Sex: ");
                __builder2.AddContent(23, 
#nullable restore
#line 12 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                     Person.Sex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "p");
                __builder2.AddAttribute(26, "b-oe6jo7838c");
                __builder2.AddContent(27, "Height: ");
                __builder2.AddContent(28, 
#nullable restore
#line 13 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                        Person.Height

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "p");
                __builder2.AddAttribute(31, "b-oe6jo7838c");
                __builder2.AddContent(32, "Weight: ");
                __builder2.AddContent(33, 
#nullable restore
#line 14 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                        Person.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenElement(35, "p");
                __builder2.AddAttribute(36, "b-oe6jo7838c");
                __builder2.AddContent(37, "EyeColor: ");
                __builder2.AddContent(38, 
#nullable restore
#line 15 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                          Person.EyeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.OpenElement(40, "p");
                __builder2.AddAttribute(41, "b-oe6jo7838c");
                __builder2.AddContent(42, "HairColor: ");
                __builder2.AddContent(43, 
#nullable restore
#line 16 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                           Person.HairColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(44, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(45, "p");
                __builder2.AddAttribute(46, "b-oe6jo7838c");
                __builder2.AddContent(47, "Name: ");
                __builder2.AddContent(48, 
#nullable restore
#line 20 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                      Person.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(49, " ");
                __builder2.AddContent(50, 
#nullable restore
#line 20 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                                        Person.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenElement(52, "p");
                __builder2.AddAttribute(53, "b-oe6jo7838c");
                __builder2.AddContent(54, "Age: ");
                __builder2.AddContent(55, 
#nullable restore
#line 21 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                     Person.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenElement(57, "p");
                __builder2.AddAttribute(58, "b-oe6jo7838c");
                __builder2.AddContent(59, "Sex: ");
                __builder2.AddContent(60, 
#nullable restore
#line 22 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                     Person.Sex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.OpenElement(62, "p");
                __builder2.AddAttribute(63, "b-oe6jo7838c");
                __builder2.AddContent(64, "Height: ");
                __builder2.AddContent(65, 
#nullable restore
#line 23 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                        Person.Height

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.OpenElement(67, "p");
                __builder2.AddAttribute(68, "b-oe6jo7838c");
                __builder2.AddContent(69, "Weight: ");
                __builder2.AddContent(70, 
#nullable restore
#line 24 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                        Person.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.OpenElement(72, "p");
                __builder2.AddAttribute(73, "b-oe6jo7838c");
                __builder2.AddContent(74, "EyeColor: ");
                __builder2.AddContent(75, 
#nullable restore
#line 25 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                          Person.EyeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.OpenElement(77, "p");
                __builder2.AddAttribute(78, "b-oe6jo7838c");
                __builder2.AddContent(79, "HairColor: ");
                __builder2.AddContent(80, 
#nullable restore
#line 26 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
                           Person.HairColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 29 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Micha\Documents\Coding\WebDev\FamilyManagementSystem\Components\PersonInfomation.razor"
       

    [Parameter]
    public Person Person { get; set; }
    [Parameter]
    public Family Family { get; set; }

    [Parameter]
    public IDeleteStrategy DeleteStrategy { get; set; }

    private void DeletePerson()
    {
        if (DeleteStrategy != null)
        {
            DeleteStrategy.Delete(Person, Family);
            Person = null;
        
    /*
         *Fixes an issue where p-tags in Parent Component with Salary and Job
         * were not updated after the adult has been deleted. 
         */ 
            EventCoordinator.Notify();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEventCoordinator EventCoordinator { get; set; }
    }
}
#pragma warning restore 1591