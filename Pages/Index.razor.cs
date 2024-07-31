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
        public int LanguageId { get; set; } = 2;

        private string _intro
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Welcome to Fjósið, a haven of rustic elegance and culinary excellence nestled in the picturesque countryside of Bøur. From its humble origins as a historic barn, Fjósið has been lovingly transformed into a multifaceted destination where dining, celebration, and tradition converge.";
                }
                else
                {
                    return "Okkara hjartamál er at borðreiða við so nógvum staðbundnum mati\r\nsum gjørligt. Vit eru fleiri í hesum felagnum og øll hava seyð og so hava\r\nvit eisini nøgur skotsk Highland neyt. Har aftur at hava vit velt epli og\r\nfara í næstum undir at byggja eitt rúm til hydrophonics grønmeti,\r\nsoleiðis at vit eisini kunnu borðreiða við feskast møguligum grønmeti.";
                }
            }
        }

        private string _intro_1
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Step through our doors and embark on a journey through time, where the rustic beauty of yesteryear seamlessly blends with the comforts of modern hospitality. At Fjósið, we pride ourselves on offering more than just a meal or a space to gather—we provide an immersive experience that engages all the senses and leaves a lasting impression. Our historic barn, meticulously restored to its former glory, serves as the backdrop for an array of events, from intimate dinners to grand celebrations. Exposed wooden beams, soft candlelight, and the gentle hum of conversation create an ambiance that is both timeless and inviting, inviting guests to linger and make memories that will be cherished for years to come.";
                }
                else
                {
                    return "Tað sum vit ikki hava sjálvi, royna vit at keypa í nærumhvørvinum. Tað\r\nkann vera røtur úr Gásadali, laksur frá Luna, ella útróðrarfisk. Uttanfyri\r\nhava vit eisini eitt høsnarhús, soleiðis at vit fáa okkaru egg frá hønunum\r\nhar og sum vit vita hava tað gott og ikki livað nakað strongt lív.";
                }
            }
        }

        private string _intro_2
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Whether you're joining us for a leisurely meal, hosting a corporate retreat, or celebrating life's milestones with friends and family, Fjósið welcomes you with open arms and a warm Faroese embrace. Come experience the magic of Fjósið for yourself and discover why it's more than just a venue—it's a destination where dreams come to life and memories are made to last a lifetime.";
                }
                else
                {
                    return "Tað sum vit ikki hava sjálvi, royna vit at keypa í nærumhvørvinum. Tað\r\nkann vera røtur úr Gásadali, laksur frá Luna, ella útróðrarfisk. Uttanfyri\r\nhava vit eisini eitt høsnarhús, soleiðis at vit fáa okkaru egg frá hønunum\r\nhar og sum vit vita hava tað gott og ikki livað nakað strongt lív.";
                }
            }
        }

        private string _details
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "At Fjósið, we celebrate our rich heritage and the rustic ambiance of our surroundings. Our venue, housed in a beautifully restored barn, exudes warmth and character, with exposed beams, wooden accents, and cozy nooks that invite you to relax and unwind. As you dine or gather with friends and family, you'll feel a connection to the land and the generations of farmers who have called this place home. Whether you're seated at a handcrafted table or enjoying the view from our spacious patio, every corner of Fjósið tells a story of tradition, craftsmanship, and timeless beauty.";
                }
                else
                {
                    return "Okkara hølið er gjørt um við atlitið til søguna hjá fjódinum, vit hava\r\nvarveitt tað gamla loftið við nøkrum av teimum gomlu dragaranum og\r\nhar sum betongveggir vóru, standa teir í sama líki enn. Men sjálvandi\r\nmá okkurt broytast frá 4 súrhoyggjabrunnum til eins matstovu og har\r\nhava vit roynt at gjørt tað so hugnaligt sum gjørligt. Vit hava hugsa\r\nburðardygd inn og bert tað eina stóra vindeyga og úthurðin er gjørd til\r\nokkum, hini vindeyguni eru skeivt umbiðin/gjørd og høvdu farið burtur,\r\num vit ikki keyptu tey. Men vindeyguni eru stór og útsýni serstakliga gott\r\nog er hetta nakað sum okkara gestir virðismeta.";
                }
            }
        }

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

        private void NavToGallery()
        {
            NavigationManager.NavigateTo("/Gallery");
        }

        private void NavToMeetings()
        {
            NavigationManager.NavigateTo("/Meetings");
        }

        private void NavToRentAsVenue()
        {
            NavigationManager.NavigateTo("/Rent_As_Venue");
        }
    }
}
