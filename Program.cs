//Chiedo all'utente di inserire il titolo
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
}
