using D6.Library;

namespace D6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ball ball = new();
            //Player p1 = new FootBallPlayer() { X = 5, Y = 20, Name = "Ahmed" };
            //Player p2 = new FootBallPlayer() { Name = "Aly" };
            //Player p3 = new FootBallPlayer() { Name = "Youssef" };
            //Player refree = new Refree() { Name = "Mohssen" };

            //Stadium stadium = new(ball);

            //stadium.AddPlayer(p1);
            //stadium.AddPlayer(p2);
            //stadium.AddPlayer(refree);

            //ball.ChangePosition(5, 14);

            //========================================================//

            //Department div = new("div");
            //Student std = new("zaher");
            //Student std2 = new("zaher2");
            //div.AddStudent(std);
            //std.Fail();
            //std.Fail();
            //std.Fail();


            //========================================================//

            List<Book> bookList = new()
            {
                new Book("1", "Book1", ["aly"], new DateTime(2021, 5, 1), 2986876),
                new Book("2", "Book2", ["ahmed", "steven"], new DateTime(2023, 3, 15), 45654),
                new Book("3", "Book3", ["salm"], new DateTime(2020, 10, 10), 39987)
            };
            //Pointer p = BookFunctions.GetTitle;
            //Func<Book, string> p = BookFunctions.GetTitle;
            //Func<Book, string> p = delegate (Book b)
            //{
            //    return b.ISBN;
            //};
            Func<Book, string> p = (Book b) => b.ISBN;

            LibraryEngine.ProcessBooks(bookList, p);
        }
    }
}
/*
 2. Considering the Code Below , Write Down the Body of all Listed
Methods and Properties ,
you need to Define fPtr as the following cases:
a. User Defined Delegate Datatype
b. BCL Delegates
c. Anonymous Method (GetISBN)
d. Lambda Expression (GetPublicationDate)

 */