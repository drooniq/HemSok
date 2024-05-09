using Microsoft.AspNetCore.Components;

/*
 Author: Emil Waara
 */
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

        public override string ToString()
        {
            string result = "HistoryList: \n";
            int i = 0;
            
            foreach (var item in history)
            {
                result += $"{i++} {item} \n";
            }

            return result;
        }
    }
}
