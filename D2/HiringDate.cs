namespace D2
{
    internal struct HiringDate : IComparable
    {
        byte day;
        byte month;
        short year;
        /// <summary>
        /// The day of the month (1-30)
        /// </summary>
        public byte Day
        {
            get => day;
            set
            {
                if (value < 1 || value > 30) throw new Exception("Invalid Day");
                day = value;
            }
        }
        /// <summary>
        /// The month of the year (1-12)
        /// </summary>
        public byte Month
        {
            get => month;
            set
            {
                if (value < 1 || value > 12) throw new Exception("Invalid Month");
                month = value;
            }
        }
        /// <summary>
        /// The year (0-2025)
        /// </summary>
        public short Year
        {
            get => year;
            set
            {
                if (value < 0 || value > 2025) throw new Exception("Invalid Year");
                year = value;
            }
        }
        /// <summary>
        /// Constructor for the HiringDate struct
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        public HiringDate(byte day, byte month, short year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        /// <summary>
        /// Override the ToString method to return the date in the format "dd/mm/yyyy"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
        /// <summary>
        /// CompareTo method to compare two HiringDate objects
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object? obj)
        {
            Counts.Boxing++;
            HiringDate input = (HiringDate) obj;
            Counts.UnBoxing++;
            if (year > input.year) return 1;
            if (year < input.year) return -1;
            else
            {
                if (month > input.month) return 1;
                if (month < input.month) return -1;
                else
                {
                    if (day > input.day) return 1;
                    if (day < input.day) return -1;
                    return 0;
                }
            }
        }
    }
}
