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

    public string titolo;
    public string Titolo { 
        get { return Titolo; } 

        set { 
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Il titolo deve contenere almeno 3 caratteri");
                titolo = value;
            } 
        } 
    }

    public DateTime data;
    public DateTime Data
    {
        get { return data; }

        set
        {
            if (value < DateTime.Now)
            {
                throw new ArgumentException("Inserisci una data valida");
                data = value;
            }
        }
    }
    public int CapienzaMax { get; private set; }
    public int PostiPrenotati { get; private set; }

    public void PrenotaPosti(int posti)
    {
        if (Data > DateTime.Now) throw new ArgumentException("L'evento è terminato");
        if (CapienzaMax <= PostiPrenotati + posti) throw new ArgumentException("Non ci sono più posti disponibili");

        CapienzaMax -= posti;
        PostiPrenotati += posti;    
    }

    public void DisdisciPosti(int posti)
    {
        if (Data > DateTime.Now) throw new ArgumentException("L'evento è terminato");
        CapienzaMax += posti;
        PostiPrenotati -= posti;
    }

    public override string ToString()
    {
        Data.ToString("dd/MM/yyyy");

        return $"Il {Data} ci sarà l'evento: {Titolo}";
    }
}