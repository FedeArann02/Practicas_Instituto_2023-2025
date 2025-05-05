using System.Collections;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    public static bool Valid = false;
    public static string Nombre;
    public static string Contraseña;
    public static ArrayList BD = new ArrayList();
    private static void Main(string[] args)
    {
        do
        {
            do
            {
                Console.Write("Hola, ingrese su nombre de usuario: ");
                Nombre = Console.ReadLine();
                Console.Write("Hola, ingrese su contraseña: ");
                Contraseña = Console.ReadLine();
                Valid = EntradaInvalida(Nombre, Contraseña);
            }
            while (Valid == false);

            BD.Add("Federico12345");
            BD.Add("Pepe12345");
            BD.Add("Kari12345");
        }
        while (ValidarBD(Nombre, Contraseña) == false);
    }

    public static bool EntradaInvalida(string Name, string Pass)
    {
        if (Name == ""|| Pass == "")
        {
            Console.Write("Ingrese un nombre o contraseña válida\n");
            Valid = false;
        }
        else
        {
            Valid = true;
            
        }

        return Valid;
    }
    public static bool ValidarBD(string name, string password)
    {
        string cred = name + password;
        Valid = BD.Contains(cred);
        if (Valid != true) 
        {
            Console.Write("Este usuario no se encuentra registrado\n");
        }
        else
        {
            Console.Write("¡Sesión iniciada correctamente!");
        }
        return Valid;
    }
}