using System.ComponentModel.DataAnnotations;

namespace apbd_test_2.Entities;

public class Book
{
    public int BookId { get; set; }
    [MaxLength(200)]
    public string Title { get; set; } = null!;
    [MaxLength(13)]
    public string ISBN { get; set; } = null!;
    public int PublishedYear { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; } = null!;
    public List<Review> Reviews = new();
    public List<Borrowing> Borrowings = new();
}