using BalticAbode_Dapper_Api.Dtos.BottomGridDtos;
using BalticAbode_Dapper_Api.Dtos.PopularLocationDtos;

namespace BalticAbode_Dapper_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
   
    }
}
