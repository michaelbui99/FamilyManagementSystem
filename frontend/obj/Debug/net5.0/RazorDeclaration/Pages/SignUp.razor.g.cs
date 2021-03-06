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
#nullable restore
#line 1 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using DNPAssignment1FamilyManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using DNPAssignment1FamilyManagementSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\SignUp.razor"
using DNPAssignment1FamilyManagementSystem.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\SignUp.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\SignUp.razor"
using DNPAssignment1FamilyManagementSystem.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\SignUp.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\SignUp.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignUp")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Shark\Documents\Coding\WebDev\FamilyManagementSystem\frontend\Pages\SignUp.razor"
       
    private string _errorText;
    private string _passwordConfirmation; 
    private User _newUser = new User();
    private ICollection<ValidationResult> validationResults = new List<ValidationResult>();

    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }

    protected async override Task OnInitializedAsync()
    {
    //Redirects the user to index if user is already logged in.
        base.OnInitialized();
        var user = (await AuthStat).User;
        if (user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo("/");
        }
    }

    private async void CreateUser()
    {

        validationResults.Clear();
        ValidationContext validationContext = new ValidationContext(_newUser);
        bool userIsValid = Validator.TryValidateObject(_newUser, validationContext, validationResults, true);
        foreach (var validationResult in validationResults)
        {
    //Debugging
            Console.WriteLine(validationResult);
        }

        if (!PasswordConfirmationMatches())
        {
            _errorText = "Passwords does not match";
            return; 
        }
        
        if (userIsValid)
        {
            try
            {
                //Throws exception if user already exists.
                await UserService.CreateAsync(_newUser);
            }
            catch (Exception e)
            {
                _errorText = e.Message;
                StateHasChanged();
                return;
            }
            //User is logged on upon successful account creation
            await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(_newUser.Username, _newUser.Password);
            NavigationManager.NavigateTo("/");
        }
    }

    private bool PasswordConfirmationMatches()
    {
        return _passwordConfirmation == _newUser.Password;
    }
    



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591
