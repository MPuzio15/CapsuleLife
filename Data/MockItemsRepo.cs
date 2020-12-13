using System.Collections.Generic;
using ItemsToGetRidOff.Models;
using ItemsToGetRidOff.Data;
using System.Linq;

namespace ItemsToGetRidOff.Data
{
    public class MockItemsRepo : IItemsRepo
    {
        public void CreateItem(ItemToGetRidOff cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteItem(ItemToGetRidOff itm)
        {
            throw new System.NotImplementedException();
        }

        public List<ItemToGetRidOff> GetAllItems()
        {
            var items = new List<ItemToGetRidOff>
            {
                new ItemToGetRidOff{Id=0, Name="książki", IsComplete=false},
                new ItemToGetRidOff{Id=1, Name="ciuchy",  IsComplete=false},
                new ItemToGetRidOff{Id=2, Name="express",  IsComplete=false},
                new ItemToGetRidOff{Id=3, Name="suszarki i prostownice",  IsComplete=false},
                new ItemToGetRidOff{Id=4, Name="laptopy",  IsComplete=false},
            };
            return items;
        }

        public ItemToGetRidOff GetItemById(int Id)
        {
            return new ItemToGetRidOff { Id = 4, Name = "laptopy", IsComplete = false };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateItem(ItemToGetRidOff itm)
        {
            throw new System.NotImplementedException();
        }
    }
}