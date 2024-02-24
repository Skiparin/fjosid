using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using System.Text.RegularExpressions;

namespace Fjosid.Pages
{
    public partial class Index
    {
        [CascadingParameter]
        public int LanguageId { get; set; } = 1;

        [Inject] IJSRuntime JSRuntime { get; set; } = default!;

        private bool arrows = true;
        private bool bullets = true;
        private bool enableSwipeGesture = true;
        private bool autocycle = true;
        private Transition transition = Transition.Fade;


        private async Task ScrollToBooking()
        {
            await JSRuntime.InvokeVoidAsync("scrollToBooking");
        }
    }
}
