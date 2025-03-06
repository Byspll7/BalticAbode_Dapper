using BalticAbode_Dapper_Api.Dtos.AboutDetailDtos;
using BalticAbode_Dapper_Api.Dtos.AboutDtos;
using BalticAbode_Dapper_Api.Dtos.CategoryDtos;
using BalticAbode_Dapper_Api.Models.DapperContext;
using Dapper;

namespace BalticAbode_Dapper_Api.Repositories.AboutRepository
{
    public class AboutDetailRepository : IAboutDetailRepository
    {
        private readonly Context _context;

        public AboutDetailRepository(Context context)
        {
            _context = context;
        }

        public void CreateAboutDetail(CreateAboutDetailDto createAboutDetailDto)
        {
            string query = "insert into AboutDetail (Title,SubTitle,Description1,Description2) values (@title,@subtitle,@description1,@description2)";
            var parameters = new DynamicParameters();   
            parameters.Add("@title", createAboutDetailDto.Title);
            parameters.Add("@subtitle", createAboutDetailDto.SubTitle);
            parameters.Add("@description1", createAboutDetailDto.Description1);
            parameters.Add("@description2", createAboutDetailDto.Description2);
            using(var connection =_context.CreateConnection())
            {
                connection.Execute(query,parameters);
            }   
        }

        public async void DeleteAboutDetail(int id)
        {
            string query = "delete from AboutDetail where DetailId=@detailId";
            var parameters = new DynamicParameters();
            parameters.Add("@detailId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<GetByIDAboutDto> GetAboutDetail(int id)
        {
            string query = "select * from AboutDetail where DetailId=@detailId";
            var parameters = new DynamicParameters();
            parameters.Add("@detailId", id);
            using (var connection = _context.CreateConnection())
                            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDAboutDto>(query, parameters);
                return values;
            }   
        }

        public async Task<List<ResultAboutDetailDto>> GetAllAboutDetailAsync()
        {
            string query = "select * from AboutDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultAboutDetailDto>(query);
                return values.ToList();
            }
        }

        public async  void UpdateAboutDetail(UpdateAboutDetailDto updateAboutDetailDto)
        {
            string query = "update AboutDetail set Ttile=@title,Subtitle=@subTitle,Description1=@description1,Description2=@description2 where DetailId=@detailId";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateAboutDetailDto.Title);
            parameters.Add("@subTitle", updateAboutDetailDto.SubTitle);
            parameters.Add("@description1", updateAboutDetailDto.Description1);
            parameters.Add("@description2", updateAboutDetailDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
