# SmartExtensions

A big list of commonly used methods and extension methods when using C# built-in types. 
Methods and extensions all of us write often enough to render grouping them in a nuget package useful. 


## Currently Available Extension methods
Most are self explanatory by name but for some, details will be given to explain them. Documentation is included in the source code as well

### StringExtensions

`CaseInsensitiveContains`
`CaseInsensitiveCompare`
`ToValueOrDefault`
`IsNullOrEmpty`
`RemoveSpaces`
`TryToInt16`
`TryToInt32`
`TryToInt64`
`TryToDate`
`TryToDecimal`

### MathExtensions

`Pow` - Several extensions exist for this one. Some of them are for simplicity. But in general it has been measured that using a loop for calculating the positive power of any number is faster than using the whole logic of the built-in Pow method which has a lot of checks for negative or non-integer numbers