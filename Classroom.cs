using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Classroom
    {
        private string name;
        private List<Person> person = new List<Person>();

        public Classroom(string name)
        {
            this.name = name;
        }

        public void addPerson2Class(Person p) { 
            this.person.Add(p);
        }

        public string showAllPersoninClass() {
            string result = "";
            foreach (Person p in this.person) {
                result += p.getName() + "\r\n";
           
            }
            return "";
        }
        public void addGPA(Person i) 
        {
            this.person.Add(i);
        }
        public string avgMaxGPA()
        {
            double totalGPA = 0;
            int count = 0;
            foreach (Person i in person)
            {
                totalGPA += i.getGpa();
                count++;
            }
            double avgGPA = totalGPA / count;
            return avgGPA.ToString();
        }

        public string minGPAName()
        {
            double totalGPA = 0;
            int count = 0;
            double minGPA = double.MaxValue;
            string name = "";
            foreach (Person g in person)
            {
                double currentGPA = g.getGpa();
                totalGPA += currentGPA;
                count++;
                if (currentGPA < minGPA)
                {
                    minGPA = currentGPA;
                    name = g.getName();
                }
            }
            return name;
        }
        public string maxGPAName()
        {
            double totalGPA = 0;
            int count = 0;
            double maxGPA = 0;
            string name = "";
            foreach (Person g in person)
            {
                double currentGPA = g.getGpa();
                totalGPA += currentGPA;
                count++;
                if (currentGPA > maxGPA)
                {
                    maxGPA = currentGPA;
                    name = g.getName();
                }
            }
            return name;
        }
    }
}
