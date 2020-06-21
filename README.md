# SmartExtensions

A big list of commonly used methods and extension methods when using C# built-in types. 
Methods and extensions all of us write often enough to render grouping them in a nuget package useful. 

![.NET Core Build and Run Unit Tests](https://github.com/DevsAnon/SmartExtensions/workflows/.NET%20Core%20Build%20and%20Run%20Unit%20Tests/badge.svg?event=push)

[![Coverage Status](https://coveralls.io/repos/github/DevsAnon/SmartExtensions/badge.svg?branch=master)](https://coveralls.io/github/DevsAnon/SmartExtensions?branch=master)

## Installation

```PM>
Install-Package SmartExtensionMethods
```

## Currently Available Extension methods

### StringExtensions (23)

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
`ExtractEmail` Returns a new string containing an email from the original string. If no email found returns String.empty</br> 
`IsPhone` Checks if string resembles a phone number</br> 
`IsPalindrome` Checks if string is a palindrome</br> 
`ContainsAll` Check whether the specified string contains an array of strings for each.</br> 
`DeserializeXml<T>` Deserializes string XML to type &lt;T&gt;.</br> 
`Nl2Br` Converts Windows and Linux new line characters to HTML break characters</br>
`EqualsAny` Check that the given string is in a list of potential matches.</br>
`Join` Joins a list of strings with the provided separator</br>
`JoinWithComma` Joins a list of strings with ", "</br>
`JoinWithSpace` Joins a list of strings with a single space</br>
`GetEnumValue` Get Enum value (case inssensitive) or return provided default if not found</br>

### DoubleExtensions (4)

`IsNaN`</br>
`IsInfinity`</br>
`GetPercentage` Returns a value representing the percentage requested</br>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster</br>

### FloatExtensions (4)

`IsNaN`</br>
`IsInfinity`</br>
`GetPercentage` Returns a value representing the percentage requested</br>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster</br>

### IntExtensions (2)

`GetPercentage` Returns a value representing the percentage requested</br>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster</br>

### ShortExtensions (2)

`GetPercentage` Returns a value representing the percentage requested</br>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster</br>

### DateTimeExtensions (8)

`FirstDayOfMonth` Get first day of the month</br>
`FirstDayOfMonth` Get first specific day of the month</br>
`NextSpecificDay` Next specific day</br>
`LastDayOfMonth` Get last day of the month</br>
`LastDayOfMonth` Get last specific day of the month</br>
`SetTime` Get DateTime with specific time. Overloads for minute accuracy, second accuracy and milisecond accuracy</br>
`GetNoon` Gets a DateTime representing noon on the current date</br>
`GetMidnight` Gets a DateTime representing midnight on the current date</br>

### IEnumerableExtensions (3)
`Sum` Introduced sum method for LINQ usage for TimeSpans</br>
`IsNullOrEmpty` Checks if Enumerable is null or empty</br>
`Foreach` Executes provided action on each item of the Enumerable</br>
`StandardDeviation` Performs Standard Deviation on the entire dataset</br>
`StandardDeviationPopulation` Performs Standard Deviation on the entire dataset (Population)</br>

### XmlDocumentExtensions (2)
`AppendXml` Append one or multiple XML documents to the current XML document</br>
`DeserializeXml<T>` Deserializes XMLDocument to type &lt;T&gt;.</br> 

### TimeSpanExtensions (10)

`MilliSeconds` Get TimeSpan.FromMilliSeconds() from int and double </br>
`Seconds` Get TimeSpan.FromSeconds() from int and double </br> 
`Minutes` Get TimeSpan.FromMinutes() from int and double </br> 
`Hours` Get TimeSpan.FromHours() from int and double </br> 
`Days` Get TimeSpan.FromDays() from int and double </br> 
