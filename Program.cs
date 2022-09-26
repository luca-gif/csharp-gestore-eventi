
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Qual è il titolo del tuo programma eventi?");
string nomeEvento = Console.ReadLine();

ProgrammaEventi programmaEventi = new ProgrammaEventi(nomeEvento);

Console.WriteLine("Quanti eventi vuoi aggiungere?");
int n = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Scrivi il titolo del {i + 1}° evento");
    string titolo = Console.ReadLine();

    Console.WriteLine($"Inserisci la data (DD/MM/YYYY) {i + 1}° evento");
    DateTime data = Convert.ToDateTime(Console.ReadLine());

    Console.WriteLine($"Inserisci il numero di posti totali del {i + 1}° evento");
    int maxPosti = Convert.ToInt32(Console.ReadLine());

    Evento nuovoEvento = (new Evento(titolo, data, maxPosti));

    programmaEventi.ListaEventi.Add(nuovoEvento);
}


//Numero eventi presenti nel programma
programmaEventi.ContatoreEventi();

//Stampo tutti gli eventi
Console.WriteLine("Ecco tutti i tuoi eventi: ");
programmaEventi.StampaEventi();

//Ricerca per data
Console.WriteLine("Vuoi filtrare gli eventi per data?");
string cerca = Console.ReadLine();

if (cerca == "si")
{
    Console.WriteLine("Inserisci una data (DD/MM/YYYY)");
    DateTime dataDaCercare = Convert.ToDateTime(Console.ReadLine());

    programmaEventi.EventiPerData(dataDaCercare);

}

//Eliminare tutti gli eventi
Console.WriteLine("Vuoi eliminare tutti gli eventi?");
string delete = Console.ReadLine();
if (delete == "si")
{
    programmaEventi.SvuotaLista();
    Console.WriteLine("Tutti gli eventi sono stati eliminati!");
}



/* //Chiedo all'utente di inserire il titolo
Console.WriteLine("Inserisci il nome dell'evento");
string nuovoTitolo = Console.ReadLine();

//Chiedo all'utente di inserire il la data
Console.WriteLine("Inserisci la data dell'evento (dd/mm/yyyy)");
DateTime nuovaData = Convert.ToDateTime(Console.ReadLine());

//Chiedo all'utente di inserire la capienza massima
Console.WriteLine("Inserisci il numero di posti totali");
int nuovoMaxPosti = Convert.ToInt32(Console.ReadLine());

//Instanzio un nuovo evento con le info passate dall'utente
Evento mioEvento = new Evento(nuovoTitolo, nuovaData, nuovoMaxPosti);

//Chiedo all'utente se vuole prenotare dei posti
Console.WriteLine("Vuoi prenotare dei posti?");
string prenotare = Console.ReadLine();

if(prenotare == "si")
{
    //Chiedo all'utente quante prenotazioni vuole effettuare 
    Console.WriteLine("Quanti posti desideri prenotare?");
    int postiPrenotati = Convert.ToInt32(Console.ReadLine());

    mioEvento.PrenotaPosti(postiPrenotati);

    //Stampo a schermo i dati relativi alle prenotazioni
    Console.WriteLine("Numero di posti disponibili " + (mioEvento.CapienzaMax));
    Console.WriteLine("Numero di posti prenotati " + (mioEvento.PostiPrenotati));
}
else
{
    Console.WriteLine("Ok, buona giornata");
}

Console.WriteLine("Vuoi disdire dei posti?");
string disdire = Console.ReadLine();

if(disdire == "si")
{
    //Chiedo all'utente quante prenotazioni vuole disdire 
    Console.WriteLine("Quanti posti vuoi disdire?");
    int postiDaDisdire = Convert.ToInt32(Console.ReadLine());

    mioEvento.DisdisciPosti(postiDaDisdire);

    //Stampo a schermo i dati relativi alle prenotazioni
    Console.WriteLine("Numero di posti disponibili " + (mioEvento.CapienzaMax));
    Console.WriteLine("Numero di posti prenotati " + (mioEvento.PostiPrenotati));
}*/

