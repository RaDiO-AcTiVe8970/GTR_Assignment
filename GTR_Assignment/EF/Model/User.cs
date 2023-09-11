using GTR_Assignment.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GTR_Assignment.EF.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
