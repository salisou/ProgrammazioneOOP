using Stampa.ViewModels;

namespace Stampa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VM_Studenti _Studenti = new();

            // Stampa i dati degli studenti
            Console.WriteLine(_Studenti);
        }
    }
}
