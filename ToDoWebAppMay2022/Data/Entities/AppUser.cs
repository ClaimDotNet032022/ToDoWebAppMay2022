using Microsoft.AspNetCore.Identity;

namespace ToDoWebAppMay2022.Data.Entities
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
