using System.ComponentModel.DataAnnotations;

namespace PokedexApi
{
    public class UserModel
    {
        public string Email { get; set; }     
        public string Password { get; set; }
    }
}