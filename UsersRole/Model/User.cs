namespace UsersRole.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Fin { get; set; }
        public Role? Role { get; set; }
    }
}
