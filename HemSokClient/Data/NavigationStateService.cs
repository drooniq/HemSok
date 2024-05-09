using Microsoft.AspNetCore.Components;

namespace HemSokClient.Data
{
    public class NavigationStateService : INavigationStateService
    {
        private readonly NavigationManager navigationManager;
        private Stack<string> history = new Stack<string>();

        public NavigationStateService(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
            history.Push(navigationManager.Uri);
        }

        public string GetCurrentUri()
        {
            return navigationManager.Uri;
        }

        public void NavigateBack()
        {
            if (history.Count <= 1)
                return;

            history.Pop();
            var previous = history.Peek();

            navigationManager.NavigateTo(previous);
        }

        public void NavigateTo(string uri)
        {
            history.Push(uri);
            navigationManager.NavigateTo(uri);
        }
    }
}
