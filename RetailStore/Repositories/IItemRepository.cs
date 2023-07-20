using RetailStore.Models.Domain;

namespace RetailStore.Repositories
{
    public interface IItemRepository
    {
        public IEnumerable<Item> GetAllItem();
        public Item GetById(int id);
        public void Insert(Item item);
        public void Update(int id);
        public void Delete(int id);
        public void Save();
        public Item Search(string name);
    }
}
