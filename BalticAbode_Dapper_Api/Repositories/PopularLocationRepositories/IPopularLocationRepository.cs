using BalticAbode_Dapper_Api.Dtos.BottomGridDtos;
using BalticAbode_Dapper_Api.Dtos.PopularLocationDtos;
using BalticAbode_Dapper_Api.Dtos.ServiceDtos;

namespace BalticAbode_Dapper_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocation();
        Task CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        Task DeletePopularLocation(int id);
        Task UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIDPopularLocationDto> GetPopularLocation(int id);

    }
}
