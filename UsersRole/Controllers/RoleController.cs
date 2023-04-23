using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersRole.DAL;
using UsersRole.DTOs.RoleDTOs;
using UsersRole.DTOs.UserDTOs;
using UsersRole.Model;

namespace UsersRole.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly MyContext _userCtx;
        private readonly IMapper _mapper;
        public RoleController(MyContext userCtx, IMapper mapper)
        {
            _userCtx = userCtx;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Add([FromBody] RoleToAddDto dto)
        {
            Role entity=_mapper.Map<Role>(dto);
            List<Permission> permissions = _userCtx.Permissions.Where(n => dto.PermissionIds.Contains(n.Id)).ToList();
            entity.Permissions = permissions;
            _userCtx.Roles.Add(entity);
            _userCtx.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            Role role = _userCtx.Roles.Include(n=>n.Permissions).SingleOrDefault(n=>n.RoleId==id);
            RoleToListDto data = _mapper.Map<RoleToListDto>(role);
            return Ok(role);
        }
    }
}
