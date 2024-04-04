using LibraryBlazorApp.Data;

namespace LibraryBlazorApp.Shared.Services
{
    public interface ISharedUsers
    {
        public List<User> Users { get; set; }
    }
}
