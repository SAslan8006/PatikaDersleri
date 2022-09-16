namespace ToDoUygulamasi.Entities.Concrete
{
    public class Person
    {
        public Person(int id, string name, string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get{
            return this.Name+" "+this.Surname ;
        }
        }
        
        

    }

}