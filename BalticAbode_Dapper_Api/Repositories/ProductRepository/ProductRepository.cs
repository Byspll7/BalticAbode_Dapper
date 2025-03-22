using BalticAbode_Dapper_Api.Dtos.CategoryDtos;
using BalticAbode_Dapper_Api.Dtos.ProductDtos;
using BalticAbode_Dapper_Api.Models.DapperContext;
using Dapper;

namespace BalticAbode_Dapper_Api.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "select * from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "select ProductID,Title,Price,City,District,CategoryName,CoverImage,DealOfTheDay,Type,Address from Product inner join Category on Product.ProductCategory=Category.CategoryID";

            using (var connection = _context.CreateConnection())
            {
               var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public  async void ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            string query = "update Product set DealOfTheDay = 0 where ProductID = @ProductID";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void ProductDealOfTheDayStatusChangeTotTrue(int id)
        {
            string query = "update Product set DealOfTheDay = 1 where ProductID = @ProductID";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

    }
}
