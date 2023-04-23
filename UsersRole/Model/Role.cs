namespace UsersRole.Model
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}
