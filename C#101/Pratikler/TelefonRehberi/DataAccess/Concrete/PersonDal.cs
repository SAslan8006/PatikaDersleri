using System.Collections.Generic;
using TelefonRehberi.DataAccess.Abstract;
using TelefonRehberi.Entities;

namespace TelefonRehberi.DataAccess.Concrete
{
    public class PersonDal : IPersonDal
    {
        private List<Person> persons = new()
        {
            new Person{Id=1,Name="Musa",Surname="Uyumaz",PhoneNumber="5457899632"},
            new Person{Id=2,Name="Engin",Surname="Demiroğ",PhoneNumber="5458564632"},
            new Person{Id=3,Name="Zikriye",Surname="Ürkmez",PhoneNumber="5416325689"},
            new Person{Id=4,Name="Gökhan",Surname="Kandemir",PhoneNumber="5487963214"},
            new Person{Id=5,Name="Sadık",Surname="Turan",PhoneNumber="5069874563"},
        };
        public void Add(Person person)
        {
            persons.Add(person);
            System.Console.WriteLine(person.Name +" Rehbere Eklendi");
        }

        public void Delete(Person person)
        {
            var silinecekPerson = persons.Find(x=>x.Id == person.Id);
            persons.Remove(silinecekPerson);
        }

        public List<Person> GetAll()
        {
            return persons;
        }

        public Person GetByNameOrSurname(string nameOrSurname)
        {
            var person =persons.Find(x=>x.Name == nameOrSurname || x.Surname == nameOrSurname);
            return person;
        }

        public Person GetByNumber(string phoneNumber)
        {
            var person =persons.Find(x=>x.PhoneNumber == phoneNumber);
            return person;
        }

        public void Update(Person person)
        {
          
           var guncellenecekPerson = persons.Find(x=>x.Id == person.Id);
           guncellenecekPerson.Name = person.Name;
           guncellenecekPerson.Surname = person.Surname;
           guncellenecekPerson.PhoneNumber = person.PhoneNumber;
           System.Console.WriteLine(person.Name +" Rehbere Eklendi");
        }
    }
}