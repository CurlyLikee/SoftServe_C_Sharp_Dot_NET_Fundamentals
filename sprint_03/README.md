# 3. C# Statements: linear, selection, iteration

## Task 1
Create a class StringChecker. In the method Main() of this class write code for solving the next task:

Read some string str.
Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text.
Print those counts in separate line each.

### Tests
**Test 1**
- **Input:** Hello everybody
- **Expected:**
0
2
0
3
- **Got:**
0
2
0
3

**Test 2**
- **Input:** How are you? Is everything ok?
- **Expected:**
1
3
1
3
- **Got:**
1
3
1
3
---

## Task 2
Create a class MonthChecker. In the method Main() of this class write code for solving the next task:

Ask the user to enter the number of month ("Please, enter the month number"). 
Read value and output the count of days in this month. Print the number of days to the console. For example, if the evaluated number of days is 30, the output should be:
"The number of days in this month is 30"

### Tests
**Test 1**
- **Input:** 1
- **Expected:**
Please, enter the month number
The number of days in this month is 31
- **Got:**
Please, enter the month number
The number of days in this month is 31

**Test 2**
- **Input:** 4
- **Expected:**
Please, enter the month number
The number of days in this month is 30
- **Got:**
Please, enter the month number
The number of days in this month is 30

**Test 3**
- **Input:** 8
- **Expected:**
Please, enter the month number
The number of days in this month is 31
- **Got:**
Please, enter the month number
The number of days in this month is 31
---

## Task 3
Create a class Calc. In the method Main() of this class write code for solving the next task:

Enter 10 integer numbers. (Ask the user to enter each of them with a phrase: "Please, enter an integer number")
Calculate the sum of the first 5 elements if they are positive
or the product of the last 5 elements in the other case.
Output the result with the phrase "The sum of the first 5 is " or "The product of the last 5 is ".
For example, "The sum of the first 5 is 13"

### Tests
**Test 1**
- **Input:**
1
2
3
4
5
6
7
8
9
15
- **Expected:**
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
The sum of the first 5 is 15
- **Got:**
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
The sum of the first 5 is 15

**Test 2**
- **Input:**
1
2
-3
4
5
6
7
8
9
15
- **Expected:**
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
The product of the last 5 is 45360
- **Got:**
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
The product of the last 5 is 45360

**Test 3**
- **Input:**
45
2
3
4
5
6
7
8
9
15
- **Expected:**
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
The sum of the first 5 is 59
- **Got:**
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
Please, enter an integer number
The sum of the first 5 is 59
---