// See https://aka.ms/new-console-template for more information
//#error version
using System.Reflection;

Assembly? assembly = Assembly.GetEntryAssembly();

if (assembly == null)
{
    return;
}

// loop to check assemblies that application refers to
foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    // load each assembly in order to read details about that assembly
    var a = Assembly.Load(name);

    // variable to sum all the methods
    int numberOfMethods = 0;

    // look to check all types from assembly
    foreach (var t in a.DefinedTypes)
    {
        // sum a number of methods
        numberOfMethods += t.GetMethods().Count();
    }

    // print a number of types and its methods
    Console.WriteLine(
        "In ASSEMBLY {0} there is {1} of types and {2} of methods.",
        arg0: name.Name,
        arg1: a.DefinedTypes.Count(),
        arg2: numberOfMethods
    );
}

Console.ReadKey();
