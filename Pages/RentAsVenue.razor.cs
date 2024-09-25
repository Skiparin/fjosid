using Microsoft.AspNetCore.Components;

namespace Fjosid.Pages
{
    public partial class RentAsVenue
    {
        [CascadingParameter]
        public int LanguageId { get; set; } = 2;

        [Inject] NavigationManager NavigationManager { get; set; } = default!;

        private string _textTitle
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Rent As Venue";
                }
                else
                {
                    return "Leiga sum høli";
                }
            }
        }

        private string _text
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Welcome to Fjósið - your versatile venue for unforgettable gatherings! Whether you're planning a birthday bash, a baptism celebration, or any other special event, Fjósið is here to make your occasion truly memorable. Nestled in the heart of Bøur, our venue offers a unique blend of rustic charm and modern amenities, perfect for creating unforgettable moments with your loved ones. Discover the possibilities that await you at Fjósið!";
                }
                else
                {
                    return "Vælkomin í Fjósið - títt fjølbroytta stað til óforglemmiligar samkomur! Um tú ætlar tær eina føðingardagsveitslu, eina dópsveitslu ella okkurt annað serligt hátíðarhald, er Fjósið her fyri at gera tína løtu heilt serliga. Staðsett í hjartanum av Bø, bjóðar okkara høli eina serstaka samanrenning av rustikkari sjarma og nútímans hentleikum, sum er fullkomin til at skapa óforglemmiligar løtur saman við tínum kæru. Kom og uppdaga møguleikarnar, sum bíða tær í Fjósið!";
                }
            }
        }

        private string _textTitle_2
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Venue Rental Options";
                }
                else
                {
                    return "Leigumøguleikar fyri høli";
                }
            }
        }

        private string _text_2
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "At Fjósið, we understand that every event is unique, which is why we offer flexible rental options to suit your needs. Choose from a full-day rental or a half-day rental, depending on the duration of your event. Our full-day rental option allows you exclusive access to the venue for the entire day, from setup to cleanup, ensuring ample time to create cherished memories with your guests. For shorter gatherings, our half-day rental option provides the perfect solution, allowing you to enjoy all the amenities of Fjósið for a convenient timeframe. Whatever your event requires, we're here to accommodate your needs with our affordable and convenient rental options.";
                }
                else
                {
                    return "Í Fjósið skilja vit, at hvør samkoma er serstøk, og tí bjóða vit fleksiblar leigumøguleikar, ið hóskandi til tín tørv. Tú kanst velja millum at leiga fyri ein heilan dag ella ein hálvan dag, alt eftir hvussu leingi títt tiltak varir. Við heildagsleigu hevur tú einkarrætt til hølið allan dagin, frá fyrireiking til reingerð, so tú kanst skapa dýrabærar minnir saman við tínum gestum. Til styttri tiltøk er okkara hálvdagsleiga tann fullkomna loysnin, sum gevur tær høvi at njóta allar hentleikarnar í Fjósið í einari hóskandi tíðarrammu. Hvat enn títt tiltak krevur, eru vit her til at nøkta tín tørv við okkara bíligu og snildu leigumøguleikum.";
                }
            }
        }

        private string _textTitle_3
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Pricing Information";
                }
                else
                {
                    return "Prísupplýsingar";
                }
            }
        }

        private string _text_3
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Our pricing structure at Fjósið is designed to provide excellent value for your money, allowing you to host your event without breaking the bank. A full-day rental of our venue is priced at just 6000 DKK, while a half-day rental is available for 3000 DKK. This transparent pricing ensures that you know exactly what to expect, with no hidden fees or surprises. With Fjósið, you can host your event with confidence, knowing that you're getting the best value for your investment.";
                }
                else
                {
                    return "Okkara prísir í Fjósið eru gjørdir til at geva tær framúr virði fyri pengarnar, so tú kanst hýsa tínum tiltaki uttan at sprongja búskaparætlanina. Ein heildagsleiga av okkara høli kostar bert 6000 DKK, meðan ein hálvdagsleiga er tøk fyri 3000 DKK. Hesir gjøgnumskygdu prísir tryggja, at tú veitst nágreiniliga, hvat tú kanst vænta, uttan duldar útreiðslur ella óvæntaðar kostnaðir. Við Fjósið kanst tú hava títt tiltak við fullum áliti, vitandi at tú fært besta virði fyri tína íløgu.";
                }
            }
        }

        private string _textTitle_4
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Booking and Inquiries";
                }
                else
                {
                    return "Bílegging og fyrispurningar";
                }
            }
        }

        private string _text_4
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Ready to book your event at Fjósið? We make the process simple and stress-free. Using the button below will take you to the bookings page and there it is possible to send a reservation. Whether you have questions about availability, amenities, or special requests, we're here to assist you every step of the way. Contact us today to start planning your next unforgettable event at Fjósið!";
                }
                else
                {
                    return "Klár/ur at bóka títt tiltak í Fjósið? Vit gera tilgongdina einfald og uttan stríð. Við at trýsta á knøttin niðanfyri, fert tú til bíleggingarsíðuna, har tú kanst senda eina bílegging. Um tú hevur spurningar um tøkiliga tíð, hentleikar ella serligar ynskir, so eru vit her til at hjálpa tær hvønn veg á leiðini. Set teg í samband við okkum í dag fyri at byrja fyrireikingina av tínum næsta óforglemmiliga tiltaki í Fjósið!";
                }
            }
        }

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

        private void NavToBooking()
        {
            NavigationManager.NavigateTo("/Booking");
        }
    }
}
