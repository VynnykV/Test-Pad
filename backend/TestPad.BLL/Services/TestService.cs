using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestPad.BLL.Exceptions;
using TestPad.BLL.Interfaces;
using TestPad.BLL.Services.Abstract;
using TestPad.Common.DTO.Test;
using TestPad.Common.Extensions;
using TestPad.DAL.Context;
using TestPad.DAL.Entities;

namespace TestPad.BLL.Services;

public class TestService : BaseService, ITestService
{
    public TestService(TestPadContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<TestDto>> GetAllAsync(bool shuffle, int? takeQuantity = null)
    {
        var tests = await _context.Tests
            .Include(t => t.Questions)
            .ThenInclude(q => q.Answers)
            .ToListAsync();

        if (shuffle)
        {
            tests.Shuffle();
        }

        return _mapper.Map<ICollection<TestDto>>(takeQuantity is not null ? tests.Take(takeQuantity.Value) : tests);
    }

    public async Task<TestDto> GetAsync(int id)
    {
        var testEntity = await _context.Tests
            .Include(t => t.Questions)
            .ThenInclude(q => q.Answers)
            .FirstOrDefaultAsync(t => t.Id == id);

        if (testEntity is null)
        {
            throw new NotFoundException(nameof(Test), id);
        }

        return _mapper.Map<TestDto>(testEntity);
    }
}