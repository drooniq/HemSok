namespace HemSokClient.Models.LoginModels
{
    public class CurrentUser
    {
        public Agent CurrentAgent { get; set; }
        public LoginResponse LoginResponse { get; set; }
        public string? Role { get; set; }
    }
}
