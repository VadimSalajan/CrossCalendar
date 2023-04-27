using CrossCalendar.Data;
using CrossCalendar.Services;
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
        public bool CalIsInPopUp;
        public IGraphic _graphic;
        public delegate void CalendarDelegate(object sender, EventArgs e);
        public event CalendarDelegate ClickedDate;

        public Calendar()
        {
            InitializeComponent();
            _graphic = new Graphic(Context);
            ShowOnlyListDates = false;
            SelectedDate = DateTime.Now;
            
            _graphic.BackGroundColorBtn = Color.Transparent;
            _graphic.SelectedColorBtn = Color.FromHex("#00A8F0");
            _graphic.ColorTextBtn = Color.FromHex("#222222");
            _graphic.SelectedColorTextBtn = Color.White;
            _graphic.UnSelectedColorTextBtn = Color.FromHex("#899099");
            
            listDatesCalendar = new List<DateCalendar>
            {
                new DateCalendar { Day = SelectedDate },
            };

            _graphic.ChangeDate(SelectedDate, listDatesCalendar);
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

            _graphic.ChangeDate(SelectedDate, listDatesCalendar);
        }

        private async void ButtonSetDate_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            SelectedDate = DateTime.Parse(btn.AutomationId);
            if (ShowOnlyListDates)
            {
                if (btn.BackgroundColor == Color.FromHex("#00A8F0"))
                {
                    _graphic.ChangeDate(SelectedDate, listDatesCalendar);
                    if (CalIsInPopUp) await Navigation.PopModalAsync();
                }
            }
            else
            {
                if (listDatesCalendar.Any()) listDatesCalendar.Clear();
                listDatesCalendar.Add(new DateCalendar { Day = SelectedDate });
                _graphic.ChangeDate(SelectedDate, listDatesCalendar);
                if (CalIsInPopUp) await Navigation.PopModalAsync();
            }
            Context.DateText = SelectedDate;
            ClickedDate.Invoke(sender, e);
        }
    }
}