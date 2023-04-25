
using System.ComponentModel.DataAnnotations;

namespace RestaurantClient.Model
{
    public class AuthenticationRequest
    {
        [Required] public string Username { get; set; }

        [Required] public string Password { get; set; }
    }
}

