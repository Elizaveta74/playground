# C# Projects & Exercises

This repository contains projects written in C#. The main purpose of the repository is to interact with the students doing the assignments.

## Exercises

<details><summary>Print single-dimensional array elements</summary>

---

Task id: `LSP-2`

You have an array:

````c#
int[] myArray = {1, -20, 23, -4, 8, -91, 0, 77, -4, 43, 11, -91};
````

* Loop through all elements of this array and print only numbers greater than 0.
* Solve this task using `for` loop, `while` loop and `do-while` loop.
* For every implementation (`for`-loop, `while` loop and `do-while` loop) create separate function (method) and call it accordingly.

[Implement this task in a console project](Tutorials/CreateConsoleProject.md)

---

</details>

<details><summary>Array multiplication</summary>

---

Task id: `LSP-3`

Write a function that takes two arguments, `firstArray` and `secondArray`. 

`firstArray` and `secondArray` are arrays of integers. 

The function must return an array where each element is the product of the indexed elements of `firstArray` and `secondArray`.

For example:

For initial arrays

```c#
    int[] firstArray = { 21, 5, -3, 4, 6, 131, 7, -27, -4, 93, -1, -91 };
    int[] secondArray = { 3, 82, 6, 2, -9, 6, 14, 7, 3, 0, 90, -2 };
```	

The result array should equal to 

```c#
{ 63, 410, -18, 8, -54, 786, 98, -189, -12, 0, -90, 182 }
```

[Implement this task in a console project](Tutorials/CreateConsoleProject.md)

---

</details>

<details><summary>Split string to array of sub-strings</summary>

---

Task id: `LSP-4`

Write a function that takes two arguments. 

The first is a string to process. The second is a character delimiter (of type char). 

The function will return a string array containing the sub-strings in this case that are delimited by the second argument (delimiter symbol).

Use of the standard `string.Split()` method is not allowed.

For example for arguments:

First argument (string): 

```c#
string stringToProcess = "Apple,Orange,Kiwi,Banana,Mulberry";
```

Second argument (char):

```c#
char delimiter = ',';
```

The function should return the following array:

```c#
{"Apple", "Orange", "Kiwi", "Banana", "Mulberry"}
```

[Implement this task in a console project](Tutorials/CreateConsoleProject.md)

---

</details>

<details><summary>Min and max values in array</summary>

---

Task id: `LSP-5`

Write a function that takes two arguments. The first is an array of integer values, and the second is a logical type (`bool`).

If the second argument is `true`, the function should return the maximum element of the array; if it is `false`, the function should return the minimum element of the array.

For example:

**First example**:

First argument:

```c#
int[] myArray = { 29, -8, 6, 41, 15, 19, 21, 34, 0, 4};
```

Second argument:

```c#
bool findMaxValue = true;
```

The function should return `41`

**Second example**:

First argument:

```c#
int[] myArray = { 29, -8, 6, 41, 15, 19, 21, 34, 0, 4};
```

Second argument: 

```c#
bool findMaxValue = false;
```

The function should return:  `-8`

[Implement this task in a console project](Tutorials/CreateConsoleProject.md)

---

</details>

<details><summary>Odd and even numbers separator</summary>

---

Task id: `LSP-6`

Write a function that takes one argument: an integer array. The function should create and return two arrays (as a tuple), one containing only even values from the array passed as an argument to this function, and the other containing odd values from the same array.

Consider `0` to be an even number.

For example, for array:

```c#
int[] initialArray = {-1, 3, 5, 8, 2, 10, 1, 0, 20, 5, 17};
```


the function should return a tuple with two arrays:

```c#
int[] oddNumbers = {-1, 3, 5, 1, 5, 17};
int[] evenNumbers = {8, 2, 10, 0, 20};
```

[Implement this task in a console project](Tutorials/CreateConsoleProject.md)

---

</details>

## SandBox

1. [Basics](SandBox/Basics) (added on `16 July 2023`)
2. [Function extractor](SandBox/FunctionExtractor) (added on `18 July 2023`)
3. [Advanced functions extractor](SandBox/AdvancedFunctionsExtractor) (added on `19 July 2023`)
4. [More functions](SandBox/MoreFunctions) (added on `20 July 2023`)
5. [Type conversions](SandBox/TypeConversions) (added on `22 July 2023`)
6. [Conditionals and loops](SandBox/ConditionalsAndLoops) (added on `23 July 2023`)
7. [Logical operators](SandBox/LogicalOperators) (added on `23 July 2023`)
8. [String operations](SandBox/StringOperations) (added on `26 July 2023`)
9. [Bitwise and shift operations](SandBox/BitwiseAndShiftOperations) (added on `28 July 2023`)
10. [Flow control samples](SandBox/FlowControlSamples) (added on `1 Aug 2023`)
