# 5. Interfaces. C# Collections. Generic collections

## Task 1
Please, implement the GetListOfPrimeNumbers method that returns a list of prime numbers from the argument list.
All numbers in the result list should be unique, duplicates should not be added to the result list.
The number is prime if its only dividers are 1 and this number itself.

### Tests
**Test 1**
- **Test:** Console.WriteLine(PrimeNumbersTest.IsGetPrimeNumbersCorrect());
- **Expected:** True
- **Got:** True
---


## Task 2
Please, implement CreateCommonList method.
It takes Queue of strings as a first parameter and Stack of strings as a second. 
The method should return a List of strings that consists of elements from both collections that do not belong to both collections simultaneously:
![Screenshot](https://github.com/CurlyLikee/UI-Playground/blob/main/screenshot.png)

### Tests
**Test 1**
- **Test:** Console.WriteLine(StackAndQueueTest.IsMethodCorrect());
- **Expected:** True
- **Got:** True

## Task 3
Please, implement FindValueByConditionOrDefault method that returns the first value in a dictionary that satisfies a condition.

If there is no such value in the dictionary, the default value should be returned.

Keys of the dictionary should be int and values - any type

Arguments of the method:

1. the dictionary
2. condition
3. the default value

### Tests
**Test 1**
- **Test:** Console.WriteLine(ValueByConditionInDictionatyTest.IsCorrect_Int_GreaterThan(5));
- **Expected:** True
- **Got:** True

---

**Test 2**
- **Test:** Console.WriteLine(ValueByConditionInDictionatyTest.IsCorrect_Int_GreaterThan(8));
- **Expected:** True
- **Got:** True

---

**Test 3**
- **Test:** Console.WriteLine(ValueByConditionInDictionatyTest.IsCorrect_String_Contains('a'));
- **Expected:** True
- **Got:** True

---

**Test 4**
- **Test:** Console.WriteLine(ValueByConditionInDictionatyTest.IsCorrect_String_Contains('s'));
- **Expected:** True
- **Got:** True

---