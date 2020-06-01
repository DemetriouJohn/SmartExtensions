# SmartExtensions

A big list of commonly used methods and extension methods when using C# built-in types. 
Methods and extensions all of us write often enough to render grouping them in a nuget package useful. 

![.NET Core](https://github.com/DevsAnon/SmartExtensions/workflows/.NET%20Core/badge.svg)

## Installation

```PM>
Install-Package SmartExtensionMethods
```

## Currently Available Extension methods
Most are self explanatory by name but for some, details will be given to explain them. Documentation is included in the source code as well

### StringExtensions

`CaseInsensitiveContains` </br>
`CaseInsensitiveCompare`</br>
`ToValueOrDefault`</br>
`IsNullOrEmpty`</br>
`IsNullOrWhitespace`</br>
`RemoveSpaces`</br>
`TryToInt16`</br>
`TryToInt32`</br>
`TryToInt64`</br>
`TryToDate`</br>
`TryToDecimal`</br>
`Reverse`</br>
`IsEmail`</br>
`IsPhone`</br>

### MathExtensions

`Pow` - Several extensions exist for this one. Some of them are for simplicity. But in general it has been measured that using a loop for calculating the positive power of any number is faster than using the whole logic of the built-in Pow method which has a lot of checks for negative or non-integer numbers</br>

### DoubleExtensions

`IsNaN`</br>
`IsInfinity`</br>
`GetPercentage` Returns a value representing the percentage requested</br>
`Pow`  Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster</br>

### DateTimeExtensions

`FirstDayOfMonth` Get first day of the month</br>
`FirstDayOfMonth` Get first specific day of the month</br>
`NextSpecificDay` Next specific day</br>
`LastDayOfMonth` Get last day of the month</br>
`LastDayOfMonth` Get last specific day of the month</br>
`SetTime` Get DateTime with specific time. Overloads for minute accuracy, second accuracy and milisecond accuracy</br>
`GetNoon` Gets a DateTime representing noon on the current date</br>
`GetMidnight` Gets a DateTime representing midnight on the current date</br>

