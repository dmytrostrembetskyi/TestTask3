using Microsoft.EntityFrameworkCore;

namespace Core.Contexts;

public class ArtsofteContext : DbContext
{
    public ArtsofteContext(DbContextOptions options) : base(options)
    {
    }
}