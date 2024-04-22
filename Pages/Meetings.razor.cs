using Microsoft.AspNetCore.Components;

namespace Fjosid.Pages
{
    public partial class Meetings
    {
        [CascadingParameter]
        public int LanguageId { get; set; } = 2;

        private string _text
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "Welcome to Fjósið, where we offer a versatile venue that seamlessly transitions from a cozy restaurant atmosphere to a dynamic event space. Nestled in Bøur, Fjósið caters to various occasions, from intimate gatherings to corporate meetings. Our venue rental service provides the perfect backdrop for your event, whether it's a professional seminar or a personal celebration. With state-of-the-art amenities and a warm ambiance, Fjósið ensures an unforgettable experience for you and your guests.";
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
                    return "At Fjósið, we understand the importance of finding the right space for your meetings. That's why we offer flexible rental options to accommodate your needs. Choose between a full day rental for 6000 DKK or a half-day rental for 3000 DKK, both of which include complimentary coffee and water throughout your event. Our venue is equipped with essential amenities such as a projector and canvas, ensuring seamless presentations and discussions. Whether you're hosting a corporate workshop, training session, or board meeting, Fjósið provides the ideal setting for productive gatherings.";
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
                    return "Our venue is designed to enhance your meeting experience with convenient amenities and attentive services. Beyond the standard rental fee, you'll have access to complimentary coffee and water to keep your attendees refreshed and focused. The inclusion of a projector and canvas facilitates smooth presentations and visual aids, allowing you to convey your message effectively. Additionally, our dedicated staff is on hand to assist with any technical requirements or special requests, ensuring that your event runs seamlessly from start to finish.";
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
                    return "Ready to book Fjósið for your next meeting or corporate event? Securing your desired date is simple. Using the button below will take you to the bookings page and there it is possible to send a reservation. Whether you need the space for a full day or a half day, we'll work with you to accommodate your schedule. Upon confirmation, we'll provide all the necessary details and ensure that everything is in place for a successful event. Trust Fjósið to elevate your meetings with our exceptional venue and attentive service.";
                }
                else
                {
                    return "Okkara hjartamál er at borðreiða við so nógvum staðbundnum mati\r\nsum gjørligt. Vit eru fleiri í hesum felagnum og øll hava seyð og so hava\r\nvit eisini nøgur skotsk Highland neyt. Har aftur at hava vit velt epli og\r\nfara í næstum undir at byggja eitt rúm til hydrophonics grønmeti,\r\nsoleiðis at vit eisini kunnu borðreiða við feskast møguligum grønmeti.";
                }
            }
        }

        [Inject] NavigationManager NavigationManager { get; set; } = default!;

        private void NavToBooking()
        {
            NavigationManager.NavigateTo("/Booking");
        }
    }
}
