using BalticAbode_Dapper_Api.Dtos.TestimonialDto;

namespace BalticAbode_Dapper_Api.Repositories.TestimonialRepository
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}
