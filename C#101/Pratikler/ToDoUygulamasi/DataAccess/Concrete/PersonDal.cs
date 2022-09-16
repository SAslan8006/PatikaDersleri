using System.Collections.Generic;
using ToDoUygulamasi.DataAccess.Abstract;
using ToDoUygulamasi.Entities.Concrete;

namespace ToDoUygulamasi.DataAccess.Concrete
{
    public class PersonDal : IPersonDal
    {
        private List<Person> persons = new List<Person>()
    {
       new Person(1,"Musa","Uyumaz"),
       new Person(2,"Engin","Demiroğ"),
       new Person(3,"Zikriye","Ürkmez"),
       new Person(4,"Sadık","Turan"),
       new Person(5,"Atıl","Samancıloğlu"),
       new Person(6,"Ömer","Çolakoğlu"),
       new Person(7,"Gökhan","Kandemir"),

    };

        public Person Get(int id)
        {
            var bulunacakPerson = persons.Find(x=>x.Id == id);
            return bulunacakPerson;
        }

        public List<Person> GetAll()
        {
            return persons;
        }
    }
}