using BlazorCloudStorage.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorCloudStorage.Context;

public class CloudDbContext(DbContextOptions<CloudDbContext> opt) : IdentityDbContext<User>(opt)
{
    public DbSet<StorageFile> Files { get; set; }
}