 using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class Student
    {
        private int _id {  get; set; }
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point {  get; set; }
        public Student(string name, string surname, int point)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                Console.WriteLine("Name and Surname cannot be empty or null.");
            }
            Id = _id++;
            Name = name;
            Surname = surname;
            Point = point;

        }
        public void ShowInfo()
        {
         Console.WriteLine($"ID: {Id} Name: {Name} Surname: {Surname} Age : {Age} Point : {Point}");
        }
        public static bool operator >(Student student1, Student student2)
        {
            return student1.Point > student2.Point;
        }
        public static bool operator <(Student student1, Student student2)
        {
            return student1.Point < student2.Point;
        }
        //uchuncu telebeni add edib muqaise etmek isdedim ama uchuncu muqaiseni ede bilmedim.
    }
}
