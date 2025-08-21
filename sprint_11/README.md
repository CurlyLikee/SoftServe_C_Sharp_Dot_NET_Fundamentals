# 11. Language Integrated Query (LINQ). Regular Expressions

## Task 1
Use classes Shape, Circle, and Square from one of the previous homework tasks (Inheritance in C#).

   Create a class Operator and use Linq and string functions to complete the next tasks:

   1) Create method AddShape that takes Shape as an argument and adds the received shape to the field shapes (add this field to the Operator set initial value - empty List of shapes to it).

   2)  Create method FindIn10To100Range that finds and writes to the console shapes with area from the range [10,100]

   3) Create method FindContaininga that finds and writes to the console shapes whose name contains the letter 'a'

   4) Create a method RemoveWithPerimeterLessThan5 that finds and removes from the list all shapes with a perimeter of less than 5 and writes the result list to the Console.

   
### Tests
**Test 1**
- **Test:**
	
Operator myOperator = new Operator();

myOperator.AddShape(new Circle("c1", 10));

myOperator.AddShape(new Circle("c2", 3));

myOperator.AddShape(new Circle("c3", 2));

myOperator.AddShape(new Circle("c4", 8));

myOperator.AddShape(new Square("s1", 1));

myOperator.AddShape(new Square("s1", 12));

myOperator.Sort();

- **Expected:**

s1

c3

c2

s1

c4

c1

- **Got:**

s1

c3

c2

s1

c4

c1

---

**Test 2**
- **Test:**
	
Operator myOperator = new Operator();

myOperator.AddShape(new Circle("c1", 11));

myOperator.AddShape(new Circle("c2", 3));

myOperator.AddShape(new Circle("c3", 2));

myOperator.AddShape(new Circle("c4", 8));

myOperator.AddShape(new Square("s1", 1));

myOperator.AddShape(new Square("s1", 12));

myOperator.FindIn10To100Range();

- **Expected:**

c2

c3

- **Got:**

c2

c3

---

**Test 3**
- **Test:**

Operator myOperator = new Operator();

myOperator.AddShape(new Circle("circle round", 11));

myOperator.AddShape(new Circle("c2", 3));

myOperator.AddShape(new Circle("c3", 2));

myOperator.AddShape(new Circle("large circle", 8));

myOperator.AddShape(new Square("square equal sided", 1));

myOperator.AddShape(new Square("square large", 12));

myOperator.FindContaininga();

- **Expected:**

large circle

square equal sided

square large

- **Got:**

large circle

square equal sided

square large

---


**Test 4**
- **Test:**

Operator myOperator = new Operator();

myOperator.AddShape(new Circle("circle round", 11));

myOperator.AddShape(new Circle("c2", 3));

myOperator.AddShape(new Circle("c3", 2));

myOperator.AddShape(new Circle("large circle", 8));

myOperator.AddShape(new Square("square equal sided", 1));

myOperator.AddShape(new Square("square large", 12));

myOperator.RemoveWithPerimeterLessThan5();

Console.WriteLine();

myOperator.Sort();//check if shapes are actually removed

- **Expected:**

circle round

c2

c3

large circle

square large

c3

c2

square large

large circle

circle round

- **Got:**

circle round

c2

c3

large circle

square large

c3

c2

square large

large circle

circle round

---

## Task 2

Create static class FileAnalyzer with static methods.

Each method should:

   Read all lines of text from the file "client.test.js". 

And the methods should solve the next tasks:

   1) GetSumbolsCountInEachLine - Count and write the number of symbols in every line.

   2) GetLongestLine - Find the longest and the shortest line.

   3) GetShortestLine - Find the longest and the shortest line.

   4) GetLinesWithLet - Find and return only lines, that contain the word "let"

   
### Tests
**Test 1**
- **Test:**

foreach(int l in FileAnalyzer.GetSumbolsCountInEachLine())

Console.WriteLine(l);

- **Expected:** 

70

52

25

32

0

30

23

12

30

21

6

3

0

19

6

2

17

5

15

51

59

6

65

41

4

19

73

40

0

33

46

71

74

0

65

0

48

41

0

45

45

31

6

47

5

4

0

87

31

28

50

54

49

0

18

11

43

51

10

7

35

7

6

5

3

- **Got:**

70

52

25

32

0

30

23

12

30

21

6

3

0

19

6

2

17

5

15

51

59

6

65

41

4

19

73

40

0

33

46

71

74

0

65

0

48

41

0

45

45

31

6

47

5

4

0

87

31

28

50

54

49

0

18

11

43

51

10

7

35

7

6

5

3

---

**Test 2**
- **Test:** Console.WriteLine(FileAnalyzer.GetLongestLine());
- **Expected:** test("Data is displayed correctly when received from WebSocket Server", async () => {
- **Got:** test("Data is displayed correctly when received from WebSocket Server", async () => {

---

**Test 3**
- **Test:**  Console.WriteLine(FileAnalyzer.GetShortestLine());
- **Expected:**
- **Got:**

---

**Test 4**
- **Test:**

foreach(string s in FileAnalyzer.GetLinesWithLet())

Console.WriteLine(s);

- **Expected:**

let inputUserName = screen.getByPlaceholderText("Your nickname");

let inputMessage = screen.getByPlaceholderText("Type your message");

let button = screen.getByRole("button", { name: /send/i });

let areaChat = screen.getByLabelText("chat");

- **Got:**

let inputUserName = screen.getByPlaceholderText("Your nickname");

let inputMessage = screen.getByPlaceholderText("Type your message");

let button = screen.getByRole("button", { name: /send/i });

let areaChat = screen.getByLabelText("chat");

---



