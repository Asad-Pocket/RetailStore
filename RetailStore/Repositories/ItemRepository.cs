using RetailStore.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using NuGet.Protocol;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RetailStore.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly DatabaseContext _ctx;
        public ItemRepository(DatabaseContext _context)
        {
            _ctx = _context;
        }
        public void Delete(int id)
        {

                var item = _ctx.ItemList.Find(id);
                if (item != null)
                {
                    _ctx.Remove(item);
                    _ctx.SaveChanges();
                }
            
        }

        public IEnumerable<Item> GetAllItem()
        {
            var items = _ctx.ItemList.ToList();
            return items;
        }

        public Item GetById(int id)
        {
            var it = _ctx.ItemList.Find(id);
            return it;
        }
        public Item Search(String name)
        {
            var its = _ctx.ItemList.Find(name);
            return its;
        }
        public void Insert(Item item)
        {
            if (item != null)
                _ctx.ItemList.Add(item);
              
        }
        public void Update(int id)
        {
            var it = _ctx.ItemList.Find(id);
            _ctx.ItemList.Update(it);
            
             
        }
        public void Save()
        {
            _ctx.SaveChanges();
        }
       
    }
}
