using System;
using System.Collections.ObjectModel;

namespace CanadianHolidaysApp.ViewModels
{
    public class HolidayViewModel
    {
        public ObservableCollection<Holiday> Holidays { get; private set; }

        public HolidayViewModel()
        {
            Holidays = new ObservableCollection<Holiday>
            {
                new Holiday { Name = "New Year's Day", Date = new DateTime(DateTime.Now.Year, 1, 1) },
                new Holiday { Name = "Heritage Day", Date = new DateTime(DateTime.Now.Year, 2, 20) },
                new Holiday { Name = "Valentine's Day", Date = new DateTime(DateTime.Now.Year, 2, 14) },
                new Holiday { Name = "Canada Day", Date = new DateTime(DateTime.Now.Year, 7, 1) },
                new Holiday { Name = "Mother's Day", Date = new DateTime(DateTime.Now.Year, 5, 14) },
                new Holiday { Name = "Father's Day", Date = new DateTime(DateTime.Now.Year, 6, 18) },
                new Holiday { Name = "Thanksgiving", Date = new DateTime(DateTime.Now.Year, 10, 11) },
                new Holiday { Name = "Remembrance Day", Date = new DateTime(DateTime.Now.Year, 11, 11) },
                new Holiday { Name = "Christmas Day", Date = new DateTime(DateTime.Now.Year, 12, 25) },
                new Holiday { Name = "Boxing Day", Date = new DateTime(DateTime.Now.Year, 12, 26) }
            };
        }
    }

    public class Holiday
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
