using Microsoft.AspNetCore.Identity;

namespace IdentityExample.Data;

public class ApplicationUser : IdentityUser
{
    public string firstName { get; set; }
    public string lastName { get; set; }
}
