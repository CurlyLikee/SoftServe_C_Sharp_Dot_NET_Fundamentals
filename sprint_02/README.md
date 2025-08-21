# 2. Type System overview. Value types

## Task 1
Create a class Checker. In the method Main() of this class write code for solving the next task:
Read 3 float numbers and check if they are all in the range [-5.5]. Print True or False to the console depending on the result of checking.

### Tests
**Test 1**
- **Input:**
2
5
4
- **Expected:** True
- **Got:** True

**Test 2**
- **Input:**
2
-4
0
- **Expected:** True
- **Got:** True

**Test 3**
- **Input:**
0
-5.1
1.03
- **Expected:** False
- **Got:** False

**Test 4**
- **Input:**
-8.2
3
1.03
- **Expected:** False
- **Got:** False

**Test 5**
- **Input:**
2.9
3
11.03
- **Expected:** False
- **Got:** False
---


## Task 2
Create a class Checker. In the method Main() of this class write code for solving the next task:
Read 3 integer numbers and output max and min of them.

For example, if the input is
1
2
3

the output should be:
max: 3
min: 1

### Tests
**Test 1**
- **Input:**
2
5
4
- **Expected:**
max: 5
min: 2
- **Got:**
max: 5
min: 2


**Test 2**
- **Input:**
2
-4
0
- **Expected:**
max: 2
min: -4
- **Got:**
max: 2
min: -4


**Test 3**
- **Input:**
0
-5
1
- **Expected:**
max: 1
min: -5
- **Got:**
max: 1
min: -5


**Test 4**
- **Input:**
-8
3
1
- **Expected:**
max: 3
min: -8
- **Got:**
max: 3
min: -8
---


## Task 3
Create a class Checker. In the method Main() of this class write code for solving the next task:

Read a number of HTTP Error (400, 401, 402, 403, 404) and write the name of this error
(Declare enum HTTPError inside of the class Checker with values     
    BadRequest,
    Unauthorized,
    PaymentRequired,
    Forbidden,
    NotFound )


### Tests
**Test 1**
- **Input:** 400
- **Expected:** BadRequest
- **Got:** BadRequest

**Test 2**
- **Input:** 401
- **Expected:** Unauthorized
- **Got:** Unauthorized

**Test 3**
- **Input:** 402
- **Expected:** PaymentRequired
- **Got:** PaymentRequired

**Test 4**
- **Input:** 403
- **Expected:** Forbidden
- **Got:** Forbidden

**Test 5**
- **Input:** 404
- **Expected:** NotFound
- **Got:** NotFound

**Test 6**
- **Test:** Console.WriteLine((int)Checker.HTTPError.BadRequest == 400); 
- **Input:** 
- **Expected:** True
- **Got:** True

**Test 7**
- **Test:** Console.WriteLine((int)Checker.HTTPError.Unauthorized == 401);
- **Input:** 
- **Expected:** True
- **Got:** True

**Test 8**
- **Test:** Console.WriteLine((int)Checker.HTTPError.PaymentRequired== 402);
- **Input:** 
- **Expected:** True
- **Got:** True

**Test 9**
- **Test:** Console.WriteLine((int)Checker.HTTPError.Forbidden == 403);
- **Input:** 
- **Expected:** True
- **Got:** True

**Test 10**
- **Test:** Console.WriteLine((int)Checker.HTTPError.NotFound == 404);
- **Input:** 
- **Expected:** True
- **Got:** True
---

## Task 4
Create a class Solution. In the method Main() of this class write code for solving the next task:

Declare struct Dog with fields name, mark, and age.
Declare object myDog of Dog type and read values for it.
Output information on the console. (Override method ToString in the struct)

Example of output:
Name: Ava, mark: excellent, age: 3

### Tests
**Test 1**
- **Input:**
Ava
excellent
3
- **Expected:** Name: Ava, mark: excellent, age: 3
- **Got:** Name: Ava, mark: excellent, age: 3

**Test 2**
- **Input:**
Bim
thoroughbred
5
- **Expected:** Name: Bim, mark: thoroughbred, age: 5
- **Got:** Name: Bim, mark: thoroughbred, age: 5
---
