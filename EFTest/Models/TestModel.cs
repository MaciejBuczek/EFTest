using System.ComponentModel.DataAnnotations;

namespace EFTest.Models
{
    public class TestModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
