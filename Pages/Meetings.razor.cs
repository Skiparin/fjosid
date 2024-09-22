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
                    return "Welcome to Fjósið. Our venue offers a flexible space that easily adapts from a cozy restaurant setting to a functional event area. Located in Bøur, Fjósið is suitable for a range of occasions, from small gatherings to corporate meetings. Whether you’re planning a seminar or a personal celebration, our rental service provides a simple and fitting setting for your event. With modern facilities and a welcoming atmosphere, Fjósið aims to create a comfortable experience for you and your guests.";
                }
                else
                {
                    return "Vælkomin til Fjósið. Okkara høli er eitt fjølbroytt stað, sum lættliga kann verða brúkt bæði sum hugnaligur matsalur og sum virkisøki til ymisk tiltøk. Liggandi í Bø, er Fjósið væl egnað til ymisk sløg av tiltøkum, frá smærri samkomum til vinnuligar fundir. Um tú ætlar eitt seminar ella eina persónliga hátíð, bjóðar okkara leigutænasta eitt hóskandi og einfalt høli til títt tiltak. Við nýggjum hentleikum og eini blíðari atmosfæru, miðar Fjósið eftir at skapa eina hugnaliga uppliving fyri teg og tínar gestir.";
                }
            }
        }

        private string _text_2
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "If you want to have a meeting in the Faroe Islands, you can come to us. Besides breathtaking views and a cosy environment, we have a overhead projector, loudspeaker and a flippboard. We see to that you have coffee/tea and water during the day and there is also possibilty to order food for the day. It can be breakfast, lunch, cake or all 3. This must of course be ordered before hand.";
                }
                else
                {
                    return "Um tit skulu hava eitt fundarhølið, er Fjósið ein góður møguleiki. Burtursæð frá tí vakra útsýninum og tí hugnaliga hølinum, hava vit uppvørpu, hátalara og flippboard og syrgja fyri at tit hava kaffi/te og vatn ígjøgnum dagin. Eisini er møguleiki at keypa mat afturat, tað kann vera morgunmatur, miðmáli (frokost), ella kaka. Hetta má sjálvandi bíleggjast áðrenn.";
                }
            }
        }
        
        private string _text_2_2
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "The price for \u00bd day is 3000 DKK VAT not included and a whole day, 6000 DKK VAT not incl.";
                }
                else
                {
                    return "Prísurin fyri \u00bd dag er 3000kr. uttan mvg og fyri heilan dag 6000kr uttan mvg.";
                }
            }
        }

        private string _text_3
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "If you want to host a birthday or something similar, away from home, you can rent our venue and you see to the food yourselves. You clean up afterwards, but we do the washing.";
                }
                else
                {
                    return "Um tú skalt halda føðingardag, konfirmatión ella líknandi ber til at leiga hølið hjá okkum og so standa tit sjálvi fyri matinum. Tit rudda sjálvandi upp eftir tykkum, men vit vaska bæði áðrenn og aftaná.";
                }
            }
        }
        
        private string _text_3_2
        {
            get
            {
                if (LanguageId == 2)
                {
                    return "This costs 3750 DKK VAT inc.";
                }
                else
                {
                    return "Hetta kostar fyri eitt døgn 3750kr. við mvg.";
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
                    return "Ert tú klár/ur at bíleggja Fjósið til tín næsta fund ella vinnuliga tiltak?\nAt tryggja tær ynsktu dagfestingina er einfalt. Við at trýsta á knøttin niðanfyri, kemur tú á bíleggingarsíðuna, har tú kanst senda eina bílegging. Um tú hevur brúk fyri hølinum til ein heilendan dag ella hálvan dag, so arbeiða vit saman við tær at laga tað til tín tíðarætlan. Eftir váttan, geva vit tær øll neyðug tíðindi og tryggja, at alt er klárt til eitt væleydnað tiltak. Tú kanst líta á Fjósið til at lyfta tínar fundir við okkara framúrskarandi høli og uppmerkssama tænastu.";
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
