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
string risposta = Console.ReadLine();

if(risposta == "si")
{
    //Chiedo all'utente quante prenotazioni vuole effettuare
    Console.WriteLine("Quanti posti desideri prenotare?");
    int postiPrenotati = Convert.ToInt32(Console.ReadLine());

    mioEvento.PrenotaPosti(postiPrenotati);

    Console.WriteLine("Numero di posti disponibili" + (mioEvento.CapienzaMax - postiPrenotati));
}
else
{
    Console.WriteLine("Ok, buona giornata");
}
