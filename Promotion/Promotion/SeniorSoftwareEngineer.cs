using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotion
{
    internal class SeniorSoftwareEngineer
    {
        public SeniorSoftwareEngineer(Person Person)
        {
            this.Person = Person;
            Wage = 1200000;
            Rank = Rank.Senior;
        }
        Person person;

        int wage;

        Rank rank;
        internal Person Person { get => person; set => person = value; }
        public int Wage { get => wage; set => wage = value; }
        internal Rank Rank { get => rank; set => rank = value; }

        public override string ToString()
        {
            return String.Format($"ID: {this.Person.Id}, Name: {this.Person.Name}, Age: {this.Person.Age}, Wage: {Wage}, Rank: {Rank}");
        }
    }
}
