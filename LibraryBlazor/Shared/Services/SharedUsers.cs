using LibraryBlazor.Data;

namespace LibraryBlazor.Shared.Services
{
    public class SharedUsers : ISharedUsers
    {
        public List<User> Users { get; set; } = new List<User>();
    }
}
