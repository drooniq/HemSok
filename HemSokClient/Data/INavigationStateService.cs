/*
 Author: Emil Waara
 */
namespace HemSokClient.Data
{
    public interface INavigationStateService
    {
        string GetCurrentUri();
        bool NavigateBack();
        void NavigateTo(string uri);
        string ToString();
    }
}
