/*
 Author: Marcus Karlsson
 */
namespace HemSokClient.Models.LoginModels
{
    public class LoginResponse
    {
        public required string JwtToken { get; set; }
        public DateTime ExpirationDate { get; set; }
        public required string Id { get; set; }
    }
}
