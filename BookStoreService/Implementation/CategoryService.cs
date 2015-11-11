using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreService.EF;
using BookStoreService.Interfaces;

namespace BookStoreService.Implementation
{
    public class CategoryService : ICategory
    {
        private BookStoreDbContext db = null;

        public CategoryService()
        {
            db = new BookStoreDbContext();
        }

        public List<Category> findAll()
        {
            return db.Categories.ToList();
        }

        public Category findById(long id)
        {
            return db.Categories.Find(id);
        }

        public long insert(Category entity)
        {
            try
            {
                db.Categories.Add(entity);
                db.SaveChanges();
                return entity.id;
            }
            catch
            {
                return -1;
            }
        }

        public bool update(Category entity)
        {
            try
            {
                Category cat = db.Categories.Find(entity.id);
                cat.ModifiedAt = DateTime.Now;
                cat.ModifiedBy = entity.ModifiedBy;
                cat.Name = entity.Name;
                cat.ParentID = entity.ParentID;
                cat.Status = entity.Status;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(long id)
        {
            try
            {
                Category cat = db.Categories.Find(id);
                db.Categories.Remove(cat);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
