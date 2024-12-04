using System.ComponentModel.DataAnnotations;

namespace PostgresApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public int RoleID { get; set; }
    }
}
