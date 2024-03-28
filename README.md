# DoubleTryParseFails
Small project to reproduce a problem I encounter with dotnet core 8.0

The problem is that a convert a double value to a string and that converting it back to a double does not work.

2000.0 => "2,000.000000" =!> 2000.0

When leaving out the thousands separator, double.TryParse does work 