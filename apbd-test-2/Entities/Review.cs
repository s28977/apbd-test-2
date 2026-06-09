using System.ComponentModel.DataAnnotations;

namespace apbd_test_2.Entities;

public class Review
{
    public int MemberId { get; set; }
    public Member Member { get; set; } = null!;
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
    public int Rating { get; set; }
    [MaxLength(500)]
    public string Comment { get; set; } = null!;
    public DateTime ReviewDate { get; set; }
}