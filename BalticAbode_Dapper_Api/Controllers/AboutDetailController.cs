using BalticAbode_Dapper_Api.Dtos.AboutDetailDtos;
using BalticAbode_Dapper_Api.Dtos.CategoryDtos;
using BalticAbode_Dapper_Api.Repositories.AboutRepository;
using BalticAbode_Dapper_Api.Repositories.CategoryRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BalticAbode_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutDetailController : ControllerBase
    {
        private readonly IAboutDetailRepository _aboutDetailRepository;

        public AboutDetailController(IAboutDetailRepository aboutDetailRepository)
        {
            _aboutDetailRepository = aboutDetailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> AboutDetailList()
        {
            var values = await _aboutDetailRepository.GetAllAboutDetailAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAboutDetail(CreateAboutDetailDto createAboutDetailDto)
        {
            _aboutDetailRepository.CreateAboutDetail(createAboutDetailDto);
            return Ok("About section was added succefully");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAboutDetail(int id)
        {
            _aboutDetailRepository.DeleteAboutDetail(id);
            return Ok("About section was deleted succefully");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAboutDetail(UpdateAboutDetailDto updateAboutDetailDto)
        {
            _aboutDetailRepository.UpdateAboutDetail(updateAboutDetailDto);
            return Ok("About section was updated succefully");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutDetail(int id)
        {
            var values = await _aboutDetailRepository.GetAboutDetail(id);
            return Ok(values);
        }
    }
}
