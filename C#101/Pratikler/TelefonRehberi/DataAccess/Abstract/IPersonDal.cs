using System.Collections.Generic;
using TelefonRehberi.Entities;

namespace TelefonRehberi.DataAccess.Abstract
{
    public interface IPersonDal
    {
         void Add(Person person);
         void Delete(Person person);
         void Update(Person person);
         List<Person> GetAll();
         Person GetByNumber(string phoneNumber);
         Person GetByNameOrSurname(string nameOrSurname);
    }
}