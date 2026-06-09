using apbd_test_2.Data;
using apbd_test_2.DTOs;
using Microsoft.EntityFrameworkCore;

namespace apbd_test_2.Services;

public class MembersService : IMembersService
{
    private readonly BooksDbContext _booksDbContext;

    public MembersService(BooksDbContext booksDbContext)
    {
        _booksDbContext = booksDbContext;
    }
    public async Task<List<MemberDto>> GetMembersAsync(string? email)
    {
        var membersQuery = _booksDbContext.Members.AsNoTracking();
        if (email is not null)
        {
            membersQuery = membersQuery.Where(m => m.Email == email);
        }
        var members = await membersQuery.Select(m => new MemberDto
        {
            FirstName = m.FirstName,
            LastName = m.LastName,
            Email = m.Email,
            Phone = m.Phone,
            Borrowings = m.Borrowings.Select(b => new BorrowingDto
            {
                BorrowingId = b.BorrowingId,
                Book = new BookDto
                {
                    BookId = b.Book.BookId,
                    Title = b.Book.Title,
                    ISBN = b.Book.ISBN,
                    PublishedYear = b.Book.PublishedYear,
                    Author = new AuthorDto
                    {
                        FirstName = b.Book.Author.FirstName,
                        LastName = b.Book.Author.LastName,
                        Country = b.Book.Author.Country
                    }
                },
                BorrowDate = b.BorrowDate,
                ReturnDate = b.ReturnDate,
                Status = b.Status
            }).ToList()
        }).ToListAsync();
        return members;
    }
}