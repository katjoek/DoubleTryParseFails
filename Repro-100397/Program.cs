// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

var options = new JsonSerializerOptions { WriteIndented = true, ReferenceHandler = ReferenceHandler.IgnoreCycles };
var jsonString = JsonSerializer.Serialize(CultureInfo.CurrentCulture, options);
Console.WriteLine(jsonString);
Console.WriteLine();

double value1 = 2000;
var str = value1.ToString("N5");
Console.WriteLine($"str: {str}");

var success = double.TryParse(str, NumberStyles.Any, CultureInfo.CurrentCulture, out double value2);
Console.WriteLine($"success: {success}");
Console.WriteLine($"value: {value2}");

