public class Klant
{
    private string name { get; set; }
    private int leeftijd { get; set; }
    private string adres { get; set; }
    private string telefoonnummer { get; set; }
}

public class Klantbeheerder
{
    private List<Klant> klanten;

    public Klantbeheerder()
    {
        klanten = new List<Klant>();
    }

    public void VoegKlantToe(Klant klant)
    {
        klanten.Add(klant);
    }

    public void VerwijderKlant(Klant klant)
    {
        klanten.Remove(klant);
    }

    public void BewerkKlant(Klant klant)
    {
        Console.WriteLine("Wat wil je bewerken?");
        Console.WriteLine("1. Naam");
        Console.WriteLine("2. Leeftijd");
        Console.WriteLine("3. Adres");
        Console.WriteLine("4. Telefoonnummer");
        int keuze = int.Parse(Console.ReadLine());
        switch (keuze)
        {
            case 1:
                Console.WriteLine("Nieuwe naam: ");
                klant.name = Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("Nieuwe leeftijd: ");
                klant.leeftijd = int.Parse(Console.ReadLine());
                break;
            case 3:
                Console.WriteLine("Nieuw adres: ");
                klant.adres = Console.ReadLine();
                break;
            case 4:
                Console.WriteLine("Nieuw telefoonnummer: ");
                klant.telefoonnummer = Console.ReadLine();
                break;
            default:
                Console.WriteLine("Ongeldige keuze");
                break;
        }
    }
}