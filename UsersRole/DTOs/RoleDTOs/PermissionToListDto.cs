namespace UsersRole.DTOs.RoleDTOs
{
    public record PermissionToListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
    }
}
