/*
 Author: Emil Waara
 */
using HemSokClient.Models;
using HemSokClient.Models.LoginModels;
using Microsoft.AspNetCore.Identity;

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