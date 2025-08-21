# 12. Serialization in .NET

## Task 1
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

### Tests
**Test 1**
- **Test:**

Student s = new Student("Jack", 89.08f, new Group("Math", 1, new Student("Jim", 83, null)));

Console.WriteLine(s.Serialize());

- **Expected:**

{
  "Full name": "Jack",
  "Rating": 89.08000183105469,
  "Group": {
    "Name": "Math",
    "Id": 1,
    "Leader": {
      "Full name": "Jim",
      "Rating": 83
    }
  }
}

- **Got:**
{
  "Full name": "Jack",
  "Rating": 89.08000183105469,
  "Group": {
    "Name": "Math",
    "Id": 1,
    "Leader": {
      "Full name": "Jim",
      "Rating": 83
    }
  }
}

---

**Test 2**
- **Test:**

Student sa = new Student("Anna", 73.54, null);

sa.Group= new Group("Mechanics", 1, new Student("Tom", 83.09, null));

string serialized = sa.Serialize();

Console.WriteLine(serialized);

var deserializedStudent = Student.Deserialize(serialized);

Console.WriteLine(deserializedStudent.Id);

Console.WriteLine(deserializedStudent.Name);

Console.WriteLine(deserializedStudent.Rating);

Console.WriteLine(deserializedStudent.Group.Id);

Console.WriteLine(deserializedStudent.Group.Leader.Id);

Console.WriteLine(deserializedStudent.Group.Leader.Name);

Console.WriteLine(deserializedStudent.Group.Leader.Rating);

- **Expected:**

{
  "Full name": "Anna",
  "Rating": 73.54,
  "Group": {
    "Name": "Mechanics",
    "Id": 1,
    "Leader": {
      "Full name": "Tom",
      "Rating": 83.09
    }
  }
}
0
Anna
73.54
1
0
Tom
83.09

- **Got:**

{
  "Full name": "Anna",
  "Rating": 73.54,
  "Group": {
    "Name": "Mechanics",
    "Id": 1,
    "Leader": {
      "Full name": "Tom",
      "Rating": 83.09
    }
  }
}
0
Anna
73.54
1
0
Tom
83.09

---