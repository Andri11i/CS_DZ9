using CS_DZ9;
using System.Reflection;

Type type = typeof(SampleClass);
MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

foreach (var method in methods)
{
    var attributes = method.GetCustomAttributes(typeof(DocumentationAttribute), false);

    foreach (DocumentationAttribute attr in attributes)
    {
        Console.WriteLine($"Method: {method.Name}");
        Console.WriteLine($"  Author: {attr.Author}");
        Console.WriteLine($"  Version: {attr.Version}");
        if (!string.IsNullOrEmpty(attr.Desc))
        {
            Console.WriteLine($"  Description: {attr.Desc}");
        }
        Console.WriteLine();
    }
}