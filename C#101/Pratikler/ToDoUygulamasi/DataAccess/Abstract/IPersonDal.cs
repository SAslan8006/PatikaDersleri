using System.Collections.Generic;
using ToDoUygulamasi.Entities.Concrete;

namespace ToDoUygulamasi.DataAccess.Abstract
{
    public interface IPersonDal
    {
         List<Person> GetAll();
         Person Get(int id);
    }
}