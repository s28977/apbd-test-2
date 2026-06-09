using System.ComponentModel.DataAnnotations;

namespace apbd_test_2.DTOs;

public class MemberDto
{
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;
    [MaxLength(100)]
    public string LastName { get; set; } = null!;
    [MaxLength(100)]
    [EmailAddress]
    public string Email { get; set; } = null!;
    [MaxLength(9)]
    [Phone]
    public string Phone { get; set; } = null!;

    public List<BorrowingDto> Borrowings { get; set; } = new();
}

public class BorrowingDto
{
    public int BorrowingId { get; set; }
    public BookDto Book { get; set; } = null!;
    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    [MaxLength(50)]
    public string Status { get; set; } = null!;
}

public class BookDto
{
    public int BookId { get; set; }
    [MaxLength(200)]
    public string Title { get; set; } = null!;
    [MaxLength(13)]
    public string ISBN { get; set; } = null!;
    public int PublishedYear { get; set; }
    public AuthorDto Author { get; set; } = null!;
}

public class AuthorDto
{
    public string FirstName { get; set; } = null!;
    [MaxLength(100)]
    public string LastName { get; set; } = null!;
    [MaxLength(50)]
    public string Country { get; set; } = null!;
}