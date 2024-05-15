/*
 Author: Emil Waara
 */
using HemSokClient.Models.LoginModels;

namespace HemSokClient.Data
{
    public interface IAuthStateService
    {
        CurrentUser? currentUser { get; set; }

        string? GetToken();
        bool HasValidToken();
        bool IsAdmin();
        bool IsAgent();
        bool IsLoggedIn();
        bool IsSuperAdmin();
        void Login(CurrentUser user);
        void Logout();
    }
}