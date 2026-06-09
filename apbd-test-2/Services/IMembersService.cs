using apbd_test_2.DTOs;

namespace apbd_test_2.Services;

public interface IMembersService
{
    public Task<List<MemberDto>> GetMembersAsync(string? email);
}