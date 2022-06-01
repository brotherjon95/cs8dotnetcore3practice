// See https://aka.ms/new-console-template for more information
object height = 1.88; // storing a double in a object
object name = "Jon"; // storing a string in a object

Console.WriteLine($"{name} is {height} meters tall.");

// int length1 = name.Length; // gives compile error
int length2 = ((string)name).Length; // tell compiler it is a string

Console.WriteLine($"{name} has {length2} characters.");

// storing a string in a dynamic object
dynamic anotherName = "Salazar";
// this compiles but would throw an exception at run-time. If you later store a data type that does not have a property named Length
int length = anotherName.Length;

int population = 66_000_000; // 66 million in UK
double weight = 1.88; // in kilograms
decimal price = 4.99M; // in pounds sterling
string fruit = "Apples"; // string uses double-quotes
char letter = 'Z'; // char use single-quotes
bool happy = true; // booleans have value of true or false

// good use of var because it avoids the repeated type as shown in the more verbose second statement
// var xml1 = new XmlDocument();
// XmlDocument xml2 = new XmlDocument();

// bad use of var because we cannot tell the type, so we should use a specific type declaration as shown in the second statement
// var file1 = File.CreateText(@"C:\something.txt");
// StreamWriter file2 = File.CreateText(@"C:\someting.txt");

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");