using ItemsToGetRidOff.Models;
using System.Collections.Generic;

namespace ItemsToGetRidOff.Data
{
    public interface IItemsRepo
    {
        bool SaveChanges();
        ItemToGetRidOff GetItemById(int Id);
        List<ItemToGetRidOff> GetAllItems();
        void CreateItem(ItemToGetRidOff itm);
        void UpdateItem(ItemToGetRidOff itm);
        void DeleteItem(ItemToGetRidOff itm);
    }
}