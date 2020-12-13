using System.ComponentModel.DataAnnotations;

namespace ItemsToGetRidOff.Dtos
{
    public class ItemCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public bool IsComplete { get; set; }
    }
}