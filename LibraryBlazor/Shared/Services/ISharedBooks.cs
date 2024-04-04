using LibraryBlazorApp.Data;

namespace LibraryBlazorApp.Shared.Services
{
    public interface ISharedBooks
    {
        public List<Book> Books { get; set; }
    }
}
