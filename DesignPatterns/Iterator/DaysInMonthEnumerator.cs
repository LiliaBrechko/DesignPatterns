using System.Collections;

namespace Iterator
{
    class DaysInMonthEnumerator : IEnumerator<MonthWithDays>
    {
        private readonly int startYear;
        private readonly int endYear;
        private int year;
        private int month;

        public DaysInMonthEnumerator(int startYear, int endYear)
        {
            if (startYear > endYear)
            {
                throw new ArgumentException("startYear должен быть меньше или равен endYear");
            }

            this.startYear = startYear;
            this.endYear = endYear;
            this.year = startYear;
            this.month = 0;
        }

        public MonthWithDays Current =>
            new MonthWithDays
            {
                Date = new DateTime(year, month, 1),
                Days = DateTime.DaysInMonth(year, month)
            };

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            return year <= endYear;
        }

        public void Reset()
        {
            year = startYear;
            month = 0;
        }

        public void Dispose() { }
    }

}
