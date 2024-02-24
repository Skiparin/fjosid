using MudBlazor;
using System.Text.RegularExpressions;

namespace Fjosid.Pages
{
    public partial class Booking
    {
        bool success;
        string[] errors = { };
        MudTextField<string> pwField1;
        MudForm form;

        private IEnumerable<string> NumberOfGuests(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                yield return "Password is required!";
                yield break;
            }

            int num = 0;
            if (Int32.TryParse(text, out num) == false)
            {
                yield return "Number of guests must be a number";
            }

            if (num < 8)
                yield return "Number of guests must be 8 or higher";
            if (num > 40)
                yield return "Number of guests must be 40 or lower";
        }
    }
}
