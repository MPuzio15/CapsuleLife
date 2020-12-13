using System.ComponentModel.DataAnnotations;

namespace ItemsToGetRidOff.Models
{
    public class ItemToGetRidOff
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public bool IsComplete { get; set; }
    }
}