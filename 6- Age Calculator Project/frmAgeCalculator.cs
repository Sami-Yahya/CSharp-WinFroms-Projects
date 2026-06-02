using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Calculator_Project
{
    public partial class frmAgeCalculator : Form
    {
        public frmAgeCalculator()
        {
            InitializeComponent();
        }

        public DateTime BirthDate = new DateTime();
        public DateTime nowDate = new DateTime();

        public (int years, int months, int days) GetAgeLine(DateTime BirthDate)
        {
            DateTime Today = DateTime.Now;

            int years = Today.Year - BirthDate.Year;
            int months = Today.Month - BirthDate.Month;
            int days = Today.Day - BirthDate.Day;

            if (days < 0)
            {
                months--;
                DateTime prevMonth = Today.AddMonths(-1);
                days += DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            return (years, months, days); 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BirthDate = dtpBirthday.Value;
            nowDate = DateTime.Now;
           // TimeSpan UserAge = nowDate - BirthDate;
            
            if (BirthDate >  nowDate)
            {
                MessageBox.Show("Not possible to choose date in the future!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int Years = nowDate.Year - BirthDate.Year;
            int Months = (Years * 12) + nowDate.Month - BirthDate.Month;
            int Days = (nowDate - BirthDate).Days; //or: UserAge.Days;
            int Weeks = Days / 7;
            int Hours = Days * 24;
            int Minutes = Hours * 60;
            int Seconds = Minutes * 60;

            lblYearLable.Text = Years.ToString();
            lblMonthLable.Text = Months.ToString();
            lblWeekLable.Text = Weeks.ToString();
            lblDayLable.Text = Days.ToString();
            lblHourLable.Text = Hours.ToString();
            lblMinutesLable.Text = Minutes.ToString();
            lblSecondsLable.Text = Seconds.ToString();

            var Age = GetAgeLine(BirthDate);
            lblAgeLine.Text = $"عمرك هو: {Age.years} سنة، {Age.months} شهر، {Age.days} يوم";
        }

        private void frmAgeCalculator_Load(object sender, EventArgs e)
        {
            var Culture = new CultureInfo("en-US");
            Culture.DateTimeFormat.Calendar = new GregorianCalendar();

            Thread.CurrentThread.CurrentCulture = Culture;
            Thread.CurrentThread.CurrentUICulture = Culture;
        }
    }
}
