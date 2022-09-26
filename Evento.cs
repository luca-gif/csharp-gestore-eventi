// See https://aka.ms/new-console-template for more information
public class Evento
{

    public Evento(string titolo, DateTime data, int capienzaMax)
    {
        Titolo = titolo;
        Data = data;
        CapienzaMax = capienzaMax;
        PostiPrenotati = 0;
    }

    public string Titolo { 
        get { return Titolo; } 

        set { 
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Il titolo deve contenere almeno 3 caratteri");
                Titolo = value;
            } 
        } 
    }

    public DateTime Data
    {
        get { return Data; }

        set
        {
            if (Data < DateTime.Now)
            {
                throw new ArgumentException("Inserisci una data valida");
                Data = value;
            }
        }
    }
    public int CapienzaMax { get; private set; }
    public int PostiPrenotati { get; private set; }

    public int PrenotaPosti(int posti)
    {
        if (Data < DateTime.Now) throw new ArgumentException("L'evento è terminato");
        if (CapienzaMax <= PostiPrenotati + posti) throw new ArgumentException("Non ci sono più posti disponibili");

        PostiPrenotati += posti;
        return PostiPrenotati;
    
    }

    public int DisdiciPosti(int posti)
    {
        if (Data < DateTime.Now) throw new ArgumentException("L'evento è terminato");
        return PostiPrenotati -= posti;
    }

    public override string ToString()
    {
        Data.ToString("dd/MM/yyyy");

        return $"Il {Data} ci sarà l'evento: {Titolo}";
    }
}