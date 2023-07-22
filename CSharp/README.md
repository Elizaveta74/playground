# C# Projects & Exercises

This repository contains projects written in C#. The main purpose of the repository is to interact with the students doing the assignments.

## Table of Contents

### Exercises

<details><summary>Print single-dimensional array elements</summary>
<hr>

Task id: `LSP-2`

You have an array:

````c#
int[] myArray = {1, -20, 23, -4, 8, -91, 0, 77, -4, 43, 11, -91};
````

* Loop through all elements of this array and print only numbers greater than 0.
* Solve this task using `for` loop, `while` loop and `do-while` loop.
* For every implementation (`for`-loop, `while` loop and `do-while` loop) create separate function (method) and call it accordingly.

[Implement this task in a console project](Tutorials/CreateConsoleProject.md)

<hr>
</details>

<details><summary>Array multiplication</summary>
<hr>

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

<hr>
</details>

<details><summary>Split string to array of sub-strings</summary>
<hr>

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

<hr>
</details>