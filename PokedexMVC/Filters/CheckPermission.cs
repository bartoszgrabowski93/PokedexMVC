using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace PokedexMVC.Web.Filters
{
    public class CheckPermission : Attribute, IAuthorizationFilter
    {
        private readonly string _permission;

        public CheckPermission(string permission)
        {
            _permission = permission;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool isAuthorized = CheckUserPermission(context.HttpContext.User, _permission);

            if (!isAuthorized)
            {
                context.Result = new UnauthorizedResult();
            }
        }

        private bool CheckUserPermission(ClaimsPrincipal user, string permission)
        {
            //połącz z bazą danych
            //Pobierz użytkownika
            //Sprawdzenie czy dany użytkownik ma prawa do dostępu do tej akcji
            return permission == "Read";
        }
    }
}
