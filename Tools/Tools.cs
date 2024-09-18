using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorCloudStorage.Tools;

public static class Tools
{
    public static string ToReadableSize(long size)
    {
        var sizes = new[] { "B", "KB", "MB", "GB", "TB" };
        float len = size;
        var order = 0;

        while (len >= 1024 && order < sizes.Length - 1)
        {
            order++;
            len /= 1024;
        }

        return $"{len:0.##} {sizes[order]}";
    }

    public static async Task<Guid> GetUserId(AuthenticationStateProvider provider)
    {
        return Guid.Parse(
            (await provider.GetAuthenticationStateAsync()).User.FindFirst(ClaimTypes.NameIdentifier)!.Value);
    }

    public static string Salt(string data)
    {
        return Encoding.UTF8.GetString(SHA256.HashData(Encoding.UTF8.GetBytes(data)));
    }
}