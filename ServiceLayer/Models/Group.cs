using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class Group
    {
        private static int _noCounter = 100;
        public string No { get; }
        private List<Student> students;
        public Group()
        {
            No = "AP" + _noCounter++;
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
           students.Add(student);
        }
        public List<Student> GetStudents()
        {
            return students;

        }
        public List<Student> Sort()
        {
            List<Student> sortStudents = students.OrderBy(s => s.Point).ToList();
            return sortStudents;
        }
       
    }
}
