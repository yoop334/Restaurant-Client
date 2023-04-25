using System.Windows.Forms;

namespace RestaurantClient.Model;

public class Account
{
    public string AccessToken { get; set; }

    public string RefreshToken { get; set; }

    public User User { get; set; }
}