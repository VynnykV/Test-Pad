using TestPad.Common.DTO.Test;

namespace TestPad.BLL.Interfaces;

public interface ITestService
{
    Task<ICollection<TestDto>> GetAllAsync(bool shuffle, int? takeQuantity = null);
}