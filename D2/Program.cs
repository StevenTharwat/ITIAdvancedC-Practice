namespace D2
{
    internal class Program
    {
        public static void RunSeries(ISeries s, int n)
        {
            for (int i = 0 ; i < n ; i++)
            {
                Console.WriteLine(s.GetTheNext());
            }
        }

        static void Main(string[] args)
        {
            //SingleTon single1 = SingleTon.GetObj("10.10.10.10");
            //SingleTon single2 = SingleTon.GetObj("20.20.20.20");
            //SingleTon single3 = SingleTon.GetObj("30.30.30.30");

            //Console.WriteLine(single1.GetHashCode());
            //Console.WriteLine(single2.GetHashCode());
            //Console.WriteLine(single3.GetHashCode());

            //Console.WriteLine(single1.GetIp());
            //Console.WriteLine(single2.GetIp());
            //Console.WriteLine(single3.GetIp());
            //ISeries es = new EventSeries();
            //ISeries os = new OddSeries();
            //ISeries fs = new FibSeries();
            //RunSeries(es, 10);
            //Console.WriteLine("=======================");
            //RunSeries(os, 10);
            //Console.WriteLine("=======================");
            //RunSeries(fs, 10);

            Employee[] emps = new Employee[3];
            emps[0] = new Employee(0, secLevel.DBA, 521472.2, new HiringDate(20, 3, 2020), Gender.Male);
            emps[1] = new Employee(1, secLevel.Guest, 5472.47, new HiringDate(30, 5, 2000), Gender.Female);
            Employee emp3 = new Employee(2, secLevel.Guest, 87472.54, new HiringDate(10, 11, 2010), Gender.Male);
            emp3.Level |= secLevel.Developer;
            emp3.Level |= secLevel.Secretary;
            emp3.Level |= secLevel.DBA;
            emps[2] = emp3;
            Array.Sort(emps);
            foreach (Employee emp in emps)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine($"you have made {Counts.Boxing} Boxing, and {Counts.UnBoxing} UnBoxing");

            Console.WriteLine("=======================");
            readFromUSer();
        }

        static void readFromUSer()
        {
            Counts.Boxing = 0;
            Counts.UnBoxing = 0;

            Console.WriteLine("Enter the numbers of employees you want to add");
            int empCount = int.Parse(Console.ReadLine());
            Employee[] emps = new Employee[empCount];
            for (int i = 0 ; i < empCount ; i++)
            {
                emps[i] = new Employee();
                Console.WriteLine("enter the employee ID");
                emps[i].ID = int.Parse(Console.ReadLine());

                Console.WriteLine("enter the employee Level Security");
                emps[i].Level = (secLevel) Enum.Parse(typeof(secLevel), Console.ReadLine());
                string userInput = "";
                while (true)
                {
                    Console.WriteLine($"this employee has::{emps[i].Level}");
                    Console.WriteLine($"if you want to add or remove level just type it or '-1' to add other Employee data");
                    userInput = Console.ReadLine();
                    if (userInput.Trim() == "-1") break;
                    emps[i].Level ^= (secLevel) Enum.Parse(typeof(secLevel), userInput);
                }

                Console.WriteLine("enter the employee Salary");
                emps[i].Salary = double.Parse(Console.ReadLine());

                Console.WriteLine("enter the Date seperated by / ");
                string[] d = Console.ReadLine().Split("/");
                emps[i].Date = new HiringDate(byte.Parse(d[0]), byte.Parse(d[1]), short.Parse(d[2]));

                Console.WriteLine("enter the employee Gender");
                emps[i].Gender = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine());
            }

            foreach (Employee emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("========= After Sorting =============");
            Array.Sort(emps);
            foreach (Employee emp in emps)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine($"you have made {Counts.Boxing} Boxing, and {Counts.UnBoxing} UnBoxing");

        }
    }
}
