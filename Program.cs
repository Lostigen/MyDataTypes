using System.Runtime.CompilerServices;

namespace MyDataTypes;

class Program
{
    static void Main(string[] args)
    {
        /**
        int x;
        int y;

        x = 7;
        y = x + 3;
        Console.WriteLine(y);
        Console.ReadLine();
        return;
        **/

        // Fördefinerad variabel
        string myFirstName;
        Console.WriteLine("What is your name?");
        Console.Write("Write your first name: ");

        // Tilldelning av variabel
        myFirstName = Console.ReadLine();
        Console.Write("Write your last name: ");

        // Direktdefinerad variabel med tilldelning av värde
        string myLastName = Console.ReadLine();
        Console.WriteLine("Hello, and welcome " + myFirstName + " " + myLastName + ".");
        Console.ReadLine();
        return;
    }
}
