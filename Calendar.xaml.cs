using CrossCalendar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossCalendar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calendar : Frame
    {
        public List<DateCalendar> listDatesCalendar;
        public DateTime SelectedDate;
        public bool ShowOnlyListDates;
        public Calendar()
        {
            InitializeComponent();
            ShowOnlyListDates = false;
            SelectedDate = DateTime.Now;
            listDatesCalendar = new List<DateCalendar>
            {
                new DateCalendar { Day = SelectedDate },
            };

            ChangeDate(SelectedDate, listDatesCalendar);
        }

        public void ChangeDate(DateTime date, List<DateCalendar> dates)
        {
            OSAppTheme appTheme = Application.Current.RequestedTheme;
            var listDays = ResultDates(date);

            Context.Event00Text = listDays[0].Skip(0).Take(1).First().Day.ToString();
            Context.Event01Text = listDays[1].Skip(0).Take(1).First().Day.ToString();
            Context.Event02Text = listDays[2].Skip(0).Take(1).First().Day.ToString();
            Context.Event03Text = listDays[3].Skip(0).Take(1).First().Day.ToString();
            Context.Event04Text = listDays[4].Skip(0).Take(1).First().Day.ToString();
            Context.Event05Text = listDays[5].Skip(0).Take(1).First().Day.ToString();
            Context.Event06Text = listDays[6].Skip(0).Take(1).First().Day.ToString();

            Context.Event10Text = listDays[0].Skip(1).Take(1).First().Day.ToString();
            Context.Event11Text = listDays[1].Skip(1).Take(1).First().Day.ToString();
            Context.Event12Text = listDays[2].Skip(1).Take(1).First().Day.ToString();
            Context.Event13Text = listDays[3].Skip(1).Take(1).First().Day.ToString();
            Context.Event14Text = listDays[4].Skip(1).Take(1).First().Day.ToString();
            Context.Event15Text = listDays[5].Skip(1).Take(1).First().Day.ToString();
            Context.Event16Text = listDays[6].Skip(1).Take(1).First().Day.ToString();

            Context.Event20Text = listDays[0].Skip(2).Take(1).First().Day.ToString();
            Context.Event21Text = listDays[1].Skip(2).Take(1).First().Day.ToString();
            Context.Event22Text = listDays[2].Skip(2).Take(1).First().Day.ToString();
            Context.Event23Text = listDays[3].Skip(2).Take(1).First().Day.ToString();
            Context.Event24Text = listDays[4].Skip(2).Take(1).First().Day.ToString();
            Context.Event25Text = listDays[5].Skip(2).Take(1).First().Day.ToString();
            Context.Event26Text = listDays[6].Skip(2).Take(1).First().Day.ToString();

            Context.Event30Text = listDays[0].Skip(3).Take(1).First().Day.ToString();
            Context.Event31Text = listDays[1].Skip(3).Take(1).First().Day.ToString();
            Context.Event32Text = listDays[2].Skip(3).Take(1).First().Day.ToString();
            Context.Event33Text = listDays[3].Skip(3).Take(1).First().Day.ToString();
            Context.Event34Text = listDays[4].Skip(3).Take(1).First().Day.ToString();
            Context.Event35Text = listDays[5].Skip(3).Take(1).First().Day.ToString();
            Context.Event36Text = listDays[6].Skip(3).Take(1).First().Day.ToString();

            Context.Event40Text = listDays[0].Skip(4).Take(1).First().Day.ToString();
            Context.Event41Text = listDays[1].Skip(4).Take(1).First().Day.ToString();
            Context.Event42Text = listDays[2].Skip(4).Take(1).First().Day.ToString();
            Context.Event43Text = listDays[3].Skip(4).Take(1).First().Day.ToString();
            Context.Event44Text = listDays[4].Skip(4).Take(1).First().Day.ToString();
            Context.Event45Text = listDays[5].Skip(4).Take(1).First().Day.ToString();
            Context.Event46Text = listDays[6].Skip(4).Take(1).First().Day.ToString();

            Context.Event00AutomationId = listDays[0].Skip(0).Take(1).First().ToString();
            Context.Event01AutomationId = listDays[1].Skip(0).Take(1).First().ToString();
            Context.Event02AutomationId = listDays[2].Skip(0).Take(1).First().ToString();
            Context.Event03AutomationId = listDays[3].Skip(0).Take(1).First().ToString();
            Context.Event04AutomationId = listDays[4].Skip(0).Take(1).First().ToString();
            Context.Event05AutomationId = listDays[5].Skip(0).Take(1).First().ToString();
            Context.Event06AutomationId = listDays[6].Skip(0).Take(1).First().ToString();

            Context.Event10AutomationId = listDays[0].Skip(1).Take(1).First().ToString();
            Context.Event11AutomationId = listDays[1].Skip(1).Take(1).First().ToString();
            Context.Event12AutomationId = listDays[2].Skip(1).Take(1).First().ToString();
            Context.Event13AutomationId = listDays[3].Skip(1).Take(1).First().ToString();
            Context.Event14AutomationId = listDays[4].Skip(1).Take(1).First().ToString();
            Context.Event15AutomationId = listDays[5].Skip(1).Take(1).First().ToString();
            Context.Event16AutomationId = listDays[6].Skip(1).Take(1).First().ToString();

            Context.Event20AutomationId = listDays[0].Skip(2).Take(1).First().ToString();
            Context.Event21AutomationId = listDays[1].Skip(2).Take(1).First().ToString();
            Context.Event22AutomationId = listDays[2].Skip(2).Take(1).First().ToString();
            Context.Event23AutomationId = listDays[3].Skip(2).Take(1).First().ToString();
            Context.Event24AutomationId = listDays[4].Skip(2).Take(1).First().ToString();
            Context.Event25AutomationId = listDays[5].Skip(2).Take(1).First().ToString();
            Context.Event26AutomationId = listDays[6].Skip(2).Take(1).First().ToString();

            Context.Event30AutomationId = listDays[0].Skip(3).Take(1).First().ToString();
            Context.Event31AutomationId = listDays[1].Skip(3).Take(1).First().ToString();
            Context.Event32AutomationId = listDays[2].Skip(3).Take(1).First().ToString();
            Context.Event33AutomationId = listDays[3].Skip(3).Take(1).First().ToString();
            Context.Event34AutomationId = listDays[4].Skip(3).Take(1).First().ToString();
            Context.Event35AutomationId = listDays[5].Skip(3).Take(1).First().ToString();
            Context.Event36AutomationId = listDays[6].Skip(3).Take(1).First().ToString();

            Context.Event40AutomationId = listDays[0].Skip(4).Take(1).First().ToString();
            Context.Event41AutomationId = listDays[1].Skip(4).Take(1).First().ToString();
            Context.Event42AutomationId = listDays[2].Skip(4).Take(1).First().ToString();
            Context.Event43AutomationId = listDays[3].Skip(4).Take(1).First().ToString();
            Context.Event44AutomationId = listDays[4].Skip(4).Take(1).First().ToString();
            Context.Event45AutomationId = listDays[5].Skip(4).Take(1).First().ToString();
            Context.Event46AutomationId = listDays[6].Skip(4).Take(1).First().ToString();

            var backGroundColor = Color.Transparent;
            var selectedColor = Color.FromHex("#00A8F0");

            Context.Event00BackgroundColor = dates.Where(x => x.Day.Date == listDays[0].Skip(0).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event01BackgroundColor = dates.Where(x => x.Day.Date == listDays[1].Skip(0).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event02BackgroundColor = dates.Where(x => x.Day.Date == listDays[2].Skip(0).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event03BackgroundColor = dates.Where(x => x.Day.Date == listDays[3].Skip(0).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event04BackgroundColor = dates.Where(x => x.Day.Date == listDays[4].Skip(0).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event05BackgroundColor = dates.Where(x => x.Day.Date == listDays[5].Skip(0).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event06BackgroundColor = dates.Where(x => x.Day.Date == listDays[6].Skip(0).Take(1).First().Date).Any() ? selectedColor : backGroundColor;

            Context.Event10BackgroundColor = dates.Where(x => x.Day.Date == listDays[0].Skip(1).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event11BackgroundColor = dates.Where(x => x.Day.Date == listDays[1].Skip(1).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event12BackgroundColor = dates.Where(x => x.Day.Date == listDays[2].Skip(1).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event13BackgroundColor = dates.Where(x => x.Day.Date == listDays[3].Skip(1).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event14BackgroundColor = dates.Where(x => x.Day.Date == listDays[4].Skip(1).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event15BackgroundColor = dates.Where(x => x.Day.Date == listDays[5].Skip(1).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event16BackgroundColor = dates.Where(x => x.Day.Date == listDays[6].Skip(1).Take(1).First().Date).Any() ? selectedColor : backGroundColor;

            Context.Event20BackgroundColor = dates.Where(x => x.Day.Date == listDays[0].Skip(2).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event21BackgroundColor = dates.Where(x => x.Day.Date == listDays[1].Skip(2).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event22BackgroundColor = dates.Where(x => x.Day.Date == listDays[2].Skip(2).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event23BackgroundColor = dates.Where(x => x.Day.Date == listDays[3].Skip(2).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event24BackgroundColor = dates.Where(x => x.Day.Date == listDays[4].Skip(2).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event25BackgroundColor = dates.Where(x => x.Day.Date == listDays[5].Skip(2).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event26BackgroundColor = dates.Where(x => x.Day.Date == listDays[6].Skip(2).Take(1).First().Date).Any() ? selectedColor : backGroundColor;

            Context.Event30BackgroundColor = dates.Where(x => x.Day.Date == listDays[0].Skip(3).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event31BackgroundColor = dates.Where(x => x.Day.Date == listDays[1].Skip(3).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event32BackgroundColor = dates.Where(x => x.Day.Date == listDays[2].Skip(3).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event33BackgroundColor = dates.Where(x => x.Day.Date == listDays[3].Skip(3).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event34BackgroundColor = dates.Where(x => x.Day.Date == listDays[4].Skip(3).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event35BackgroundColor = dates.Where(x => x.Day.Date == listDays[5].Skip(3).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event36BackgroundColor = dates.Where(x => x.Day.Date == listDays[6].Skip(3).Take(1).First().Date).Any() ? selectedColor : backGroundColor;

            Context.Event40BackgroundColor = dates.Where(x => x.Day.Date == listDays[0].Skip(4).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event41BackgroundColor = dates.Where(x => x.Day.Date == listDays[1].Skip(4).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event42BackgroundColor = dates.Where(x => x.Day.Date == listDays[2].Skip(4).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event43BackgroundColor = dates.Where(x => x.Day.Date == listDays[3].Skip(4).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event44BackgroundColor = dates.Where(x => x.Day.Date == listDays[4].Skip(4).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event45BackgroundColor = dates.Where(x => x.Day.Date == listDays[5].Skip(4).Take(1).First().Date).Any() ? selectedColor : backGroundColor;
            Context.Event46BackgroundColor = dates.Where(x => x.Day.Date == listDays[6].Skip(4).Take(1).First().Date).Any() ? selectedColor : backGroundColor;

            var textColor = Color.FromHex("#222222");
            var unselectedtextColor = Color.FromHex("#899099");

            Context.Event00TextColor = dates.Where(x => x.Day.Date == listDays[0].Skip(0).Take(1).First().Date).Any() ? Color.White : (listDays[0].Skip(0).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event01TextColor = dates.Where(x => x.Day.Date == listDays[1].Skip(0).Take(1).First().Date).Any() ? Color.White : (listDays[1].Skip(0).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event02TextColor = dates.Where(x => x.Day.Date == listDays[2].Skip(0).Take(1).First().Date).Any() ? Color.White : (listDays[2].Skip(0).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event03TextColor = dates.Where(x => x.Day.Date == listDays[3].Skip(0).Take(1).First().Date).Any() ? Color.White : (listDays[3].Skip(0).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event04TextColor = dates.Where(x => x.Day.Date == listDays[4].Skip(0).Take(1).First().Date).Any() ? Color.White : (listDays[4].Skip(0).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event05TextColor = dates.Where(x => x.Day.Date == listDays[5].Skip(0).Take(1).First().Date).Any() ? Color.White : (listDays[5].Skip(0).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event06TextColor = dates.Where(x => x.Day.Date == listDays[6].Skip(0).Take(1).First().Date).Any() ? Color.White : (listDays[6].Skip(0).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);

            Context.Event10TextColor = dates.Where(x => x.Day.Date == listDays[0].Skip(1).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event11TextColor = dates.Where(x => x.Day.Date == listDays[1].Skip(1).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event12TextColor = dates.Where(x => x.Day.Date == listDays[2].Skip(1).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event13TextColor = dates.Where(x => x.Day.Date == listDays[3].Skip(1).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event14TextColor = dates.Where(x => x.Day.Date == listDays[4].Skip(1).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event15TextColor = dates.Where(x => x.Day.Date == listDays[5].Skip(1).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event16TextColor = dates.Where(x => x.Day.Date == listDays[6].Skip(1).Take(1).First().Date).Any() ? Color.White : textColor;

            Context.Event20TextColor = dates.Where(x => x.Day.Date == listDays[0].Skip(2).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event21TextColor = dates.Where(x => x.Day.Date == listDays[1].Skip(2).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event22TextColor = dates.Where(x => x.Day.Date == listDays[2].Skip(2).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event23TextColor = dates.Where(x => x.Day.Date == listDays[3].Skip(2).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event24TextColor = dates.Where(x => x.Day.Date == listDays[4].Skip(2).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event25TextColor = dates.Where(x => x.Day.Date == listDays[5].Skip(2).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event26TextColor = dates.Where(x => x.Day.Date == listDays[6].Skip(2).Take(1).First().Date).Any() ? Color.White : textColor;

            Context.Event30TextColor = dates.Where(x => x.Day.Date == listDays[0].Skip(3).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event31TextColor = dates.Where(x => x.Day.Date == listDays[1].Skip(3).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event32TextColor = dates.Where(x => x.Day.Date == listDays[2].Skip(3).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event33TextColor = dates.Where(x => x.Day.Date == listDays[3].Skip(3).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event34TextColor = dates.Where(x => x.Day.Date == listDays[4].Skip(3).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event35TextColor = dates.Where(x => x.Day.Date == listDays[5].Skip(3).Take(1).First().Date).Any() ? Color.White : textColor;
            Context.Event36TextColor = dates.Where(x => x.Day.Date == listDays[6].Skip(3).Take(1).First().Date).Any() ? Color.White : textColor;

            Context.Event40TextColor = dates.Where(x => x.Day.Date == listDays[0].Skip(4).Take(1).First().Date).Any() ? Color.White : (listDays[0].Skip(4).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event41TextColor = dates.Where(x => x.Day.Date == listDays[1].Skip(4).Take(1).First().Date).Any() ? Color.White : (listDays[1].Skip(4).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event42TextColor = dates.Where(x => x.Day.Date == listDays[2].Skip(4).Take(1).First().Date).Any() ? Color.White : (listDays[2].Skip(4).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event43TextColor = dates.Where(x => x.Day.Date == listDays[3].Skip(4).Take(1).First().Date).Any() ? Color.White : (listDays[3].Skip(4).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event44TextColor = dates.Where(x => x.Day.Date == listDays[4].Skip(4).Take(1).First().Date).Any() ? Color.White : (listDays[4].Skip(4).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event45TextColor = dates.Where(x => x.Day.Date == listDays[5].Skip(4).Take(1).First().Date).Any() ? Color.White : (listDays[5].Skip(4).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);
            Context.Event46TextColor = dates.Where(x => x.Day.Date == listDays[6].Skip(4).Take(1).First().Date).Any() ? Color.White : (listDays[6].Skip(4).Take(1).First().Month == date.Month ? textColor : unselectedtextColor);

            Context.Event00Opacity = dates.Where(x => x.Day.Date == listDays[0].Skip(0).Take(1).First().Date).Any() ? (listDays[0].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event01Opacity = dates.Where(x => x.Day.Date == listDays[1].Skip(0).Take(1).First().Date).Any() ? (listDays[1].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event02Opacity = dates.Where(x => x.Day.Date == listDays[2].Skip(0).Take(1).First().Date).Any() ? (listDays[2].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event03Opacity = dates.Where(x => x.Day.Date == listDays[3].Skip(0).Take(1).First().Date).Any() ? (listDays[3].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event04Opacity = dates.Where(x => x.Day.Date == listDays[4].Skip(0).Take(1).First().Date).Any() ? (listDays[4].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event05Opacity = dates.Where(x => x.Day.Date == listDays[5].Skip(0).Take(1).First().Date).Any() ? (listDays[5].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event06Opacity = dates.Where(x => x.Day.Date == listDays[6].Skip(0).Take(1).First().Date).Any() ? (listDays[6].Skip(0).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;

            Context.Event40Opacity = dates.Where(x => x.Day.Date == listDays[0].Skip(4).Take(1).First().Date).Any() ? (listDays[0].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event41Opacity = dates.Where(x => x.Day.Date == listDays[1].Skip(4).Take(1).First().Date).Any() ? (listDays[1].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event42Opacity = dates.Where(x => x.Day.Date == listDays[2].Skip(4).Take(1).First().Date).Any() ? (listDays[2].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event43Opacity = dates.Where(x => x.Day.Date == listDays[3].Skip(4).Take(1).First().Date).Any() ? (listDays[3].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event44Opacity = dates.Where(x => x.Day.Date == listDays[4].Skip(4).Take(1).First().Date).Any() ? (listDays[4].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event45Opacity = dates.Where(x => x.Day.Date == listDays[5].Skip(4).Take(1).First().Date).Any() ? (listDays[5].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
            Context.Event46Opacity = dates.Where(x => x.Day.Date == listDays[6].Skip(4).Take(1).First().Date).Any() ? (listDays[6].Skip(4).Take(1).First().Month == date.Month ? 1 : 0.8) : 1;
        }

        public List<List<DateTime>> ResultDates(DateTime date)
        {
            List<List<DateTime>> listDates = new List<List<DateTime>>();

            var dates = Enumerable.Range(1, DateTime.DaysInMonth(date.Year, date.Month)).Select(n => new DateTime(date.Year, date.Month, n)).ToList();

            var sundays = (from d in dates
                           where d.DayOfWeek == DayOfWeek.Sunday
                           select d).First();

            var saturdays = (from d in dates
                             where d.DayOfWeek == DayOfWeek.Saturday
                             select d).First();

            var beginSunday = sundays.Date > saturdays.Date ? sundays.Date.AddDays(-7).Date : sundays;

            listDates.Add(CompareDates(beginSunday, 0, date));
            listDates.Add(CompareDates(beginSunday, 1, date));
            listDates.Add(CompareDates(beginSunday, 2, date));
            listDates.Add(CompareDates(beginSunday, 3, date));
            listDates.Add(CompareDates(beginSunday, 4, date));
            listDates.Add(CompareDates(beginSunday, 5, date));
            listDates.Add(CompareDates(beginSunday, 6, date));

            return listDates;
        }

        private List<DateTime> CompareDates(DateTime beginSunday, int day, DateTime currentTime)
        {
            var dates = new List<DateTime>();

            beginSunday = beginSunday.AddDays(day);
            dates.Add(beginSunday);
            dates.Add(beginSunday.AddDays(7));
            dates.Add(beginSunday.AddDays(14));
            dates.Add(beginSunday.AddDays(21));
            dates.Add(beginSunday.AddDays(28));

            return dates;
        }

        private void ButtonPrevDate_Clicked(object sender, EventArgs e)
        {
            AddMonthBtn(-1);
        }

        private void ButtonNextDate_Clicked(object sender, EventArgs e)
        {
            AddMonthBtn(1);
        }

        private void AddMonthBtn(int Month)
        {
            SelectedDate = SelectedDate.Date.AddMonths(Month);
            Context.DateText = SelectedDate;

            ChangeDate(SelectedDate, listDatesCalendar);
        }

        private void ButtonSetDate_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            SelectedDate = DateTime.Parse(btn.AutomationId);
            if (ShowOnlyListDates)
            {
                if (btn.BackgroundColor == Color.FromHex("#00A8F0"))
                    ChangeDate(SelectedDate, listDatesCalendar);
            }
            else
            {
                if (listDatesCalendar.Any()) listDatesCalendar.Clear();
                listDatesCalendar.Add(new DateCalendar { Day = SelectedDate });
                ChangeDate(SelectedDate, listDatesCalendar);
            }
            Context.DateText = SelectedDate;
        }
    }
}