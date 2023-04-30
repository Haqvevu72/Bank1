using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class client
    {
        // => Fileds of `client` class
        public Guid ID { get; set; }
        public string? Name  { get; set; }
        public string? Surname { get; set; }
        public short Age { get; set; }
        public int Salary { get; set; }
        public bankcard? bankaccount { get; set; }

        // => Constructor for `client` class
        public client(Guid iD, string? name, string? surname, short age, int salary, bankcard? bankaccount)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            this.bankaccount = bankaccount;
        }

        // => Overriding ToString() method 
        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nSurname: {Surname}\nAge: {Age}\nSalary: {Salary}\n{bankaccount}";
        }


    }
}
