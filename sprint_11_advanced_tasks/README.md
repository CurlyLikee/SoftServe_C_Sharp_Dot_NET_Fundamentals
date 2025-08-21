# 11. Language Integrated Query (LINQ). Regular Expressions

## Task 1
Please, implement the Filter method that takes IEnumerable<Student> parameter.

* Student class is already implemented:


![Screenshot](https://github.com/CurlyLikee/SoftServe_C_Sharp_Dot_NET_Fundamentals/blob/main/sprint_08/image.png)


* The Filter method should select students that have rating more than 75 and study Math or English

* The Group name should written in uppercase for students in result collection.

### Tests
**Test 1**
- **Test:** Console.WriteLine(FilteringWithTransformationTest.IsFilterCorrect1());
- **Expected:** True
- **Got:** True

---

**Test 2**
- **Test:** Console.WriteLine(FilteringWithTransformationTest.IsFilterCorrect2());
- **Expected:** True
- **Got:** True

---

## Task 2
Please, create a method that takes a sentence with words separated by space.

The method should return the longest word that starts with an 'a' letter.

If there are no words that start with an 'a' in the sentence, the method should return an empty string


### Tests
**Test 1**
- **Test:** Console.WriteLine(LongestWordTest.IsSearchCorrect());
- **Expected:** True
- **Got:** True

---
