# 10. Delegates and Event Handlers in .NET

## Task 1
Your task is:

1. Define a delegate **MyDel** that takes an integer parameter and returns void.
2. Create a **Student** class with a list of integers to store marks.
    - Include an event **MarkChange** of the type **MyDel**.
    - Implement an **AddMark** method to add a new mark and invoke the **MarkChange** event.

3. Create a **Parent** class with a method **OnMarkChange** that takes an integer parameter and prints it.
4.  Create an **Accountancy** class with a method **PayingFellowship** that decides and prints whether the student should receive a scholarship based on the provided mark.
5. In the **Main** method, instantiate a **Student**, **Parent**, and **Accountancy**. Subscribe the **Parent**'s **OnMarkChange** method and **Accountancy**'s **PayingFellowship** method to the **Student**'s **MarkChange** event.

Test the functionality by calling AddMark. Provide the input of the mark from the console and check the notification.

For example:
- **Test:**

DelegateProblem.StudentMain();

//StudentMain is your Main function. The StudentMain name is used for testing 

- **Input:** 90
- **Result:**

Please, input the mark

Parent notified: Mark = 90

Student will receive a scholarship.

### Tests
**Test 1**
- **Input:** 90
- **Expected:**

Please, input the mark

Parent notified: Mark = 90

Student will receive a scholarship.

- **Got:**

Please, input the mark

Parent notified: Mark = 90

Student will receive a scholarship.

---

**Test 2**
- **Input:** 75
- **Expected:**

Please, input the mark

Parent notified: Mark = 75

Student will receive a scholarship.

- **Got:**

Please, input the mark

Parent notified: Mark = 75

Student will receive a scholarship.

---

**Test 3**
- **Input:** 45
- **Expected:**

Please, input the mark

Parent notified: Mark = 45

Student will not receive a scholarship.

- **Got:**

Please, input the mark

Parent notified: Mark = 45

Student will not receive a scholarship.

---
