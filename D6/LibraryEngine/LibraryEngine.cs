namespace D6.Library
{
    public delegate string Pointer(Book b);
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}