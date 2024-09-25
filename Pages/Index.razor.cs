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

        private string _booking
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Booking";
                }
                else
                {
                    return "Bóking";
                }
            }
        }

        private string _menu
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Menu";
                }
                else
                {
                    return "Menu";
                }
            }
        }

        private string _gallery
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Gallery";
                }
                else
                {
                    return "Myndasavn";
                }
            }
        }

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

        private string _detailsTitle
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "A Barn with History";
                }
                else
                {
                    return "Eitt fjós við søgu";
                }
            }
        }

        private string _details
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Fjósið is located in a simple, carefully renovated barn that reflects the quiet charm of Bøur. We’ve kept the space true to its original form, preserving the natural simplicity of the building while making it a welcoming spot for our guests. It’s not fancy, but we believe the rustic setting adds a down-to-earth atmosphere to the experience, offering a peaceful place to enjoy a meal. Our aim is to create a space that feels comfortable and familiar, where the focus is on good food and good company.";
                }
                else
                {
                    return "Fjósið er staðsett í einum einføldum, væl umvældum fjósi, sum hóskar væl til umhvørvið. Vit hava varðveitt rúmið so upprunaligt sum til ber, samstundis sum vit hava gjørt tað til eitt hugnaligt stað til okkara gestir. Tað er ikki fínt, men vit halda, at hesin rustikki stílurin gevur eitt jarðbundið og heimligt huglag til at njóta eina góða máltíð. Okkara mál er at skapa eitt rúm, sum kennist fjálgt  og gott, har dentur er lagdur á tann góða matin og gott selskap.";
                }
            }
        }

        private string _detailsTitle_2
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Local Ingredients";
                }
                else
                {
                    return "Lokalar rávørur";
                }
            }
        }

        private string _details_2
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Our approach to food is straightforward: we use what’s available around us. The ingredients in our dishes come from our farm or nearby producers, ensuring that everything is fresh and local. We raise our own lamb and cattle, and work with local salmon farmers to offer simple, honest meals that highlight the flavors of our region. By keeping things local, we can offer dishes that are both fresh and connected to the community, all while supporting small-scale, sustainable producers.";
                }
                else
                {
                    return "Okkara tilgongd til mat er einføld: vit brúka tað, sum er tøkt rundan um okkum. Rávørurnar í okkara rættum, koma frá okkum ella frá lokalum framleiðarum, soleiðis at vit kunnu tryggja okkum, at tað er stuttflutt og av góðari góðsku. Vit hava bæði seyð og neyt, og samstarva eisini við lokalar framleiðarar. Við at halda mest møguligt staðbundi, kunnu vit bjóða mat, sum eru  knýttir at samfelagnum, ímeðan vit stuðla smáum, burðardyggum framleiðarum.";
                }
            }
        }

        private string _detailsTitle_3
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Rooted in Community";
                }
                else
                {
                    return "Staðbundi";
                }
            }
        }

        private string _details_3
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Fjósið is run by people from the local community, and we keep it that way. It’s a small place, and we like to keep things simple, focusing on creating a familiar and relaxed atmosphere. Being locally owned, we value the connections we have with our neighbors, and our goal is to provide a space where everyone feels welcome. Whether you’re from nearby or visiting, we want Fjósið to feel like a place where people can come together, enjoy honest food, and feel part of something local and genuine.";
                }
                else
                {
                    return "Fjósið verður rikið av fólki úr lokalsamfelagnum, og soleiðis vilja vit hava tað. Tað er eitt lítið stað, og vit dáma tað einfalt, við denti løgdum á at skapa eitt heimaligt og hugnaligt huglag.  Vit virðismeta sambandið við okkara grannar, og okkara mál er at bjóða eitt stað, har øll eru vælkomin. Antin tú ert úr grannalagnum ella ert á vitjan, vilja vit, at Fjósið skal kennast sum eitt stað, har fólk kunnu koma saman, njóta góðan mat og føla seg sum ein part av staðnum.";
                }
            }
        }

        private string _offer
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "What we offer";
                }
                else
                {
                    return "Hvat vit bjóða";
                }
            }
        }

        private string _dining
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "A Complete Dining Experience";
                }
                else
                {
                    return "Ein fullfíggjað matsuppliving";
                }
            }
        }

        private string _events
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Meetings and Events";
                }
                else
                {
                    return "Fundir og tiltøk";
                }
            }
        }

        private string _venue
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Rent Fjósið as a Venue";
                }
                else
                {
                    return "Leiga Fjósið sum eitt høli";
                }
            }
        }

        private string _umOkkum
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "About us";
                }
                else
                {
                    return "Um okkum";
                }
            }
        }

        private string _jennyHeri
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Heri is the farmer and the one who came up with the idea of making part of the barn into a\r\nrestaurant/venue. Jenny is the wife, boss, chef and cleaner.";
                }
                else
                {
                    return "Heri er bóndin og tann, sum kom við hugskotið at gera ein part av fjósinum til ein matsal/hølið. Jenny er konan, leiðarin, kokkurin og reingerðarfólkið.";
                }
            }
        }

        private string _eydsteinEllef
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Our friends Eystein and Ellef, who run Bluegate.fo, add a bit of adventure to our experience. They offer sightseeing tours on their fast boats, making it easy for our guests to enjoy a day on the water and a meal in our barn.";
                }
                else
                {
                    return "Vinir okkara, Eystein og Ellef, sum reka Bluegate.fo, leggja eitt sindur av ævintýri til okkara uppliving. Teir bjóða siglitúrar við sínum skjótbátum, so okkara gestir lættliga kunnu njóta ein dag á sjónum og eina máltíð í okkara fjósi.";
                }
            }
        }

        private string _eydfinnPoula
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Eyðfinn, Heri's cousin, helped turn the barn into what Fjósið is today. Together with his wife Poula, they’re a big part of our day-to-day life here, helping in the kitchen and keeping the place running smoothly.";
                }
                else
                {
                    return "Eyðfinn, systkinabarni hjá Hera, hjálpti at umskapa fjósið til tað, sum Fjósið er í dag. Saman við konu síni, Poulu, eru tey ein stórur partur av okkara gerandisdegi her, hjálpa til í køkinum og tryggja, at alt gongur smidliga.";
                }
            }
        }

        private string _tordur
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Tórður, Eyðfinn and Poula's son, is about to become a constructor. He’s been involved in making Fjósið a reality and represents the next generation of our community, blending old traditions with new ideas.";
                }
                else
                {
                    return "Tórður, sonur Eyðfinns og Poulu, er um at gerast byggimeistari. Hann hevur verið við til at gera Fjósið til veruleika og umboðar næstu ættarlið í okkara samfelag, har hann sameinir gamlar siðvenjur við nýggjum hugskotum.";
                }
            }
        }

        private string _location
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Location";
                }
                else
                {
                    return "Staðseting";
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
