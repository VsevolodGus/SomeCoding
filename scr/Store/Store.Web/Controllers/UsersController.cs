using Microsoft.AspNetCore.Mvc;
using Store.DAL.Entities;
using Store.DAL.Interfaces;

namespace Store.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IReadonlyRepository<User> _userRepository;

    public UsersController(IReadonlyRepository<User> userRepository)
    {
        _userRepository = userRepository;
    }
    
    [HttpGet]
    public async Task<User[]> GetArrayAsync()
        => await _userRepository.ToArrayAsync(HttpContext.RequestAborted);

}
