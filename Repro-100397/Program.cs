// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

var options = new JsonSerializerOptions
{
    WriteIndented = true,
    ReferenceHandler = ReferenceHandler.IgnoreCycles,
};
var jsonString = JsonSerializer.Serialize(CultureInfo.CurrentCulture, options);
Console.WriteLine(jsonString);

var str = "2,000.000";
var success = double.TryParse(str, NumberStyles.Any, CultureInfo.CurrentCulture, out var value);
Console.WriteLine($"success: {success}");
Console.WriteLine($"value: {value}");