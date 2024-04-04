using LibraryBlazor.Data;

namespace LibraryBlazor.Shared.Services
{
    public class SharedBooks : ISharedBooks
    {
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
