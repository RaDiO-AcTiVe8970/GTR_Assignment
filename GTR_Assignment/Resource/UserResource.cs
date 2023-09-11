namespace GTR_Assignment.Resource
{
    public class UserResource
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
        public int RoleId { get; init; }
        public DateTime CreatedAt { get; init; } = DateTime.Now;
        public DateTime UpdatedAt { get; init; } = DateTime.Now;
    }
}
