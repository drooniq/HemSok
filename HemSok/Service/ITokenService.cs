using HemSok.Models;

namespace HemSok.Service
{
    public interface ITokenService
    {
        string CreateToken(Agent agent);
    }
}