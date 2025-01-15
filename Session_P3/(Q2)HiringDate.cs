namespace TaskSession_P3;

public class _Q2_HiringDate
{
        private int Day { get; set; }
        private int Month { get; set; }
        private int Year { get; set; }
        public _Q2_HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"Day: {Day} \nMonth: {Month} \nYear: {Year}";
        }
}