using Models.Scuola;

namespace HelloWorld.ViewModels
{
    public class VMStudenti
    {
        // proprietà
        public List<Studenti> lista { get; set; }

        public VMStudenti()
        {
            lista = new()
            {
                new Studenti { nome = "Mario",  cognome = "Rossi", eta = 20 },
                new Studenti { nome = "Luigi",  cognome = "Verdi", eta = 22 },
                new Studenti { nome = "Giulia", cognome = "Bianchi", eta = 35 },
                new Studenti { nome = "Anna",   cognome = "Neri", eta = 62 },
                new Studenti { nome = "Sara",   cognome = "Blu", eta = 18 },
                new Studenti { nome = "Paolo",  cognome = "Sarto", eta = 23 }
            };
        }
    }
}
