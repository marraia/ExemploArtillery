using System;

namespace Artillery.Domain.Entities
{
    public class Person
    {
        public Person(string cpf, string name, DateTime birthday)
        {
            Id = Guid.NewGuid();
            Cpf = cpf;
            Name = name;
            Birthday = birthday;
        }

        public Guid Id { get; private set; }
        public string Cpf { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public DateTime Birthday { get; private set; }

        public void CalculateAge()
        {
            Age = (DateTime.Now.Year - Birthday.Year);
        }
    }
}
