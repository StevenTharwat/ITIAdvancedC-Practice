using System.Text;

namespace D6.Library
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"ISBN: {ISBN} ");
            sb.Append($"Title: {Title} ");
            sb.Append($"Authors: {string.Join(",", Authors)} ");
            sb.Append($"PublicationDate: {PublicationDate.ToString("dd/MM/yyyy")} ");
            sb.Append($"Price: {Price.ToString("C")} ");
            return sb.ToString();
        }
    }

}
