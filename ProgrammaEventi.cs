
public class ProgrammaEventi

//Constructor
{
    public ProgrammaEventi(string titolo)
    {
        Titolo = titolo;
        ListaEventi = new List<Evento>();

    }

    public string Titolo { get; set; }
    public List<Evento> ListaEventi { get; set; }

    //Aggiunge l'evento alla lista
    public void AggiungiEvento(Evento evento)
    {
        ListaEventi.Add(evento);
    }

    //Restituisce una lista di eventi con tutti gli eventi presenti in una certa data
    public List<Evento> EventiPerData(DateTime data)
    {
        List<Evento> nuovaLista = new List<Evento>();

        foreach (Evento evento in ListaEventi)
        {
            if (evento.Data == data)
            {
                nuovaLista.Add(evento);
            }
        }
        return nuovaLista;
    }

    //Stampa la lista in console
    public void StampaEventi()
    {
        foreach (Evento evento in ListaEventi)
        {
            Console.WriteLine(evento);
        }
    }

    //Restituisce quanti eventi sono presenti nel programma eventi attualmente
    public void ContatoreEventi()
    {
        Console.WriteLine($"Il numero di eventi presenti nel programma è: {ListaEventi.Count()}");
    }

    //Svuota la lista degli eventi
    public void SvuotaLista()
    {
        ListaEventi.Clear();
    }

    //restituisce una stringa che mostra il titolo del programma e tutti gli eventi aggiunti alla lista.
    public string StampaTitoloEdEventi()
    {
        string stringaEventi = "";

        foreach (Evento evento in ListaEventi)
        {
            stringaEventi += evento.ToString();
        }

        string str = Titolo + stringaEventi;
        return str;
    }

}