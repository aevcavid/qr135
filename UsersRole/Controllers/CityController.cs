using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsersRole.BLL.Abstract;
using UsersRole.BLL.Concrete;
using UsersRole.DTOs.CityDTOs;
using UsersRole.DTOs.CountryDTOs;

namespace UsersRole.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly Service _cityservice;
        public CityController(Service cityservice)
        {
            _cityservice = cityservice; 
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<CityToListDto> dtos = _cityservice.Get();
            return Ok(dtos);

        }
        [HttpPost]
        public IActionResult Add([FromBody] CityToAddDto dto)
        {
            _cityservice.Add(dto);
            return Ok();
        }
    }
}
