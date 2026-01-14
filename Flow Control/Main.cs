
string var = Console.ReadLine();

if(var == "true")
    System.Console.WriteLine("Hi");
else
    System.Console.WriteLine("Hello");

switch(var)
{
    case "true":
        System.Console.WriteLine("hi");
        break;
    case "false":
        System.Console.WriteLine("hello");
        break;
    default:
        System.Console.WriteLine("Nothing");
        break;
}