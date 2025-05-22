namespace D2
{
    internal struct Employee : IComparable
    {
        int id;
        secLevel level;
        double salary;
        HiringDate date;
        Gender gender;
        /// <summary>
        /// The ID of the employee (must be a positive integer)
        /// </summary>
        public int ID
        {
            get => id;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid ID");
                    //Console.WriteLine("Invalid ID");
                    //return;
                }
                id = value;
            }
        }
        /// <summary>
        /// The security level of the employee (can be a combination of Guest, Developer, Secretary, and DBA)
        /// </summary>
        public secLevel Level { get => level; set => level = value; }
        /// <summary>
        /// The salary of the employee (must be a positive double)
        /// </summary>
        public double Salary
        {
            get => salary;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid Salary");
                }
                salary = value;
            }
        }
        /// <summary>
        /// The hiring date of the employee (must be a valid date)
        /// </summary>
        public HiringDate Date { get => date; set => date = value; }
        /// <summary>
        /// the Gender of the employee
        /// </summary>
        public Gender Gender { get => gender; set => gender = value; }

        /// <summary>
        /// Constructor for the Employee struct
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="_level"></param>
        /// <param name="_salary"></param>
        /// <param name="_date"></param>
        /// <param name="_gender"></param>
        public Employee(int _id, secLevel _level, double _salary, HiringDate _date, Gender _gender)
        {
            this.ID = _id;
            this.Level = _level;
            this.Salary = _salary;
            this.Date = _date;
            this.Gender = _gender;
        }

        /// <summary>
        /// override tostring method to return the employee details
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Employee with id::{ID}, level::{Level}, salary::{Salary.ToString("C")}, date::{Date}, gender:{Gender}";
        }

        /// <summary>
        /// CompareTo method to compare two Employee objects based on their hiring date
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object? obj)
        {
            Counts.Boxing++;
            Employee input = (Employee) obj;
            Counts.UnBoxing++;
            return this.date.CompareTo(input.date);
        }
    }
}
