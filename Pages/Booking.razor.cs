using MudBlazor;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace Fjosid.Pages
{
    public partial class Booking
    {
        bool success;
        string[] errors = { };
        MudTextField<string> pwField1;
        MudForm form;
        string s = "rjvk ssby ukka ollc";

        private List<string> numberOfGuestsList = new List<string>()
        {
            "8 Guests",
            "9 Guests",
            "10 Guests",
            "11 Guests",
            "12 Guests",
            "13 Guests",
            "14 Guests",
            "15 Guests",
            "16 Guests",
            "17 Guests",
            "18 Guests",
            "19 Guests",
            "20 Guests",
            "21 Guests",
            "22 Guests",
            "23 Guests",
            "24 Guests",
            "25 Guests",
            "26 Guests",
            "27 Guests",
            "28 Guests",
            "29 Guests",
            "30 Guests",
            "31 Guests",
            "32 Guests",
            "33 Guests",
            "34 Guests",
            "35 Guests",
            "36 Guests",
            "37 Guests",
            "38 Guests",
            "39 Guests",
            "40 Guests",
        };

        private DateTime? _date { get; set; } = DateTime.Now;
        private string _numOfGuests { get; set; }
        private string _firstName { get; set; } = string.Empty;
        private string _lastName { get; set; } = string.Empty;
        private string _email { get; set; } = string.Empty;
        private string _phonenumber { get; set; } = string.Empty;
        private string _message { get; set; } = string.Empty;

        private IEnumerable<string> NumberOfGuests(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                yield return "Number of guests is required";
                yield break;
            }

            int num = 0;
            if (Int32.TryParse(text.Split(" ")[0], out num) == false)
            {
                yield return "Number of guests must be a number";
            }

            if (num < 8)
                yield return "Number of guests must be 8 or higher";
            if (num > 40)
                yield return "Number of guests must be 40 or lower";
        }

        private void SendEmail()
        {
            var fromAddress = new MailAddress("og1806x9@gmail.com", "Ørvur");
            var toAddress = new MailAddress("orvur.gutt@gmail.com", "Ørvur");
            string fromPassword = s;
            string subject = "Frá Fjósið.fo";
            string body = $"""
Dato: {_date?.Date}
Gestir: {_numOfGuests}
Navn: {_firstName} {_lastName}
Email: {_email}
Telefonnummar: {_phonenumber}
Boð: {_message}
""";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
