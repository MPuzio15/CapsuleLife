using System.ComponentModel.DataAnnotations;

namespace ItemsToGetRidOff.Dtos
{
    public class ItemReadDto
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}