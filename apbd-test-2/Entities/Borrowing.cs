using System.ComponentModel.DataAnnotations;

namespace apbd_test_2.Entities;

public class Borrowing
{
    public int BorrowingId { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    [MaxLength(50)]
    public string Status { get; set; } = null!;
    public int MemberId { get; set; }
    public Member Member { get; set; } = null!;
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
}