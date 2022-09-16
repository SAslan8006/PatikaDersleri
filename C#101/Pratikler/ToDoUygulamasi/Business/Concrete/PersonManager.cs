using System.Collections.Generic;
using ToDoUygulamasi.Business.Abstract;
using ToDoUygulamasi.DataAccess.Abstract;
using ToDoUygulamasi.Entities.Concrete;

namespace ToDoUygulamasi.Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public List<Person> GetAll()
        {
           return _personDal.GetAll();
        }
        public Person Get(int id)
        {
            return _personDal.Get(id);
        }
    }
}