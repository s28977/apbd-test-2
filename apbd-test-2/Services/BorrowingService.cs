using apbd_test_2.Data;
using apbd_test_2.DTOs;
using apbd_test_2.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace apbd_test_2.Services;

public class BorrowingService : IBorrowingsService
{
    
    private readonly BooksDbContext _booksDbContext;

    public BorrowingService(BooksDbContext booksDbContext)
    {
        _booksDbContext = booksDbContext;
    }
    public async Task ReturnBorrowing(int id, ReturnBorrowingDto dto)
    {
        var borrowing = await _booksDbContext.Borrowings.Where(b => b.BorrowingId == id).FirstOrDefaultAsync();
        if (borrowing is null)
        {
            throw new NotFoundException("Borrowing not found");
        }

        if (dto.ReturnDate < borrowing.BorrowDate)
        {
            throw new ArgumentException("ReturnDate must be after Borrowing");
        }
    }
}