using System.ComponentModel.DataAnnotations;

namespace apbd_test_2.Entities;

public class Member
{
    public int MemberId { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;
    [MaxLength(100)]
    public string LastName { get; set; } = null!;
    [MaxLength(100)]
    public string Email { get; set; } = null!;
    [MaxLength(9)]
    public string Phone { get; set; } = null!;
    public List<Review> Reviews = new();
    public List<Borrowing> Borrowings = new();
}