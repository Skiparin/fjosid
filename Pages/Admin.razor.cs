using Microsoft.AspNetCore.Routing.Constraints;
using System.IO;
using static MudBlazor.CategoryTypes;

namespace Fjosid.Pages
{
    public partial class Admin
    {
        private string searchString1 = "";

        private DateTime? _date { get; set; } = DateTime.Now;
        private List<DateTime> _dates = new List<DateTime>();
        private const string FILENAME = "dates.txt";

        protected override async Task OnInitializedAsync()
        {
            LoadData();
            await base.OnInitializedAsync();
        }

        private void AddDateClick()
        {
            if (_date.HasValue && _dates.Any(d => d.Date == _date.Value.Date) == false)
            {
                _dates.Add(_date.Value);
                SaveData();
                LoadData();

                _date = null;
            }
        }

        private void RemoveDateClick(DateTime dateTime)
        {
            _dates.Remove(dateTime);
            SaveData();
            LoadData();
        }

        private bool FilterFunc1(DateTime element) => FilterFunc(element, searchString1);

        private bool FilterFunc(DateTime element, string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (element.ToShortDateString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }

        private bool IsDateDisabledFunc(DateTime element) => _dates.Any(d => d.Date == element.Date);

        private void SaveData()
        {
            using (StreamWriter writetext = new StreamWriter(FILENAME))
            {
                foreach (DateTime element in _dates.OrderBy(e => e))
                {
                    if (element > DateTime.Now.AddDays(-1))
                    {
                        writetext.WriteLine(element.Date.ToString());
                    }
                }
            }
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
    }
}
