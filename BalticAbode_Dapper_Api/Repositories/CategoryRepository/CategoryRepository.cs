using BalticAbode_Dapper_Api.Dtos.CategoryDtos;
using BalticAbode_Dapper_Api.Models.DapperContext;
using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BalticAbode_Dapper_Api.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context; 
        }

        public async void CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (CategoryName,CategoryStatus) values (@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query,parameters);
            }
        }

        public async void DeleteCategory(int id)
        {
            string query="delete from Category where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "select * from Category";
            using(var connection =_context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDCategoryDto> GetCategory(int id)
        {
            string query = "select * from Category where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using(var connection = _context.CreateConnection())
            {
                var values= await connection.QueryFirstOrDefaultAsync<GetByIDCategoryDto>(query,parameters);
                return values;
            }   
        }

        public async void UpdateCategory(UpdateCategoryDto categoryDto)
        {
            string query = "update Category set CategoryName=@categoryName,CategoryStatus=@categoryStatus where CategoryId=@categoryId";
            var parameters = new DynamicParameters();   
            parameters.Add("@categoryName", categoryDto.CategoryName);  
            parameters.Add("@categoryStatus", categoryDto.CategoryStatus);
            parameters.Add("@categoryId", categoryDto.CategoryId);
            using (var connection = _context.CreateConnection())
            {
               await connection.ExecuteAsync(query, parameters);
            }   
        }
    }
}
