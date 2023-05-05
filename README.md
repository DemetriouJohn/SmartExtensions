# SmartExtensions

A big list of commonly used methods and extension methods when using C# built-in types. 
Methods and extensions all of us write often enough to render grouping them in a nuget package useful. 

![.NET Core Build and Run Unit Tests](https://github.com/DevsAnon/SmartExtensions/workflows/.NET%20Core%20Build%20and%20Run%20Unit%20Tests/badge.svg?event=push)

## Installation

```PM>
Install-Package SmartExtensionMethods
```

## Currently Available Extension methods (84)

### StringExtensions

1. `CaseInsensitiveContains` Checks if string is contained using case insensitive search 
1. `CaseInsensitiveCompare` Compares two string using insensitive case 
1. `ToValueOrDefault` Returns value or if null, returns provided default value 
1. `IsNullOrEmpty` Checks if string is null or empty 
1. `IsNullOrWhitespace` Checks if string is null or white space 
1. `RemoveSpaces` Removes all spaces from string 
1. `TryToInt16` Casts string to short using the try pattern 
1. `TryToInt32` Casts string to int using the try pattern 
1. `TryToInt64` Casts string to long using the try pattern 
1. `TryToDate` Casts string to date using the try pattern 
1. `TryToDecimal` Casts string to decimal using the try pattern 
1. `TryToDouble` Casts string to double using the try pattern 
1. `Reverse` Reverses the string 
1. `IsEmail` Checks if string is an email string 
1. `ExtractEmail` Returns a new string containing an email from the original string. If no email found returns String.empty 
1. `IsPhone` Checks if string resembles a phone number 
1. `IsPalindrome` Checks if string is a palindrome 
1. `ContainsAll` Check whether the specified string contains an array of strings for each. 
1. `DeserializeXml<T>` Deserializes string XML to type &lt;T&gt;. 
1. `Nl2Br` Converts Windows and Linux new line characters to HTML break characters
1. `EqualsAny` Check that the given string is in a list of potential matches.
1. `Join` Joins a list of strings with the provided separator
1. `JoinWithComma` Joins a list of strings with ", "
1. `JoinWithSpace` Joins a list of strings with a single space
1. `GetEnumValue` Get Enum value (case inssensitive) or return provided default if not found
1. `ToCamelCase` Converts a string with spaces to a string with camelCase representation

### DoubleExtensions

1. `IsNaN`
1. `IsInfinity`
1. `GetPercentage` Returns a value representing the percentage requested
1. `Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster
1. `KB` Returns value in Kilobytes 
1. `MB` Returns value in Megabytes 
1. `GB` Returns value in Gigabytes 
1. `TB` Returns value in Terabytes 

### FloatExtensions

1. `IsNaN`
1. `IsInfinity`
1. `GetPercentage` Returns a value representing the percentage requested
1. `Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster
1. `KB` Returns value in Kilobytes 
1. `MB` Returns value in Megabytes 
1. `GB` Returns value in Gigabytes 
1. `TB` Returns value in Terabytes 

### IntExtensions

1. `GetPercentage` Returns a value representing the percentage requested
1. `Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster
1. `KB` Returns value in Kilobytes 
1. `MB` Returns value in Megabytes 
1. `GB` Returns value in Gigabytes 
1. `TB` Returns value in Terabytes 
1. `IsPrime` Checks if number is Prime 

### ShortExtensions

1. `GetPercentage` Returns a value representing the percentage requested
1. `Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster
1. `KB` Returns value in Kilobytes 
1. `MB` Returns value in Megabytes 
1. `GB` Returns value in Gigabytes 
1. `TB` Returns value in Terabytes 
1. `IsPrime` Checks if number is Prime 

### DateTimeExtensions

1. `FirstDayOfMonth` Get first day of the month
1. `FirstDayOfMonth` Get first specific day of the month
1. `NextSpecificDay` Next specific day
1. `LastDayOfMonth` Get last day of the month
1. `LastDayOfMonth` Get last specific day of the month
1. `SetTime` Get DateTime with specific time. Overloads for minute accuracy, second accuracy and milisecond accuracy
1. `GetNoon` Gets a DateTime representing noon on the current date
1. `GetMidnight` Gets a DateTime representing midnight on the current date
1. `Age` Gets the age of a person
1. `ToUnixEpoch` Converts UTC time to Unix time
1. `FromUnixEpoch` Converts Unix time to UTC time
1. `FirstBusinessDayOfMonth` Gets a DateTime representing the first business day of the month of the provided DateTime
1. `FirstBusinessDayOfMonth` Gets a DateTime representing the first business day of the month of the provided DateTime that is not part of a given holidays list
1. `LastBusinessDayOfMonth` Gets a DateTime representing the last business day of the month of the provided DateTime
1. `LastBusinessDayOfMonth` Gets a DateTime representing the last business day of the month of the provided DateTime that is not part of a given holidays list

### IEnumerableExtensions
1. `Sum` Introduced sum method for LINQ usage for TimeSpans
1. `IsNullOrEmpty` Checks if Enumerable is null or empty
1. `Foreach` Executes provided action on each item of the Enumerable
1. `StandardDeviation <int>` Performs Standard Deviation on the entire dataset
1. `StandardDeviationPopulation <int>` Performs Standard Deviation on the entire dataset (Population)
1. `ToHashSet<T>` Takes any IEnumerable<T> and converts it to a HashSet<T>


### XmlDocumentExtensions
1. `AppendXml` Append one or multiple XML documents to the current XML document
1. `DeserializeXml<T>` Deserializes XMLDocument to type &lt;T&gt;. 

### TimeSpanExtensions

1. `MilliSeconds` Get TimeSpan.FromMilliSeconds() from int and double 
1. `Seconds` Get TimeSpan.FromSeconds() from int and double  
1. `Minutes` Get TimeSpan.FromMinutes() from int and double  
1. `Hours` Get TimeSpan.FromHours() from int and double  
1. `Days` Get TimeSpan.FromDays() from int and double  

## Contributing
Contributions are always welcome! Please feel free to submit pull requests and to open issues. I prefer to have tests on all public methods if possible and where ever else makes sense.
