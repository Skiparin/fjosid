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
        
        private string _imageTitle
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Welcome to Fjósið";
                }
                else
                {
                    return "Vælkomin til Fjósið";
                }
            }
        }
        
        private string _imageText
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Located in the village of Bøur, Fjósið is a unique restaurant situated in the top part of a barn. We provide a farm-to-table dining experience with ingredients sourced from our farm, including lamb and cow, as well as local salmon. Open to the public seasonally, Fjósið also accepts year-round bookings for private dining, meetings, and events.";
                }
                else
                {
                    return "Fjósið er ein serstøk matstova, sum liggur í bygdini Bøur, í ovaru hædd av einum fjósi. Vit bjóða eina farm-to-table matskrá við rávørum frá okkara egna bóndagarði, so sum lamb og neytakjøt, umframt lokalt laks. Opið fyri almenninginum ávís tíðarskeið, men Fjósið tekur ímóti bíleggingum fyri privat borðhald, fundir og tiltøk alt árið.";
                }
            }
        }

        private string _intro
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "At the heart of our culinary philosophy lies a deep commitment to farm-\r\nto-table dining, where every dish begins with fresh, locally-sourced\r\ningredients. Our menu is a celebration of the seasons, featuring (an\r\never-changing array of) flavors that highlight the best of what the local\r\nfarms offer. From crisp, garden-picked vegetables to free-range meats\r\n(and artisanal cheeses), each ingredient is carefully selected to ensure\r\nthe highest quality and taste. Our chefs (artfully) blend tradition with\r\ninnovation, crafting dishes that not only delight the palate but also tell\r\nthe story of the land and the hands that nurtured it. Dining with us is\r\nmore than a meal; it's an intimate journey through the local\r\ncountryside's bountiful produce and a tribute to the community of\r\nfarmers and artisans who bring their passion to your plate.";
                }
                else
                {
                    return "Okkara hjartamál er at borðreiða við so nógvum staðbundnum mati\r\nsum gjørligt. Vit eru fleiri í hesum felagnum og øll hava seyð og so hava\r\nvit eisini nøgur skotsk Highland neyt. Har aftur at hava vit velt epli og\r\nfara í næstum undir at byggja eitt rúm til hydrophonics grønmeti,\r\nsoleiðis at vit eisini kunnu borðreiða við feskast møguligum grønmeti.";
                }
            }
        }

        private string _intro_2
        {
            get
            {
                if (LanguageId == 2)
                {
                    return string.Empty;
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
                    return "Steeped in history and rustic charm, our restaurant embraces the heritage of its origins—a beautifully renovated barn that once stood as the heart of a bustling farm. We've meticulously preserved the barn's authentic character, from the old ceiling to the original stone walls, creating a warm, inviting ambiance that transports you to a bygone era. Each corner of our dining space tells a story.";
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
