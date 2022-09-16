using System.Collections.Generic;
using ToDoUygulamasi.Entities.Concrete;

namespace ToDoUygulamasi.Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person Get(int id);
    }
}