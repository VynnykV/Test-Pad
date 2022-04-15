using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestPad.BLL.Interfaces;
using TestPad.Common.DTO.Test;

namespace TestPad.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class TestsController : ControllerBase
{
    private readonly ITestService _testService;

    public TestsController(ITestService testService)
    {
        _testService = testService;
    }

    [HttpGet("allShuffled")]
    public async Task<ActionResult<ICollection<TestDto>>> GetAllAsync([FromQuery] int takeQuantity)
    {
        return Ok(await _testService.GetAllAsync(true, takeQuantity));
    }
}