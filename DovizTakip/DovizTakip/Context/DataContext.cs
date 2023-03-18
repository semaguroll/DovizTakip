using DovizTakip.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DovizTakip.Context
{
    public class DataContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DataContext(DbContextOptions<DataContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<CurrencyModel> Currencies { get; set; }
    }
}
