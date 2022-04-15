using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
        IQueryable<Test> query = _context.Tests
            .Include(t => t.Questions)
            .ThenInclude(q => q.Answers);

        if (takeQuantity is not null)
        {
            query = query.Take(takeQuantity.Value);
        }

        var tests = await query.ToListAsync();

        if (shuffle)
        {
            tests.Shuffle();
        }

        return _mapper.Map<ICollection<TestDto>>(tests);
    }
}