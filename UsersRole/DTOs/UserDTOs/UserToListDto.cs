namespace UsersRole.DTOs.UserDTOs
{
    public record UserToListDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}
