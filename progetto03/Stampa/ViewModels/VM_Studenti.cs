using Models.Scuola;

namespace Stampa.ViewModels
{
    public class VM_Studenti
    {
        public VM_Studenti()
        {
            Studenti studente = new();
            studente.nome = "Mario";
            studente.cognome = "Rossi";
            studente.eta = 20;

            Console.WriteLine($"Nome: {studente.nome} cognome: {studente.cognome} età {studente.eta}");


            Studenti st = new("Moussa", "Salisou", 10);
            Console.WriteLine($"\nNome: {st.nome} e cognome: {st.cognome} età {st.eta}");


            st.Saluta();


            //Popolamento di una lista di studenti
            List<Studenti> studenti = new()
            {
                new Studenti { nome = "Mario", cognome = "Rossi", eta = 20 },
                new Studenti { nome = "Luigi", cognome = "Verdi", eta = 22 },
                new Studenti { nome = "Giulia", cognome = "Bianchi" },
                new Studenti { nome = "Anna", cognome = "Neri" },
                new Studenti { nome = "Sara", eta = 18 },
                new Studenti { nome = "Paolo", eta = 23 }
            };

            // Stampa della lista di studenti
            foreach (var s in studenti)
            {
                Console.WriteLine($"Nome: {s.nome} cognome: {s.cognome} età {s.eta}");
            }



            // Stampa nome completo di ogni studente
            foreach (var s in studenti)
            {
                Console.WriteLine($"\nNome completo: {s.NomeCompleto(s.nome + s.cognome)}");
            }


            //studenti.Add();

            //studenti.Sort(); // per ordinare la lista di studenti, è necessario implementare l'interfaccia IComparable nella classe Studenti

        }
    }
}
