using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC6dotNET46
{
    class Employee
    {
        // Field data.
        private string _empName;
        private int _empId;
        private float _currPay;
        private int _empAge;

        // Constructors.
        public Employee()
        {
        }

        public Employee(string name, int id, float pay) : this(name, 0, id, pay)
        {
        }

        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
        }

        // Methods.
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay : {0}", Pay);
        }

        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    _empName = value;
            }
        }

        public int Id
        {
            get {  return _empId; }
            set { _empId = value; }
        }

        public float Pay
        {
            get {  return _currPay; }
            set { _currPay = value; }
        }

        public int Age
        {
            get {  return _empAge; }
            set { _empAge = value; }
        }
    }
}

