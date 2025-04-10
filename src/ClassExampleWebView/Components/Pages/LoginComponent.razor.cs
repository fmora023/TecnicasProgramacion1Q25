using Microsoft.AspNetCore.Components;

namespace ClassExampleWebView.Components.Pages
{
    /// <summary>
    /// Class to implement the login component.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Components.ComponentBase" />
    public partial class LoginComponent
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; } = default!;

        private string Username { get; set; } = string.Empty;

        private string Password { get; set; } = string.Empty;

        private void Login()
        {
            if (Username == "admin" && Password == "admin")
            {
                NavigationManager.NavigateTo("/Home");
            }
        }
    }
}
