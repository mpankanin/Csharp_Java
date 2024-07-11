//Console.WriteLine("Hello, World!"); - its an equivalent of Java's System.out.println("Hello, World!");
//C# beneath the scenes wraps the code in a class and a Main method

class Program
{
    private string _name = "John";
    //private fields convention in C# is to use an underscore before the field name

    public string LastName { get; set; }
    //this field is a property, and the convention in C# is to use PascalCase for properties
    //this is a shorthand for creating a private field and a public accessor methods
    //in Rider, you can use the shortcut "prop" and press tab twice to create a property

    private readonly string _middleName = "Doe";
    //readonly fields are like final fields in Java, they can only be assigned once

    public static void Main()
    {
//        Method conventions in C# are PascalCase
//                         In Java are camelCase
        Console.WriteLine("Hello, World!");

        //string is written with a lowercase s in C# but it's still an object
        string name = "John";

        //var is a keyword that tells the compiler to infer the type of the variable
        var birthdate = DateTime.Now;
        
    }
}