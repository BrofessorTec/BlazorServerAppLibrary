using LibraryBlazor.Data;

namespace LibraryBlazor.Shared.Services
{
    public interface ISharedBooks
    {
        public List<Book> Books { get; set; }
    }
}
