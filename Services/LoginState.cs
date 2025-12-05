namespace eCommerce_Shop_Client.Services
{
    public class LoginState
    {
        public bool IsLoggedIn { get; set; } = false;
        public string? UserEmail { get; set; }
        public string? UserName { get; set; }
    }
}
