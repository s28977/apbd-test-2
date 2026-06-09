using apbd_test_2.Entities;
using Microsoft.EntityFrameworkCore;

namespace apbd_test_2.Data;

public class BooksDbContext : DbContext
{
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Borrowing> Borrowings => Set<Borrowing>();
    public DbSet<Member> Members => Set<Member>();
    public DbSet<Review> Reviews => Set<Review>();

    public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.BookId });
        });
    }
}