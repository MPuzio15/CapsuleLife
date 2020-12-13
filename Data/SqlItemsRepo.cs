using System;
using System.Collections.Generic;
using System.Linq;
using ItemsToGetRidOff.Models;

namespace ItemsToGetRidOff.Data
{
    public class SqlItemsRepo : IItemsRepo
    {
        private readonly GetRidOffContext _context;

        public SqlItemsRepo(GetRidOffContext context)
        {
            _context = context;
        }

        public void CreateItem(ItemToGetRidOff item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            _context.Items.Add(item);
        }

        public void DeleteItem(ItemToGetRidOff item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            _context.Items.Remove(item);
        }

        public List<ItemToGetRidOff> GetAllItems()
        {
            return _context.Items.ToList();
        }

        public ItemToGetRidOff GetItemById(int Id)
        {
            return _context.Items.FirstOrDefault(p => p.Id == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateItem(ItemToGetRidOff item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
        }
    }
}