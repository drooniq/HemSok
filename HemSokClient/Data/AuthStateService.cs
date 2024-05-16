using HemSokClient.Models.LoginModels;

/*
 Author: Emil Waara
 */
namespace HemSokClient.Data
{
    public class AuthStateService : IAuthStateService
    {
        public CurrentUser? currentUser { get; set; } = null!;
        public AuthStateService() { }

        public bool IsLoggedIn() => currentUser != null;
        public bool IsAdmin() => currentUser?.Role == Constants.UserRoles.Admin;
        public bool IsAgent() => currentUser?.Role == Constants.UserRoles.Agent;
        public bool IsSuperAdmin() => currentUser?.Role == Constants.UserRoles.SuperAdmin;
        public void Login(CurrentUser user)
        {
            currentUser = user;
//            CurrentUserHasChange = true;
        }
        public void Logout()
        {
            currentUser = null;
//            CurrentUserHasChange = true;
        }

//        private bool CurrentUserHasChange;

        //public bool HasUserChanged()
        //{
        //    return CurrentUserHasChange;
        //}

        public bool HasValidToken()
        {
            return currentUser?.loginResponse?.JwtToken != null &&
                   currentUser.loginResponse.ExpirationDate >= DateTime.Now;
        }

        public string? GetToken()
        {
            return (HasValidToken() ? currentUser?.loginResponse?.JwtToken : null);
        }
    }
}
