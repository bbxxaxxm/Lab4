using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Person
    {
        
        
        public string name;
        public int age;
        public int birthYear;
        public double gpa;

        public Person(string name, int bYear,double GPA) {
            this.name = name;
            this.birthYear = bYear;
            this.age = 2566 - bYear;
            this.gpa = GPA;
        }

        public Person()
        {
        }

        public int getAge() {
            return this.age;

        }
        public string getName()
        {
            return this.name;
        }

        public double getGpa() {
            return this.gpa;
        }

        


    }
}
