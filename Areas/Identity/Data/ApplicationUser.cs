using Microsoft.AspNetCore.Identity;

namespace tcc.Areas.Identity.Data;

public class ApplicationUser : IdentityUser
{
    public string? Twitter { get; set; }
}

