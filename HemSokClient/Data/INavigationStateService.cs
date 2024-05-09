/*
 Author: Emil Waara
 */
namespace HemSokClient.Data
{
    public interface INavigationStateService
    {
        string GetCurrentUri();
        void NavigateBack();
        void NavigateTo(string uri);
        string ToString();
    }
}
