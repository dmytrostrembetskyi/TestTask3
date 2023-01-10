using Microsoft.EntityFrameworkCore;

namespace Core.Extensions;

public static class DatabaseExtension
{
    public static DbContextOptionsBuilder UseMsSqlServer(this DbContextOptionsBuilder options, string? connectionString)
    {
        return options.UseSqlServer(connectionString);
    }
}