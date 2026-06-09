using System.ComponentModel.DataAnnotations;

namespace apbd_test_2.Entities;

public class Author
{
    public int AuthorId { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;
    [MaxLength(100)]
    public string LastName { get; set; } = null!;
    [MaxLength(100)]
    public string Email { get; set; } = null!;
    [MaxLength(50)]
    public string Country { get; set; } = null!;
    public int BirthYear { get; set; }
    public List<Book> Books = new();
}