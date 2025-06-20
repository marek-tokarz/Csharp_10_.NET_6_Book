﻿// See https://aka.ms/new-console-template for more information
//#error version
using System.Reflection;

// declaration of unused variables
// with types from external assemblies
System.Data.DataSet ds;
HttpClient client;

Assembly? assembly = Assembly.GetEntryAssembly();

if (assembly == null)
{
    return;
}

// loop to check assemblies that application refers to
foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    // load each assembly in order to read details about that assembly
    var A = Assembly.Load(name);

    // variable to sum all the methods
    int numberOfMethods = 0;

    // look to check all types from assembly
    foreach (var t in A.DefinedTypes)
    {
        // sum a number of methods
        numberOfMethods += t.GetMethods().Count();
    }

    // print a number of types and its methods
    Console.WriteLine(
        "In ASSEMBLY {0} there is {1} of types and {2} of methods.",
        arg0: name.Name,
        arg1: A.DefinedTypes.Count(),
        arg2: numberOfMethods
    );
}

// nameof
double heightInMeters = 1.88;
Console.WriteLine($"Variable {nameof(heightInMeters)} has value {heightInMeters}");

// literal string sequences - with: '@'
// example with a file path
string filePath = @"C:\tvs\sony\bravia.txt";

// numbers notations
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// checking if above numbers are equal
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

// operator sizeof(), MinValue, MaxValue
Console.WriteLine(
    $"Type 'int' has {sizeof(int)} bytes and can store numbers of range from: {int.MinValue} to {int.MaxValue}."
);
Console.WriteLine(
    $"Type 'double' has {sizeof(double)} bytes and can store numbers of range from: {double.MinValue} to {double.MaxValue}."
);
Console.WriteLine(
    $"Type 'decimal' has {sizeof(decimal)} bytes and can store numbers of range from: {decimal.MinValue} to {decimal.MaxValue}."
);

// comparing types: double and decimal

Console.WriteLine("Double");
double a = 0.1;
double b = 0.2;

if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals 0.3");
}
else
{
    Console.WriteLine($"{a} + {b} not equals 0.3");
}

decimal c = 0.1M;
decimal d = 0.2M;

Console.WriteLine("Decimal");
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals 0.3");
}
else
{
    Console.WriteLine($"{c} + {d} not equals 0.3");
}

Console.ReadKey();
