/* task_1
Please, implement the Filter method that takes IEnumerable<Student> parameter.

 * Student class is already implemented:

 * The Filter method should select students that have rating more than 75 and study Math or English

 * The Group name should written in uppercase for students in result collection.
 */

using System;

namespace task_1
{
    public class Student
    {
        public int Rating { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public List<string> Subjects { get; } = new List<string>();
        public override bool Equals(object obj)
        {
            if (obj is Student otherStudent)
            {
                return Name == otherStudent.Name && Rating == otherStudent.Rating && Group == otherStudent.Group;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Rating;
        }
    }

    public class Program
    {
        public static IEnumerable<Student> Filter(IEnumerable<Student> students)
        {

            return students
                .Where(s => s.Rating > 75 &&
                            s.Subjects.Any(sub => sub == "Math" || sub == "English"))
                .Select(s =>
                {
                    var newStudent = new Student
                    {
                        Name = s.Name,
                        Rating = s.Rating,
                        Group = s.Group.ToUpper()
                    };
                    newStudent.Subjects.AddRange(s.Subjects);
                    return newStudent;
                });
        }
    }
}
