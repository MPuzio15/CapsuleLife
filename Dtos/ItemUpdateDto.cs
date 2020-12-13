using System.ComponentModel.DataAnnotations;

namespace ItemsToGetRidOff.Dtos
{
    public class ItemUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public bool IsComplete { get; set; }
    }
}