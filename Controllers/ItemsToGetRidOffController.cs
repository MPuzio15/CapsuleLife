
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ItemsToGetRidOff.Data;
using ItemsToGetRidOff.Models;
using AutoMapper;
using ItemsToGetRidOff.Dtos;
using Microsoft.AspNetCore.JsonPatch;

namespace ItemsToGetRidOff.Controllers
{
    //api/itemsToGetRidOff
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsToGetRidOffController : ControllerBase
    {
        private readonly IItemsRepo _repository;
        private IMapper _mapper;

        // constructor: 
        public ItemsToGetRidOffController(IItemsRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<ItemReadDto>> GetAllItems()
        {
            var allItems = _repository.GetAllItems();
            return Ok(_mapper.Map<List<ItemReadDto>>(allItems));
        }
        [HttpGet("{id}", Name = "GetItemById")]
        public ActionResult<ItemReadDto> GetItemById(int id)
        {
            var item = _repository.GetItemById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<ItemReadDto>(item));
            }
            return NotFound();

        }
        // POST api/itemsToGetRidOff
        [HttpPost]
        public ActionResult<ItemReadDto> CreateItem(ItemCreateDto itemCreateDto)
        {
            var itemModel = _mapper.Map<ItemToGetRidOff>(itemCreateDto);
            _repository.CreateItem(itemModel);
            _repository.SaveChanges();

            var itemReadDto = _mapper.Map<ItemReadDto>(itemModel);

            return CreatedAtRoute(nameof(GetItemById), new { Id = itemReadDto.Id }, itemReadDto);
        }

        // PUT api/itemsToGetRidOff/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateItem(int id, ItemUpdateDto itemUpdateDto)
        {
            var itemModelFromRepo = _repository.GetItemById(id);
            if (itemModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(itemUpdateDto, itemModelFromRepo);
            // don't ned to do that but it;s a good practice 
            _repository.UpdateItem(itemModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        // PATCH api/itemsToGetRidOff/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialItemUpdate(int id, JsonPatchDocument<ItemUpdateDto> patchDoc)
        {
            var itemModelFromRepo = _repository.GetItemById(id);
            if (itemModelFromRepo == null)
            {
                return NotFound();
            }
            var itemToPatch = _mapper.Map<ItemUpdateDto>(itemModelFromRepo);
            patchDoc.ApplyTo(itemToPatch, ModelState);
            if (!TryValidateModel(itemToPatch))
            {
                return ValidationProblem(ModelState);
            };
            _mapper.Map(itemToPatch, itemModelFromRepo);
            _repository.UpdateItem(itemModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        // DELETE api/itemsToGetRidOff/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(int id)
        {
            var itemModelFromRepo = _repository.GetItemById(id);
            if (itemModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteItem(itemModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

    }
}