namespace UsersRole.DTOs.RoleDTOs
{
    public record RoleToByIdDto
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public List<PermissionToListDto> Permissions { get; set; }
    }
}
