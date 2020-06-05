# SmartExtensions

A big list of commonly used methods and extension methods when using C# built-in types. 
Methods and extensions all of us write often enough to render grouping them in a nuget package useful. 

![.NET Core Build and Run Unit Tests](https://github.com/DevsAnon/SmartExtensions/workflows/.NET%20Core%20Build%20and%20Run%20Unit%20Tests/badge.svg?event=push)

## Installation

```PM>
Install-Package SmartExtensionMethods
```

## Currently Available Extension methods
Most are self explanatory by name but for some, details will be given to explain them. Documentation is included in the source code as well

### StringExtensions

`CaseInsensitiveContains` Checks if string is contained using case insensitive search</br> 
`CaseInsensitiveCompare` Compares two string using insensitive case</br> 
`ToValueOrDefault` Returns value or if null, returns provided default value</br> 
`IsNullOrEmpty` Checks if string is null or empty</br> 
`IsNullOrWhitespace` Checks if string is null or white space</br> 
`RemoveSpaces` Removes all spaces from string</br> 
`TryToInt16` Casts string to short using the try pattern</br> 
`TryToInt32` Casts string to int using the try pattern</br> 
`TryToInt64` Casts string to long using the try pattern</br> 
`TryToDate` Casts string to date using the try pattern</br> 
`TryToDecimal` Casts string to decimal using the try pattern</br> 
`Reverse` Reverses the string</br> 
`IsEmail` Checks if string is an email string</br> 
`IsPhone` Checks if string resembles a phone number</br> 

### DoubleExtensions

`IsNaN`</br>
`IsInfinity`</br>
`GetPercentage` Returns a value representing the percentage requested</br>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster</br>

### FloatExtensions

`IsNaN`</br>
`IsInfinity`</br>
`GetPercentage` Returns a value representing the percentage requested</br>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster</br>

### IntExtensions

`GetPercentage` Returns a value representing the percentage requested</br>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster</br>

### ShortExtensions

`GetPercentage` Returns a value representing the percentage requested</br>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster</br>

### DateTimeExtensions

`FirstDayOfMonth` Get first day of the month</br>
`FirstDayOfMonth` Get first specific day of the month</br>
`NextSpecificDay` Next specific day</br>
`LastDayOfMonth` Get last day of the month</br>
`LastDayOfMonth` Get last specific day of the month</br>
`SetTime` Get DateTime with specific time. Overloads for minute accuracy, second accuracy and milisecond accuracy</br>
`GetNoon` Gets a DateTime representing noon on the current date</br>
`GetMidnight` Gets a DateTime representing midnight on the current date</br>
