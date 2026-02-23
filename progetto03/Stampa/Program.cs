
namespace Stampa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Models.Scuola.Studenti studente = new();
            studente.nome = "Mario";
            studente.cognome = "Rossi";
            studente.eta = 20;

            Console.WriteLine($"Nome: {studente.nome} cognome: {studente.cognome} età {studente.eta}");
        }
    }
}
