using System.Collections.Generic;
using System.Linq;

namespace Homework_Theme_01
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int PersonHeight { get; set; }
        public List<string> DisciplineName { get; set; }
        public List<float> DisciplineGrades { get; set; } = new List<float>();

        public Student()
        {
            DisciplineName = new List<string> {
                "History", "mathematics", "English language"
                };
        }

        /// <summary>
        /// Returns a string representation of the student's ID, first name, last name, age, height, and average grade.
        /// </summary>
        /// <returns>A string representation of the student's information.</returns>
        public override string ToString()
        {
            float avg = DisciplineGrades.Sum() / DisciplineGrades.Count;
            return $"{Id,4} {FirstName,20} {LastName,20} {Age,10} {PersonHeight,10} {avg,10:##.##}";
        }
    }
}
