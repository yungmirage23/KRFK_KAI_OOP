using LAB_30_31.Data;
using LAB_30_31.Models;
using Microsoft.EntityFrameworkCore;

var dbContextOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
dbContextOptionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234");
var dbContextOptions = dbContextOptionsBuilder.Options;

using (var dbContext = new ApplicationDbContext(dbContextOptions))
{
    SeedCategories(dbContext);
    SeedBooks(dbContext);


    var books = dbContext.Books
        .Include(n=>n.Category)
        .ToList();

    dbContext.SaveChanges();
}



static void SeedCategories(ApplicationDbContext dbContext)
{
    dbContext.Categories.Add(new Category() { Name = "Fiction" });
    dbContext.Categories.Add(new Category() { Name = "Non-Fiction" });
    dbContext.Categories.Add(new Category() { Name = "Science" });
    dbContext.Categories.Add(new Category() { Name = "History" });
    dbContext.Categories.Add(new Category() { Name = "Biography" });
    dbContext.Categories.Add(new Category() { Name = "Fantasy" });
    dbContext.Categories.Add(new Category() { Name = "Mystery" });
    dbContext.SaveChanges();
}

static void SeedAuthors(ApplicationDbContext dbContext)
{
    dbContext.Authors.Add(new Author() { Name = "Author1" , Surname = "Author1"});
    dbContext.Authors.Add(new Author() { Name = "Author2", Surname = "Author2" });
    dbContext.Authors.Add(new Author() { Name = "Author3", Surname = "Author3" });
    dbContext.Authors.Add(new Author() { Name = "Author4", Surname = "Author4" });
    dbContext.Authors.Add(new Author() { Name = "Author5", Surname = "Author5" });
    dbContext.Authors.Add(new Author() { Name = "Author6", Surname = "Author6" });

    dbContext.SaveChanges();
}


static void SeedBooks(ApplicationDbContext dbContext)
{
    for (int i = 0; i < 10; i++)
    {
        var book = new Book()
        {
            Title = $"Book {i}",
            AuthorId = i,
            Year = 2000 + i,
            CategoryId = i % 6 + 1 // Assuming you have 6 categories
        };
        dbContext.Books.Add(book);
    }
    dbContext.SaveChanges();
}
Console.WriteLine();