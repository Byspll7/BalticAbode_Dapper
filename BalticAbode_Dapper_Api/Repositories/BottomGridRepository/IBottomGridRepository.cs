using BalticAbode_Dapper_Api.Dtos.BottomGridDtos;
using BalticAbode_Dapper_Api.Dtos.ServiceDtos;

namespace BalticAbode_Dapper_Api.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        Task<GetButtomGridDto> GetService(int id);
    }
}
