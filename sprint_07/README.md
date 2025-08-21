# 7. Exception Handling

## Task 1
Create class WorkWithExceptions.
Create static method Div, which takes 2 integer parameters and calculates the dividing the first by the second, and prints result to the console.
Also create a static Main method in this class.  
In Main() read two int numbers and call this method.
Catch corresponding exceptions.
Possible outputs when an exception occurs:
"Please, enter an integer value" or
"Cannot divide by 0".

### Tests
**Test 1**
- **Test:**
WorkWithExceptions.StudentMain();
//StudentMain is your Main function. The StudentMain name is used for testing
- **Input:**
6
2
- **Expected:** 3
- **Got:** 3

---

**Test 2**
- **Test:**
WorkWithExceptions.StudentMain();
//StudentMain is your Main function. The StudentMain name is used for testing
- **Input:**
10
0
- **Expected:** Cannot divide by 0
- **Got:** Cannot divide by 0

---

**Test 3**
- **Test:**
WorkWithExceptions.StudentMain();
//StudentMain is your Main function. The StudentMain name is used for testing
- **Input:**
32
hello
- **Expected:** Please, enter an integer value
- **Got:** Please, enter an integer value

---

**Test 4**
- **Test:**
WorkWithExceptions.StudentMain();
//StudentMain is your Main function. The StudentMain name is used for testing
- **Input:**
hi
12
- **Expected:** Please, enter an integer value
- **Got:** Please, enter an integer value

---

**Test 5**
- **Test:**
// checks if Div throws an exception
try
{
    WorkWithExceptions.Div(5,0);
}
catch {Console.WriteLine("Cathced");}
- **Input:**
- **Expected:** Cathced
- **Got:** Cathced

---

## Task 2

Create class WorkWithNumbers.
Write static method ReadNumber(int start, int end), which reads an integer number from the console and returns it, if it is in the range [start...end]. If this number is invalid or non-number text is read, the method should throw an ArgumentException exception. 
Using this method write method Main(), which has to enter 10 numbers:
a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100.

If all entered values satisfy the requirements, the Main method should print the last number to the console. 

If an entered value is not an integer "Please, enter an integer value" should be printed.

Otherwise "Wrong value" should be printed.


### Tests
**Test 1**
- **Input:**
3
5
7
9
12
15
18
20
22
28
- **Expected:** 28
- **Got:** 28

---

**Test 2**
- **Input:**
3
5
7
9
12
15
18
30
22
28
- **Expected:** Wrong value
- **Got:** Wrong value

---

**Test 3**
- **Input:**
3
5
seven
9
12
15
18
30
22
28
- **Expected:** Please, enter an integer value
- **Got:** Please, enter an integer value
---

