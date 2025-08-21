/* task_1
Please, create Group class with public string property Name, int Id, and Student Leader.
Create a constructor with string, int, and Student parameters for initializing the properties.

Create Student class with public int property Id, string Name, double Rating, and Group Group.

Create a constructor with string, double, and Group parameters to initialize the properties.

Implement a public Serialize method that returns a string that contains a serialized Student object in JSON format.

Student that is created like this 

    Student s = new Student("Anna", 70.1, new Group("Mechanics", 1, new Student("Tom", 60.25, null)));     * 
should be serialized into the next string:
 {
  "Full name": "Anna",
  "Rating": 70.1,
  "Group": {
    "Name": "Mechanics",
    "Id": 1,
    "Leader": {
      "Full name": "Tom",
      "Rating": 60.25
    }
  }
}
Note, that student's Id property should not be serialized and the Name property should be represented as "Full name"
Also, implement public static method Deserialize which takes a string as a parameter and returns a deserialized Worker object from it.
 */


using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace task_1
{
    public class Group
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Student Leader { get; set; }


        public Group(string name, int id, Student leader)
        {
            this.Name = name;
            this.Id = id;
            this.Leader = leader;
        }
    }

    public class Student
    {
        [JsonPropertyName("Full name")]
        public string Name { get; set; }

        [JsonIgnore]
        public int Id { get; set; }
        public double Rating { get; set; }
        public Group Group { get; set; }

        public Student(string name, double rating, Group group)
        {
            this.Name = name;
            this.Rating = rating;
            this.Group = group;
        }


        public string Serialize()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            return JsonSerializer.Serialize(this, options);
        }


        public static Student Deserialize(string json)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Deserialize<Student>(json);
        }

    }
}
