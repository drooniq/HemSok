using HemSokClient.Models;
using Microsoft.AspNetCore.Components;

namespace HemSokClient.Pages
{
    public partial class EditAgency : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        private Agency agency { get; set; }

        protected override async Task OnInitializedAsync()
        {
            agency = await apiService.GetFromApiAsync<Agency>("api/agency/" + Id);
        }

        private async Task HandleValidSubmit()
        {
            if (await apiService.PutToApiAsync<Agency>(agency))
            {
                NavigationManager.NavigateTo("/agencylisting");
            }
        }
    }
}