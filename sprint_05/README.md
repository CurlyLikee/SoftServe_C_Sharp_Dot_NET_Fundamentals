# 5. Interfaces. C# Collections. Generic collections

## Task 1
1. Create interface IDeveloper with property Tool, methods Create() and Destroy

2. Create two classes Programmer (with field language) and Builder (with field tool), which implement this interface.

Create method should print "Programmer created" to the console for the Programmer class and "Builder created" for the Builder class.

Destroy method should print "Programmer destroyed" to the console for the Programmer class and "Builder destroyed" for the Builder class.

3. Create default implementation of interface IComparable<IDeveloper> in IDeveloper interface. Compare IDevelopers by Tool property.

4. Create class TeamWork with static void function SortTeamMembers that takes an array of IDeveloper and sorts this array.

### Tests
**Test 1**
- **Test:**
Console.WriteLine(Reflector.IsTypeInterface("MyProgram.IDeveloper"));
//Checks if IDeveloper is declared as an interface
- **Expected:** True
- **Got:** True

---

**Test 2**
- **Test:**
Console.WriteLine(Reflector.HasTypeProperty(typeof(IDeveloper), "Tool", typeof(string)));
//Checks if IDeveloper has string property Tool
- **Expected:** True
- **Got:** True

---

**Test 3**
- **Test:**
Console.WriteLine(Reflector.HasTypeDeclaredMethod(typeof(IDeveloper), "Create", new Type[] {}));
//Checks if IDeveloper has method Create()
- **Expected:** True
- **Got:** True

---

**Test 4**
- **Test:**
Console.WriteLine(Reflector.HasTypeDeclaredMethod(typeof(IDeveloper), "Destroy", new Type[] {}));
//Checks if IDeveloper has method Destroy()
- **Expected:** True
- **Got:** True

---

**Test 5**
- **Test:**
Console.WriteLine(Reflector.IsTypeClass("MyProgram.Programmer"));
//Checks if there is Programmer class
- **Expected:** True
- **Got:** True

---

**Test 6**
- **Test:**
Console.WriteLine(Reflector.IsTypeClass("MyProgram.Builder"));
//Checks if there is Builder class
- **Expected:** True
- **Got:** True

---

**Test 7**
- **Test:** Console.WriteLine(typeof(Programmer).GetInterface("IDeveloper"));
- **Expected:** MyProgram.IDeveloper
- **Got:** MyProgram.IDeveloper

---

**Test 8**
- **Test:** Console.WriteLine(typeof(Builder).GetInterface("IDeveloper"));
- **Expected:** MyProgram.IDeveloper
- **Got:** MyProgram.IDeveloper

---

**Test 9**
- **Test:** Console.WriteLine(Reflector.HasTypeField(typeof(Builder), "tool", typeof(string)));
- **Expected:** True
- **Got:** True

---

**Test 10**
- **Test:** Console.WriteLine(Reflector.HasTypeField(typeof(Programmer), "language", typeof(string)));
- **Expected:** True
- **Got:** True

---

**Test 11**
- **Test:**
Builder builder = new Builder();
builder.Create();
builder.Destroy();
- **Expected:**
Builder created
Builder destroyed
- **Got:**
Builder created
Builder destroyed

---

**Test 12**
- **Test:**
Programmer programmer = new Programmer();
programmer.Create();
programmer.Destroy();
- **Expected:**
Programmer created
Programmer destroyed
- **Got:**
Programmer created
Programmer destroyed

---

**Test 13**
- **Test:** Console.WriteLine(typeof(IDeveloper).GetInterface("IComparable`1"));
- **Expected:** System.IComparable`1[MyProgram.IDeveloper]
- **Got:** System.IComparable`1[MyProgram.IDeveloper]

---

**Test 14**
- **Test:**
	
IDeveloper builder1 = new Builder();
IDeveloper builder2 = new Builder();
IDeveloper programmer = new Programmer();
builder1.Tool = "hammer";
builder2.Tool = "saw";
programmer.Tool = "C#";
IDeveloper[] devs = { builder1, builder2, programmer };

TeamWork.SortTeamMembers(devs);

Console.WriteLine(devs[0].Tool);
Console.WriteLine(devs[1].Tool);
Console.WriteLine(devs[2].Tool);
- **Expected:**
C#
hammer
saw
- **Got:**
C#
hammer
saw
---


## Task 2

Create class Meeting with private field people of type Dictionary<uint, string>.

Add method Initialize to the Meeting class which adds to Dictionary 7 pairs (ID, Name) of some persons from the console. (For each person method should ask "Please, enter Id", then read an Id from the console, then ask "Please, enter name" and read name from the console).

Add method FindPerson to the Meeting class. The method should ask user to enter Id, then find and write the corresponding Name from the people field to the console.
If this ID can't be found - "not found" should be printed.

### Tests
**Test 1**
- **Test:** Console.WriteLine(Reflector.HasTypeField(typeof(Meeting), "people", typeof(Dictionary<uint, string>)));
- **Input:**
- **Expected:** True
- **Got:** True

---

**Test 2**
- **Test:**
Meeting myMeeting = new Meeting();
myMeeting.Initialize();
myMeeting.FindPerson();
- **Input:**
1
John
2
Ann
3
Iryna
4
Oleh
5
Ihor
6
Max
7
Mark
4
- **Expected:**
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Oleh
- **Got:**
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Oleh

---

**Test 3**
- **Test:**
Meeting myMeeting = new Meeting();
myMeeting.Initialize();
myMeeting.FindPerson();
- **Input:**
1
John
2
Ann
3
Iryna
4
Oleh
11
Ihor
6
Max
7
Mark
5
- **Expected:**
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
not found
- **Got:**
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
Please, enter name
Please, enter Id
not found
---