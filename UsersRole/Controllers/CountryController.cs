using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsersRole.BLL.Abstract;
using UsersRole.DTOs.CountryDTOs;

namespace UsersRole.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<CountryToListDto> dtos = _countryService.Get();
            return Ok(dtos);
        }
        [HttpPost]
        public IActionResult Add([FromBody] CountryToAddDto dto)
        {
            _countryService.Add(dto);
            return Ok();
        }
    }
}
