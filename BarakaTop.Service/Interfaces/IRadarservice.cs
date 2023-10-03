using BarakaTop.Service.DTOs.Radar;
using BarakaTop.Service.DTOs.User;

namespace BarakaTop.Service.Interfaces;

public interface IRadarservice
{
    Task<RadarResultDto> AddAsync(RadarCreationDto dto);
    Task<bool> RemoveAsync(long id);
    Task<UserResultDto> RetrieveByIdAsync(long id);
    Task<IEnumerable<RadarResultDto>> RetrieveAllAsync();
}
