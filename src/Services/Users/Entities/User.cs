using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Services.Users.Entities
{
    /// <summary>
    /// Presents a user entity in the database.
    /// </summary>
    [Table("Person")]
    public class User
    {
        [Key, Required]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Avatar { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Website { get; set; }
    }
}
