using MudBlazor;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using static MudBlazor.Defaults.Classes;
using static MudBlazor.CategoryTypes;

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

        private List<DateTime> _dates = new List<DateTime>();
        private const string FILENAME = "dates.txt";

        private DateTime? _date { get; set; } = DateTime.Now;
        private string _numOfGuests { get; set; }
        private string _firstName { get; set; } = string.Empty;
        private string _lastName { get; set; } = string.Empty;
        private string _email { get; set; } = string.Empty;
        private string _phonenumber { get; set; } = string.Empty;
        private string _message { get; set; } = string.Empty;


        private bool IsDateDisabledFunc(DateTime element) => _dates.Any(d => d.Date == element.Date);

        protected override async Task OnInitializedAsync()
        {
            LoadData();
            await base.OnInitializedAsync();
        }

        private void LoadData()
        {
            ValidateFile();

            _dates.Clear();
            foreach (string line in File.ReadLines(FILENAME))
            {
                _dates.Add(DateTime.Parse(line));
            }
        }

        private void ValidateFile()
        {
            bool fileExists = File.Exists(FILENAME);
            if (fileExists == false)
            {
                using (File.Create(FILENAME)) { }
            }
        }

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

        private void SendEmails()
        {
            SendEmail("orvur.gutt@gmail.com");
            SendEmail("fjosid2023@gmail.com");
            ResetInput();
            OpenSnackBar();
        }

        private void ResetInput()
        {
            success = false;
            _date = DateTime.Now;
            _numOfGuests = string.Empty;
            _firstName = string.Empty;
            _lastName = string.Empty;
            _email = string.Empty;
            _phonenumber = string.Empty;
            _message = string.Empty;
            form.Reset();
        }

        private void OpenSnackBar()
        {
            Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomCenter;
            Snackbar.Add("Thanks for your reservation. We will contact you as soon as possible.", Severity.Normal);
        }

        private void SendEmail(string to)
        {
            var fromAddress = new MailAddress("og1806x9@gmail.com", "Fjósið");
            var toAddress = new MailAddress(to, "Fjósið");
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
