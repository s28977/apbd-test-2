using apbd_test_2.Services;
using Microsoft.AspNetCore.Mvc;

namespace apbd_test_2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
    private readonly IMembersService _membersService;

    public MembersController(IMembersService membersService)
    {
        _membersService = membersService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetMembers([FromQuery] string? email)
    {
        var members = await _membersService.GetMembersAsync(email);
        return Ok(members);
    }
}