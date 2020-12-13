using AutoMapper;
using ItemsToGetRidOff.Models;
using ItemsToGetRidOff.Dtos;


namespace ItemsToGetRidOff.Profiles
{
    public class ItemsProfile : Profile
    {
        public ItemsProfile()
        {
            CreateMap<ItemToGetRidOff, ItemReadDto>();
            CreateMap<ItemCreateDto, ItemToGetRidOff>();
            CreateMap<ItemUpdateDto, ItemToGetRidOff>();
            CreateMap<ItemToGetRidOff, ItemUpdateDto>();
        }

    }


}