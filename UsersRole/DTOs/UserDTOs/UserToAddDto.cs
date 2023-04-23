using UsersRole.DTOs.RoleDTOs;

namespace UsersRole.DTOs.UserDTOs
{
    public record UserToAddDto
    {
        public string FullName { get; set; }
        public RoleToAddDto role { get; set; }
    }
}
