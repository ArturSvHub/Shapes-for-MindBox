using TestAppForSQLPart.Models;

namespace TestAppForSQLPart
{
    public class DataSeeder
    {
        public Category[] categories = new Category[]
        {
                        new Category{Id=1,Name="Intel"},
                        new Category{Id=2,Name="AMD"},
                        new Category{Id=3,Name="Baikal"},
                        new Category{Id=4,Name="New"},
                        new Category{Id=5,Name="Used"}
        };
        public Product[] products = new Product[]
                    {
                        new Product{Id=1,Name="Core I5 10400f", Price=100},
                        new Product{Id=2,Name="Core I7 11600", Price=250},
                        new Product{Id=3,Name="Elbrus 16SV", Price=350},
                        new Product{Id=4,Name="Ryzen 5 5600X zen3", Price=100},
                        new Product{Id=5,Name="Ryzen 5 7600X zen4", Price=300}
                    };
        public Enrollment[] enrollments = new Enrollment[]
                    {
                        new Enrollment{Id = 1, ProductId=1,CategoryId=1},
                        new Enrollment{Id = 2, ProductId=1,CategoryId=5},
                        new Enrollment{Id = 3, ProductId=2,CategoryId=1},
                        new Enrollment{Id = 4, ProductId=2,CategoryId=4},
                        new Enrollment{Id = 5, ProductId=4,CategoryId=2},
                        new Enrollment{Id = 6, ProductId=4,CategoryId=5},
                        new Enrollment{Id = 7, ProductId=5,CategoryId=2},
                        new Enrollment{Id = 8, ProductId=5,CategoryId=4}
                    };
    }
}
