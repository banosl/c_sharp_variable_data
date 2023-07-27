// This was showing how when result was set as int it wouldn't implicitly convert "4" to a digit because
// it wasn't a safe conversion.

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

//Convert a string to an int using Parse()

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// Convert a string to a int using the 'Convert' class

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// TryParse() a string into an int

// string Value = "102b";
// int result = 0;
// if(int.TryParse(Value, out result))
// {
//   Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//   Console.WriteLine("Unable to report the measurement.");
// }

// Code challenge 1

// string[] values = {"12.3", "45", "ABC", "11", "DEF"};
// string message = "";
// decimal total = 0;

// foreach (string value in values)
// {
//   decimal hold = 0;  
//   if (decimal.TryParse(value, out hold))
//   {
//     total += hold;
//   }
//   else
//   {
//     message += value;
//   }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

//Code challenge 2

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / Convert.ToInt32(value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");