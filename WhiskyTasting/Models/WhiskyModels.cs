using System.Data.Entity;

namespace WhiskyTasting.Models
{
    public class Whisky
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Age { get; set; }
        public string Distillery { get; set; }
        public float Price { get; set; }
    }

    public class WhiskyDbContext : DbContext
    {
        public DbSet<Whisky> Whiskys { get; set; }

    }
}