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
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int RoleId { get; set; }

        public virtual ICollection<ProductCart> ProductCarts { get; set; }
        public User()
        {
            ProductCarts = new HashSet<ProductCart>();
        }
    }
}
