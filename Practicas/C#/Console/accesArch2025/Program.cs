internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Files.Read("C:\\Users\\Leo\\Documents\\Archivo.txt"));

        string line = "Hola que tal soy fede y esta fecha es: " + DateTime.Now.ToString();
        Files.Write(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivoPrueba.txt", line);
    }
}

public class Files
{

    public static string Read(string Path)
    {
        string line = "";

        using (StreamReader reader = new StreamReader(Path))
        {
            
            while (reader.ReadLine() != null)
            {
                line = reader.ReadToEnd();
            }
        }

        return line;
    }

    public static void Write(string Path, string writeLine)
    {

        using (StreamWriter writer = new StreamWriter(Path))
        {
            writer.WriteLine(writeLine);
        }

    }

}