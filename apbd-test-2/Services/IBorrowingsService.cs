using apbd_test_2.DTOs;

namespace apbd_test_2.Services;

public interface IBorrowingsService
{
    public Task ReturnBorrowing(int id, ReturnBorrowingDto dto);
}