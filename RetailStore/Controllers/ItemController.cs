using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RetailStore.Models.Domain;
using RetailStore.Repositories;

namespace RetailStore.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _repository;
        public ItemController(IItemRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddItem()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddItem(Item _item) 
        {
            _repository.Insert(_item);
            _repository.Save();
            return View();
        }
       
        public IActionResult DisplayItems()
        {
            var _list = _repository.GetAllItem().ToList();
            return View(_list);
        }
        public IActionResult EditItem(int id)
        {
            _repository.Update(id);
            _repository.Save();
            return View();
        }
       
       
        public IActionResult DeleteItem(int id)
        {
            _repository.Delete(id);
            _repository.Save();
            return View(DisplayItems());
        }
        public IActionResult SearchItem()
        {
            return View();
        }
    }
}
