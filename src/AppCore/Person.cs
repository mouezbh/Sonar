using System;

namespace AppCore
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            this.Id = Guid.NewGuid();
        }

        public Person(string name, int age)
            : this()
        {
            this.Name = name;
            this.Age = age;
        }

        public string Describe()
        {
            return $"Id = {Id}\nName = {Name}\nAge = {Age}";
        }

        public void SetAgeFromBirthDate(DateTime birthDate)
        {
            if (birthDate >= DateTime.UtcNow)
                throw new Exception();
            var diff = (DateTime.UtcNow - birthDate);

            this.Age = new DateTime(diff.Ticks).Year;
        }
    }
}