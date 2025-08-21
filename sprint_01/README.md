# 1. Introduction to the course. Code Conventions

## Task 1
Create class Evaluation. In the method Main() of this class write code for solving the next task:

Define integer variable a (side of the square).
Read value from the console and calculate the area and perimeter of a square with length a. Output results on the console.

For example, if the value in the console is 5, the output should be:
Area: 25
Perimeter: 20
If the entered value is not an integer, the message "Please, enter an integer value" should be printed to the console.

### Tests
**Test 1**
- **Input:** 2
- **Expected:** Area: 4, Perimeter: 8
- **Got:** Area: 4, Perimeter: 8

**Test 2**
- **Input:** 6
- **Expected:** Area: 36, Perimeter: 24
- **Got:** Area: 36, Perimeter: 24

**Test 3**
- **Input:** 8
- **Expected:** Area: 64, Perimeter: 32
- Got: Area: 64, Perimeter: 32

**Test 4**
- **Input:** "Hello"
- **Expected:** Please, enter an integer value
- **Got:** Please, enter an integer value
---

## Task 2
Create class Evaluation. In the method Main() of this class write code for solving the next task:

Define string name and integer age.
Output question "What is your name?";
Read the value name and output the next question: "How old are you, (name)?".
Read value age and output information in a form:

Hello name, you are age years old \:)
(Name and age here should be values that the user entered)


### Tests
**Test 1**
- **Input**: 
Ivan
20
- **Expected:**
What is your name?
How old are you, Ivan?
Hello Ivan, you are 20 years old \:)
- **Got:**
What is your name?
How old are you, Ivan?
Hello Ivan, you are 20 years old \:)


**Test 2**
- **Input**: 
Inna
18
- **Expected:**
What is your name?
How old are you, Inna?
Hello Inna, you are 18 years old \:)
- **Got:**
What is your name?
How old are you, Inna?
Hello Inna, you are 18 years old \:)


**Test 3**
- **Input**: 
Jake
33
- **Expected:**
What is your name?
How old are you, Jake?
Hello Jake, you are 33 years old \:)
- **Got:**
What is your name?
How old are you, Jake?
Hello Jake, you are 33 years old \:)
---

## Task 3
Create class CircleCalculations. In the method Main() of this class write code for solving the next task:

Read double number r (radius of a circle).
Calculate the length (l=2*pi*r), area (S=pi*r*r), and volume (4/3*pi*r*r*r) of a circle (define variable pi and assign value 3.14 to it).
Print the results to the console in a form:
length: lengthValue
area: areaValue
volume: volumeValue
Round a results to a 2-number of fractional digits (Math.Round might help you).

If the entered radius value is not a double, the message "Please, enter a double value" should be printed to the console.


### Tests
**Test 1**
- **Input**: 2
- **Expected:**
length: 12.56
area: 12.56
volume: 33.49
- **Got:**
length: 12.56
area: 12.56
volume: 33.49

**Test 2**
- **Input**: 15
- **Expected:**
length: 94.2
area: 706.5
volume: 14130
- **Got:**
length: 94.2
area: 706.5
volume: 14130

**Test 3**
- **Input**: 8
- **Expected:**
length: 50.24
area: 200.96
volume: 2143.57
- **Got:**
length: 50.24
area: 200.96
volume: 2143.57

**Test 4**
- **Input**: "Hello"
- **Expected:** Please, enter a double value
- **Got:** Please, enter a double value
---