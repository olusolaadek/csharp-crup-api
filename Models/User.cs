using System.ComponentModel.DataAnnotations.Schema;
namespace Models
{
    [Table("Users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
    }
}
