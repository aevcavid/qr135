using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsersRole.DAL;
using UsersRole.DTOs.UserDTOs;
using UsersRole.Model;

namespace UsersRole.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MyContext _userCtx;
        private readonly IMapper _mapper;
        public UserController(MyContext userCtx, IMapper mapper)
        {
            _userCtx = userCtx;
            _mapper = mapper;
        }

       

        [HttpGet]
        public IActionResult Get([FromBody] User user)
        {
            List<User> entity = _userCtx.Users.ToList();
            List<UserToListDto> dtos = _mapper.Map<List<UserToListDto>>(user);
            return Ok(dtos);
        }
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            User usr = _userCtx.Users.Find(id);
            UserToListDto data = _mapper.Map<UserToListDto>(usr);
            return Ok(usr); 
        }
        [HttpPost]
        public IActionResult Add([FromBody] UserToAddDto dto)
        {
            try
            {
                User data = _mapper.Map<User>(dto);

                _userCtx.Users.Add(data);
                _userCtx.SaveChanges();
                return Ok(data);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UserToUpdateDto userTo)
        {
            User data = _mapper.Map<User>(userTo);
            data.Id= id;
            _userCtx.Users.Update(data);
            _userCtx.SaveChanges();
            return Ok();
        }

    }
}
