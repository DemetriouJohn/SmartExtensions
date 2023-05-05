# SmartExtensions

A big list of commonly used methods and extension methods when using C# built-in types. 
Methods and extensions all of us write often enough to render grouping them in a nuget package useful. 

![.NET Core Build and Run Unit Tests](https://github.com/DevsAnon/SmartExtensions/workflows/.NET%20Core%20Build%20and%20Run%20Unit%20Tests/badge.svg?event=push)

## Installation

```PM>
Install-Package SmartExtensionMethods
```

## Currently Available Extension methods (56)

### StringExtensions

`CaseInsensitiveContains` Checks if string is contained using case insensitive search<br/><br/> 
`CaseInsensitiveCompare` Compares two string using insensitive case<br/><br/> 
`ToValueOrDefault` Returns value or if null, returns provided default value<br/><br/> 
`IsNullOrEmpty` Checks if string is null or empty<br/><br/> 
`IsNullOrWhitespace` Checks if string is null or white space<br/><br/> 
`RemoveSpaces` Removes all spaces from string<br/><br/> 
`TryToInt16` Casts string to short using the try pattern<br/><br/> 
`TryToInt32` Casts string to int using the try pattern<br/><br/> 
`TryToInt64` Casts string to long using the try pattern<br/><br/> 
`TryToDate` Casts string to date using the try pattern<br/><br/> 
`TryToDecimal` Casts string to decimal using the try pattern<br/><br/> 
`TryToDouble` Casts string to double using the try pattern<br/><br/> 
`Reverse` Reverses the string<br/><br/> 
`IsEmail` Checks if string is an email string<br/><br/> 
`ExtractEmail` Returns a new string containing an email from the original string. If no email found returns String.empty<br/><br/> 
`IsPhone` Checks if string resembles a phone number<br/><br/> 
`IsPalindrome` Checks if string is a palindrome<br/><br/> 
`ContainsAll` Check whether the specified string contains an array of strings for each.<br/><br/> 
`DeserializeXml<T>` Deserializes string XML to type &lt;T&gt;.<br/><br/> 
`Nl2Br` Converts Windows and Linux new line characters to HTML break characters<br/><br/>
`EqualsAny` Check that the given string is in a list of potential matches.<br/><br/>
`Join` Joins a list of strings with the provided separator<br/><br/>
`JoinWithComma` Joins a list of strings with ", "<br/><br/>
`JoinWithSpace` Joins a list of strings with a single space<br/><br/>
`GetEnumValue` Get Enum value (case inssensitive) or return provided default if not found<br/><br/>
`ToCamelCase` Converts a string with spaces to a string with camelCase representation<br/><br/>

### DoubleExtensions

`IsNaN`<br/><br/>
`IsInfinity`<br/><br/>
`GetPercentage` Returns a value representing the percentage requested<br/><br/>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster<br/><br/>
`KB` Returns value in Kilobytes <br/><br/>
`MB` Returns value in Megabytes <br/><br/>
`GB` Returns value in Gigabytes <br/><br/>
`TB` Returns value in Terabytes <br/><br/>

### FloatExtensions

`IsNaN`<br/><br/>
`IsInfinity`<br/><br/>
`GetPercentage` Returns a value representing the percentage requested<br/><br/>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster<br/><br/>
`KB` Returns value in Kilobytes <br/><br/>
`MB` Returns value in Megabytes <br/><br/>
`GB` Returns value in Gigabytes <br/><br/>
`TB` Returns value in Terabytes <br/><br/>

### IntExtensions

`GetPercentage` Returns a value representing the percentage requested<br/><br/>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster<br/><br/>
`KB` Returns value in Kilobytes <br/><br/>
`MB` Returns value in Megabytes <br/><br/>
`GB` Returns value in Gigabytes <br/><br/>
`TB` Returns value in Terabytes <br/><br/>
`IsPrime` Checks if number is Prime <br/><br/>

### ShortExtensions

`GetPercentage` Returns a value representing the percentage requested<br/><br/>
`Pow` Extension method for performing Pow arithmetic expression when Power is a positive non-zero, non floating point number by using loop implementation as it is benchmarked to be faster<br/><br/>
`KB` Returns value in Kilobytes <br/><br/>
`MB` Returns value in Megabytes <br/><br/>
`GB` Returns value in Gigabytes <br/><br/>
`TB` Returns value in Terabytes <br/><br/>
`IsPrime` Checks if number is Prime <br/><br/>

### DateTimeExtensions

`FirstDayOfMonth` Get first day of the month<br/><br/>
`FirstDayOfMonth` Get first specific day of the month<br/><br/>
`NextSpecificDay` Next specific day<br/><br/>
`LastDayOfMonth` Get last day of the month<br/><br/>
`LastDayOfMonth` Get last specific day of the month<br/><br/>
`SetTime` Get DateTime with specific time. Overloads for minute accuracy, second accuracy and milisecond accuracy<br/><br/>
`GetNoon` Gets a DateTime representing noon on the current date<br/><br/>
`GetMidnight` Gets a DateTime representing midnight on the current date<br/><br/>
`Age` Gets the age of a person<br/><br/>
`ToUnixEpoch` Converts UTC time to Unix time<br/><br/>
`FromUnixEpoch` Converts Unix time to UTC time<br/><br/>
`FirstBusinessDayOfMonth` Gets a DateTime representing the first business day of the month of the provided DateTime<br/><br/>
`FirstBusinessDayOfMonth` Gets a DateTime representing the first business day of the month of the provided DateTime that is not part of a given holidays list<br/><br/>
`LastBusinessDayOfMonth` Gets a DateTime representing the last business day of the month of the provided DateTime<br/><br/>
`LastBusinessDayOfMonth` Gets a DateTime representing the last business day of the month of the provided DateTime that is not part of a given holidays list<br/><br/>

### IEnumerableExtensions
`Sum` Introduced sum method for LINQ usage for TimeSpans<br/><br/>
`IsNullOrEmpty` Checks if Enumerable is null or empty<br/><br/>
`Foreach` Executes provided action on each item of the Enumerable<br/><br/>
`StandardDeviation <int>` Performs Standard Deviation on the entire dataset<br/><br/>
`StandardDeviationPopulation <int>` Performs Standard Deviation on the entire dataset (Population)<br/><br/>
`ToHashSet<T>` Takes any IEnumerable<T> and converts it to a HashSet<T><br/><br/>


### XmlDocumentExtensions
`AppendXml` Append one or multiple XML documents to the current XML document<br/><br/>
`DeserializeXml<T>` Deserializes XMLDocument to type &lt;T&gt;.<br/><br/> 

### TimeSpanExtensions

`MilliSeconds` Get TimeSpan.FromMilliSeconds() from int and double <br/><br/>
`Seconds` Get TimeSpan.FromSeconds() from int and double <br/><br/> 
`Minutes` Get TimeSpan.FromMinutes() from int and double <br/><br/> 
`Hours` Get TimeSpan.FromHours() from int and double <br/><br/> 
`Days` Get TimeSpan.FromDays() from int and double <br/><br/> 

## Contributing
Contributions are always welcome! Please feel free to submit pull requests and to open issues. I prefer to have tests on all public methods if possible and where ever else makes sense.
