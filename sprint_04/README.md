# 4. Class Object. Class declaration

## Task 1
Define class Person. Class Person should contain:

a) two private fields: name and birthYear (the birthday year, as a type for this field you may use DataTime type);

b) two properties for access to these fields (you may use only get);

c) default constructor (which would assign name = "Unknown" and  birthYear = DateTime.Now) and constructor with 2 parameters (name and birthYear);

d) methods:
- Age() - to calculate the age of a person;
- Input() - to enter data about a person from the console;
- ChangeName() - to change the name of person;
- ToString();
- Output() - to provide the output of information about the person (call ToString());
- operator== (equal by name).

In the class BehaviorCheck define method Main() within which:

1) Create 6 objects of Person type and input (with Input() function) the information about them.

2) Calculate and provide the output into the console with the name and age of each person.

3) Change the name of people, whose age is less than 16, to "Very Young".

4) Output information about all people on the console.

5) Find and output information about people with the same names (use ==). In case there are no such people, provide output of the word "absent"

For example:
- **Test:** BehaviorCheck.StudentMain();
- **Input:**
A
1994
A
1995
B
2020
C
2021
D
1990
E
1980
- **Result:**
A is 31 years old.
A is 30 years old.
B is 5 years old.
C is 4 years old.
D is 35 years old.
E is 45 years old.

    Information about all persons:
Name: A, Year of Birth: 1994
Name: A, Year of Birth: 1995
Name: Very Young, Year of Birth: 2020
Name: Very Young, Year of Birth: 2021
Name: D, Year of Birth: 1990
Name: E, Year of Birth: 1980

    Persons with the same names:
Name: A, Year of Birth: 1994
Name: A, Year of Birth: 1995
Name: Very Young, Year of Birth: 2020
Name: Very Young, Year of Birth: 2021