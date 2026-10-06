using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record student
    {
        public int identty { get; set; }
        public string name { get; set; }
        public int numTest { get; set; }
        public int grade { get; set; }
        public student() { }
        public student(int identty, string name, int numTest, int grade)
        {
            this.identty = identty;
            this.name = name;
            this.numTest = numTest;
            this.grade = grade;
        }
        public override string ToString()
        {
            return $"Student ID: {identty}, Name: {name}, Number of Tests: {numTest}, Grade: {grade}";

        }
    }
}
