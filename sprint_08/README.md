# 8. Working with files in C#

## Task 1
Prepare the file "phones.txt" with records as follows:
![Screenshot](https://github.com/CurlyLikee/SoftServe_C_Sharp_Dot_NET_Fundamentals/blob/main/sprint_05_advanced_tasks/image%20(1).png)

Prepare the file "names.txt" with records as follows:
![Screenshot](https://github.com/CurlyLikee/SoftServe_C_Sharp_Dot_NET_Fundamentals/blob/main/sprint_05_advanced_tasks/image%20(1).png)

Within FilesBehavior class define Main() method.

In Main() method declare Dictionary PhoneBook for keeping pairs PersonName-PhoneNumber.
1. From the file "phones.txt" read 9 pairs into PhoneBook. Write only PhoneNumbers into the file "onlyPhones.txt". 
2. From the file "names.txt" read the names of people, find and print the phone number by the given name if it can be found in the PhoneBook.
3. Change all phone numbers, which are in format 80######### into new format +380#########. The result should be written into the file «newPhones.txt».

For example:
- **Test:**
FilesBehavior.StudentMain();
//StudentMain is your Main function. The StudentMain name is used for testing 
- **Result:**
The phone number of John Doe is: 80123456789
Name Jannet Smith was not found in phone book.
The phone number of Alice Johnson is: 80234567890
Name Bobby Brown was not found in phone book.


### Tests
**Test 1**
- **Test:**
FilesBehavior.StudentMain();
//StudentMain is your Main function. The StudentMain name is used for testing
- **Expected:**
The phone number of John Doe is: 80123456789
Name Jannet Smith was not found in phone book.
The phone number of Alice Johnson is: 80234567890
Name Bobby Brown was not found in phone book.
- **Got:**
The phone number of John Doe is: 80123456789
Name Jannet Smith was not found in phone book.
The phone number of Alice Johnson is: 80234567890
Name Bobby Brown was not found in phone book.

---

**Test 2**
- **Test:**
if (File.Exists("newPhones.txt"))
{
Console.WriteLine ("File newPhones.txt was successfully created");
}
else
{
Console.WriteLine("File newPhones.txt was not craeted");
}
- **Expected:** File newPhones.txt was successfully created
- **Got:** File newPhones.txt was successfully created

---

**Test 3**
- **Test:**
string[] newLines = File.ReadAllLines("newPhones.txt");
        foreach (string line in newLines)
        {
            Console.WriteLine($"{line}");
         }
- **Expected:**
John Doe - +380123456789
Jane Smith - +380987654321
Alice Johnson - +380234567890
Bob Brown - +380345678901
Charlie Black - +380456789012
Diana White - +380567890123
Evan Green - +380678901234
Fiona Grey - +380789012345
George Blue - +380890123456
- **Got:**
John Doe - +380123456789
Jane Smith - +380987654321
Alice Johnson - +380234567890
Bob Brown - +380345678901
Charlie Black - +380456789012
Diana White - +380567890123
Evan Green - +380678901234
Fiona Grey - +380789012345
George Blue - +380890123456

---

**Test 4**
- **Test:**
if (File.Exists("onlyPhones.txt"))
{
Console.WriteLine ("File onlyPhones.txt was successfully created");
}
else
{
Console.WriteLine("File onlyPhones.txt was not craeted");
}
- **Expected:** File onlyPhones.txt was successfully created
- **Got:** File onlyPhones.txt was successfully created

---

**Test 5**
- **Test:**
string[] newPhones = File.ReadAllLines("onlyPhones.txt");
        foreach (string line in newPhones)
        {
            Console.WriteLine($"{line}");
         }
- **Expected:**

80123456789

80987654321

80234567890

80345678901

80456789012

80567890123

80678901234

80789012345

80890123456

- **Got:**

80123456789

80987654321

80234567890

80345678901

80456789012

80567890123

80678901234

80789012345

80890123456
