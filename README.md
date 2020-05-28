# SmartExtensions

A big list of commonly used methods and extension methods when using C# built-in types. 
Methods and extensions all of us write often enough to render grouping them in a nuget package useful. 


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

### MathExtensions

`Pow` - Several extensions exist for this one. Some of them are for simplicity. But in general it has been measured that using a loop for calculating the positive power of any number is faster than using the whole logic of the built-in Pow method which has a lot of checks for negative or non-integer numbers