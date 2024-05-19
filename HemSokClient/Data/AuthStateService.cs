using Blazored.LocalStorage;
using HemSokClient.Models;
using HemSokClient.Models.LoginModels;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;

/*
 Author: Emil Waara
 */
namespace HemSokClient.Data
{
    public class AuthStateService : IAuthStateService
    {
        public CurrentUser? currentUser { get; set; } = null!;

        private readonly ILocalStorageService _localStorage;
        private const string CurrentUserKey = "currentUser";

        public AuthStateService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task InitializeAsync()
        {
            await LoadCurrentUserFromLocalStorage();
        }

        public bool IsLoggedIn() => currentUser != null;
        public bool IsAdmin() => currentUser?.Role == Constants.UserRoles.Admin;
        public bool IsAgent() => currentUser?.Role == Constants.UserRoles.Agent;
        public bool IsSuperAdmin() => currentUser?.Role == Constants.UserRoles.SuperAdmin;

        public void Login(CurrentUser user)
        {
            currentUser = user;
            SaveCurrentUserToLocalStorage();
        }

        public void Logout()
        {
            currentUser = null;
            SaveCurrentUserToLocalStorage();
        }

        public bool HasValidToken()
        {
            return currentUser?.loginResponse?.JwtToken != null &&
                   currentUser.loginResponse.ExpirationDate >= DateTime.Now;
        }

        public string? GetToken()
        {
            return (HasValidToken() ? currentUser?.loginResponse?.JwtToken : null);
        }

        private async void SaveCurrentUserToLocalStorage()
        {
            if (currentUser != null)
            {
                var json = JsonSerializer.Serialize(currentUser);
                await _localStorage.SetItemAsync(CurrentUserKey, json);
            }
            else
            {
                await _localStorage.RemoveItemAsync(CurrentUserKey);
            }
        }

        private async Task LoadCurrentUserFromLocalStorage()
        {
            var json = await _localStorage.GetItemAsync<string>(CurrentUserKey);
            if (!string.IsNullOrEmpty(json))
            {
                currentUser = JsonSerializer.Deserialize<CurrentUser>(json);
            }
        }
    }
}
