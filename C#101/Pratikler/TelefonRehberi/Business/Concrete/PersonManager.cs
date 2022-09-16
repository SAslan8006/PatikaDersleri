using System.Collections.Generic;
using TelefonRehberi.Business.Abstract;
using TelefonRehberi.DataAccess.Abstract;
using TelefonRehberi.Entities;

namespace TelefonRehberi.Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public void Add(Person person)
        {
            _personDal.Add(person);
        }

        public void Delete(Person person)
        {
            _personDal.Delete(person);
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }

        public Person GetByNameOrSurname(string nameOrSurname)
        {
           return _personDal.GetByNameOrSurname(nameOrSurname);
        }

        public Person GetByNumber(string phoneNumber)
        {
            return _personDal.GetByNumber(phoneNumber);
        }

        public void Update(Person person)
        {
            _personDal.Update(person);
        }
    }
}