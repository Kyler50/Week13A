using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }

        public Room Room;

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string profession;

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public Employee()
        {
            Room = null;
        }

        public Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
            Room = null;
        }

        public override string ToString()
        {
            return base.ToString() +
                   string.Format(", salary: {0},  profession: {1}, room: {2}", salary, profession, Room.Number);
        }

    }

    class Room
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Room(int number)
        {
            this.number = number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
