using GreenAppleDaycare.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenAppleDaycare.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
        public DbSet<Values> values { get; set; }
        public DbSet<User> users {get;set;}
    }
}