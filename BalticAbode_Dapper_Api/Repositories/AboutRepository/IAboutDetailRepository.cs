using BalticAbode_Dapper_Api.Dtos.AboutDetailDtos;
using BalticAbode_Dapper_Api.Dtos.AboutDtos;
using BalticAbode_Dapper_Api.Dtos.CategoryDtos;

namespace BalticAbode_Dapper_Api.Repositories.AboutRepository
{
    public interface IAboutDetailRepository
    {
        Task<List<ResultAboutDetailDto>> GetAllAboutDetailAsync();
        void CreateAboutDetail(CreateAboutDetailDto createAboutDetailDto);
        void DeleteAboutDetail(int id);
        void UpdateAboutDetail(UpdateAboutDetailDto updateAboutDetailDto);
        Task<GetByIDAboutDto> GetAboutDetail(int id);
    }
}
