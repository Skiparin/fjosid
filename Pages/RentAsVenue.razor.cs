using Microsoft.AspNetCore.Components;

namespace Fjosid.Pages
{
    public partial class RentAsVenue
    {
        [CascadingParameter]
        public int LanguageId { get; set; } = 2;

        [Inject] NavigationManager NavigationManager { get; set; } = default!;

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
                    return "Okkara hjartamál er at borðreiða við so nógvum staðbundnum mati\r\nsum gjørligt. Vit eru fleiri í hesum felagnum og øll hava seyð og so hava\r\nvit eisini nøgur skotsk Highland neyt. Har aftur at hava vit velt epli og\r\nfara í næstum undir at byggja eitt rúm til hydrophonics grønmeti,\r\nsoleiðis at vit eisini kunnu borðreiða við feskast møguligum grønmeti.";
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
                    return "Okkara hjartamál er at borðreiða við so nógvum staðbundnum mati\r\nsum gjørligt. Vit eru fleiri í hesum felagnum og øll hava seyð og so hava\r\nvit eisini nøgur skotsk Highland neyt. Har aftur at hava vit velt epli og\r\nfara í næstum undir at byggja eitt rúm til hydrophonics grønmeti,\r\nsoleiðis at vit eisini kunnu borðreiða við feskast møguligum grønmeti.";
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
                    return "Okkara hjartamál er at borðreiða við so nógvum staðbundnum mati\r\nsum gjørligt. Vit eru fleiri í hesum felagnum og øll hava seyð og so hava\r\nvit eisini nøgur skotsk Highland neyt. Har aftur at hava vit velt epli og\r\nfara í næstum undir at byggja eitt rúm til hydrophonics grønmeti,\r\nsoleiðis at vit eisini kunnu borðreiða við feskast møguligum grønmeti.";
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
                    return "Okkara hjartamál er at borðreiða við so nógvum staðbundnum mati\r\nsum gjørligt. Vit eru fleiri í hesum felagnum og øll hava seyð og so hava\r\nvit eisini nøgur skotsk Highland neyt. Har aftur at hava vit velt epli og\r\nfara í næstum undir at byggja eitt rúm til hydrophonics grønmeti,\r\nsoleiðis at vit eisini kunnu borðreiða við feskast møguligum grønmeti.";
                }
            }
        }

        private void NavToBooking()
        {
            NavigationManager.NavigateTo("/Booking");
        }
    }
}
