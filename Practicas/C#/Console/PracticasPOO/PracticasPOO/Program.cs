using PracticasPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        AvisosTrafico avisosTrafico = new AvisosTrafico();
        AvisosTrafico avisosTrafico2 = new AvisosTrafico("Federico Aran", "Mensaje personalizado", DateTime.Now);

        Console.WriteLine(avisosTrafico.GetFecha());
    }
}