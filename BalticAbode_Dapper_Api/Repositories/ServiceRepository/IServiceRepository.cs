using BalticAbode_Dapper_Api.Dtos.CategoryDtos;
using BalticAbode_Dapper_Api.Dtos.ServiceDtos;

namespace BalticAbode_Dapper_Api.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto createserviceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto updateserviceDto);
        Task<GetByIDServiceDto> GetService(int id);
    }
}
