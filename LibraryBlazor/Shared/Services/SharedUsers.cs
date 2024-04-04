using LibraryBlazorApp.Data;

namespace LibraryBlazorApp.Shared.Services
{
    public class SharedUsers : ISharedUsers
    {
        public List<User> Users { get; set; } = new List<User>();
    }
}
