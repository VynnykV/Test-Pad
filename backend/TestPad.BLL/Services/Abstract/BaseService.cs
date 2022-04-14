using AutoMapper;
using TestPad.DAL.Context;

namespace TestPad.BLL.Services.Abstract;

public abstract class BaseService
{
    private protected readonly TestPadContext _context;
    private protected readonly IMapper _mapper;

    public BaseService(TestPadContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
}