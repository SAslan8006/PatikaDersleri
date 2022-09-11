using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);
        Category Add(Category category);
        Category Update(Category category);
        void TransactionalOperation(Category category, Category category1);
    }
}
