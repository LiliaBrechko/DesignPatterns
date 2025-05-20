using System.Collections;

namespace Iterator
{
    class DaysInMonthCollection : IEnumerable<MonthWithDays>
    {
        private readonly int startYear;
        private readonly int endYear;

        public DaysInMonthCollection(int startYear, int endYear)
        {
            this.startYear = startYear;
            this.endYear = endYear;
        }

        public IEnumerator<MonthWithDays> GetEnumerator()
        {
            return new DaysInMonthEnumerator(startYear, endYear);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
