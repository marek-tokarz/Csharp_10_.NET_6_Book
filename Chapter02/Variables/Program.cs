using System.Xml;

// type object

object height = 1.88;
object name = "Peter";
Console.WriteLine($"{name} is {height} tall");

//int length1 = name.Lenght;
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters");

// storing a value of type string in a variable of type dynamic
// type string has feature Length
dynamic something = "Paul";
Console.WriteLine($"Length is {something.Length}");

// type int does not have a feature Length
//something = 12;
Console.WriteLine($"Length is {something.Length}");

// array of any type has feature Length
something = new[] { 3, 5, 7 };
Console.WriteLine($"Length is {something.Length}");

// type var allows us to skip a long type name like 'XmlDocument'
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

// this time var is used in a misleading way
var file1 = File.Create(@"C:\file.txt");

// now a type of a variable is clear, contrary to the above instruction
StreamWriter file2 = File.CreateText(@"C:\file.txt");

// keyword 'new'

XmlDocument xml3 = new();

Person peter = new();
peter.BirthDate = new(1967, 12, 26); // instead of new DateTime(1967, 12, 26)

Console.ReadLine();

class Person
{
    public DateTime BirthDate;
}
