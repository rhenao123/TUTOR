using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Sales.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(3000);

            var anonimous = new ClaimsIdentity();
            var userJ = new ClaimsIdentity(new List<Claim>
        {
            new Claim("FirstName", "Robin"),
            new Claim("LastName", "Dionisio"),
            new Claim(ClaimTypes.Name, "Dioni@Fatalerror.com"),
            new Claim(ClaimTypes.Role, "Admin")
        },

                authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(userJ)));
        }
    }
}
