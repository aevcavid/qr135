﻿namespace UsersRole.DTOs.RoleDTOs
{
    public record RoleToAddDto
    {
        public string Name { get; set; }
        public string Key { get; set; }
        public List<int> PermissionIds { get; set; }
    }
}
