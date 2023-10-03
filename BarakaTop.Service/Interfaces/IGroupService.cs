using BarakaTop.Service.DTOs.Group;
using BarakaTop.Service.DTOs.User;

namespace BarakaTop.Service.Interfaces;

public interface IGroupService
{
    Task<GroupResultDto> AddAsync(GroupCreationDto dto);
    Task<GroupResultDto> ModifyAsync(GroupUpdateDto dto);
    Task<bool> RemoveAsync(long id);
    Task<GroupResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<GroupResultDto>> RetrieveAllAsync();
}
