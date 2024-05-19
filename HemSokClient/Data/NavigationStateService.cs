using Microsoft.AspNetCore.Components;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            Uri baseUri = new Uri(navigationManager.BaseUri);
            Uri absoluteUri = new Uri(baseUri, navigationManager.Uri);
            return absoluteUri.AbsolutePath;
        }

        public bool NavigateBack()
        {
            if (history.Count == 1)
                return false;

            history.Pop();
            var previous = history.Peek();

            navigationManager.NavigateTo(previous);
            return true;
        }

        public void NavigateTo(string uri)
        {
            history.Push(uri);
            if(uri.Contains(GetCurrentUri()))
            {
                navigationManager.NavigateTo(uri, forceLoad: true);
            }
            else
            {
                navigationManager.NavigateTo(uri);
            }
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
