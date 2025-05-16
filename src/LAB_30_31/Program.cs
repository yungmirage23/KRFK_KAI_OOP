using LAB_30_31.Data;
using LAB_30_31.Models;
using Microsoft.EntityFrameworkCore;

using (var dbContext = new ApplicationDbContext())
{
    //SeedAuthors(dbContext);
    //SeedCategories(dbContext);
    //SeedBooks(dbContext);


    var books = dbContext.Books
        .Include(n => n.Category)
        .Include(n => n.Author).AsEnumerable();

    Console.WriteLine("Id | Title | Year | Category Name" +
            "| Author Name | Author Surname");
    foreach (var book in books)
    {
        Console.WriteLine($"{book.Id} | {book.Title} | {book.Year} | {book.Category.Name}" +
            $"| {book.Author.Name} | {book.Author.Surname}");
    }
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
    dbContext.Authors.Add(new Author() { Name = "Author7", Surname = "Author7" });
    dbContext.Authors.Add(new Author() { Name = "Author8", Surname = "Author8" });
    dbContext.Authors.Add(new Author() { Name = "Author9", Surname = "Author9" });
    dbContext.Authors.Add(new Author() { Name = "Author10", Surname = "Author10" });

    dbContext.SaveChanges();
}


static void SeedBooks(ApplicationDbContext dbContext)
{
    for (int i = 0; i < 10; i++)
    {
        var book = new Book()
        {
            Title = $"Book {i}",
            AuthorId = i % 6 + 1,
            Year = 2000 + i,
            CategoryId = i % 6 + 1 // Assuming you have 6 categories
        };
        dbContext.Books.Add(book);
    }
    dbContext.SaveChanges();
}
Console.WriteLine();