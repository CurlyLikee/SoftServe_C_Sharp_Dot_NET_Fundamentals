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

### Tests
**Test 1**
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
- **Expected:**
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
- **Got:**
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

---

**Test 2**
- **Input:**
A
1990
B
1991
C
1992
D
1994
E
1995
F
1996
- **Expected:**
A is 35 years old.
B is 34 years old.
C is 33 years old.
D is 31 years old.
E is 30 years old.
F is 29 years old.

Information about all persons:
Name: A, Year of Birth: 1990
Name: B, Year of Birth: 1991
Name: C, Year of Birth: 1992
Name: D, Year of Birth: 1994
Name: E, Year of Birth: 1995
Name: F, Year of Birth: 1996

Persons with the same names:

absent

- **Got:**
A is 35 years old.
B is 34 years old.
C is 33 years old.
D is 31 years old.
E is 30 years old.
F is 29 years old.

Information about all persons:
Name: A, Year of Birth: 1990
Name: B, Year of Birth: 1991
Name: C, Year of Birth: 1992
Name: D, Year of Birth: 1994
Name: E, Year of Birth: 1995
Name: F, Year of Birth: 1996

Persons with the same names:

absent

---
**Test 3**
- **Input:**
A
2020
B
1990
C
1991
D
1992
E
1993
F
1990
- **Expected:**
A is 5 years old.
B is 35 years old.
C is 34 years old.
D is 33 years old.
E is 32 years old.
F is 35 years old.

Information about all persons:
Name: Very Young, Year of Birth: 2020
Name: B, Year of Birth: 1990
Name: C, Year of Birth: 1991
Name: D, Year of Birth: 1992
Name: E, Year of Birth: 1993
Name: F, Year of Birth: 1990

Persons with the same names:

absent

- **Got:**
A is 5 years old.
B is 35 years old.
C is 34 years old.
D is 33 years old.
E is 32 years old.
F is 35 years old.

Information about all persons:
Name: Very Young, Year of Birth: 2020
Name: B, Year of Birth: 1990
Name: C, Year of Birth: 1991
Name: D, Year of Birth: 1992
Name: E, Year of Birth: 1993
Name: F, Year of Birth: 1990

Persons with the same names:

absent

---

**Test 4**
- **Input:**
A
1990
A
1991
B
1992
C
1993
D
1994
E
1993
- **Expected:**
A is 35 years old.
A is 34 years old.
B is 33 years old.
C is 32 years old.
D is 31 years old.
E is 32 years old.

Information about all persons:
Name: A, Year of Birth: 1990
Name: A, Year of Birth: 1991
Name: B, Year of Birth: 1992
Name: C, Year of Birth: 1993
Name: D, Year of Birth: 1994
Name: E, Year of Birth: 1993

Persons with the same names:
Name: A, Year of Birth: 1990
Name: A, Year of Birth: 1991

- **Got:**
A is 35 years old.
A is 34 years old.
B is 33 years old.
C is 32 years old.
D is 31 years old.
E is 32 years old.

Information about all persons:
Name: A, Year of Birth: 1990
Name: A, Year of Birth: 1991
Name: B, Year of Birth: 1992
Name: C, Year of Birth: 1993
Name: D, Year of Birth: 1994
Name: E, Year of Birth: 1993

Persons with the same names:
Name: A, Year of Birth: 1990
Name: A, Year of Birth: 1991

---
**Test 5**
- **Test:**
Console.WriteLine(TestPerson.ValidateIfAreEqualMethodCorrect());
- **Input:**
- **Expected:**
Equals method is correct
- **Got:**
Equals method is correct
---

**Test 6**
- **Test:** Console.WriteLine(TestPerson.ValidateIfAreNotEqualMetodCorrect());
- **Input:**
- **Expected:**
Equals method is correct
- **Got:**
Equals method is correct
---


**Test 7**
- **Test:** Console.WriteLine(TestPerson.ValidateIfEqualOperatorCorrect());
- **Input:**
- **Expected:**
== operator is correct
- **Got:**
== operator is correct
---

**Test 8**
- **Test:** Console.WriteLine(TestPerson.ValidateIfNotEqualOperatorCorrect());
- **Input:**
- **Expected:**
!= operator is correct
- **Got:**
!= operator is correct
---

**Test 9**
- **Test:** Console.WriteLine(TestPerson.ValidateIfDefaultConstructorCorrect());
- **Input:**
- **Expected:**
Default constructor is correct
- **Got:**
Default constructor is correct
---

