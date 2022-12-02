using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAppForSQLPart.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Product>().ToTable("Product");
            var seed = new DataSeeder();
            foreach(var pr in seed.products)
            {
                modelBuilder.Entity<Product>().HasData(pr);
            }
            foreach (var cat in seed.categories)
            {
                modelBuilder.Entity<Category>().HasData(cat);
            }
            foreach (var e in seed.enrollments)
            {
                modelBuilder.Entity<Enrollment>().HasData(e);
            }

        }
    }
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        List<Enrollment> Enrollments { get; set; }
    }
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public decimal Price { get; set; }
        List<Enrollment> Enrollments { get; set; }
    }
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}
