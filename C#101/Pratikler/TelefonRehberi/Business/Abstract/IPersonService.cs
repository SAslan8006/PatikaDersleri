using System.Collections.Generic;
using TelefonRehberi.Entities;

namespace TelefonRehberi.Business.Abstract
{
    public interface IPersonService
    {
        void Add(Person person);
         void Delete(Person person);
         void Update(Person person);
         List<Person> GetAll();
         Person GetByNumber(string phoneNumber);
         Person GetByNameOrSurname(string nameOrSurname);
    }
}