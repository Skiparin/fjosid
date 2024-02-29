using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;


namespace Fjosid.Pages
{
    public partial class Index
    {
        [CascadingParameter]
        public int LanguageId { get; set; } = 1;

        [Inject] IJSRuntime JSRuntime { get; set; } = default!;
        [Inject] NavigationManager NavigationManager { get; set; } = default!;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("initMap", null);
                StateHasChanged();
            }
        }

        private void NavToBooking()
        {
            NavigationManager.NavigateTo("/Booking");
        }

        private void NavToGallary()
        {
            NavigationManager.NavigateTo("/Gallary");
        }
    }
}
