using Microsoft.AspNetCore.Identity;

namespace BlazorCloudStorage.Model;

public class User : IdentityUser
{
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string SaltPassword { get; set; }
}