using System.Diagnostics;

string naam;
string email;

string titel;
DateOnly datum;
string beschrijving;
int aantalgenodigden;


string naamgenodigde;
string emailgenodigde;

public class Activiteit
{
    public string NaamActiviteit { get; set; }
    public string DatumActiviteit { get; set; }
    public string Beschrijving { get; set; }

}

public class Uitnodiging
{
    private Activity activity;
    private string organisatorNaam;
    private List<string> genodigden;

    public Uitnodiging()
    {
        genodigden = new List<string>();
    }

    public void VoerGegevensIn()
    {
        Console.WriteLine("Naam organisator: ");
        string organisatorNaam = Console.ReadLine();
        Console.WriteLine("Email organisator: ");
        string organisatorEmail = Console.ReadLine();
    }

    public void PlanActiviteit()
    {
        Console.WriteLine("Naam activiteit: ");
        string naamactiviteit = Console.ReadLine();
        Console.WriteLine("Datum activiteit: ");
        string datumactiviteit = Console.ReadLine();
        Console.WriteLine("Beschrijving activiteit: ");
        string beschrijvingactiviteit = Console.ReadLine();
    }

    public void UitnodigenMensen()
    {
        Console.WriteLine("Hoeveel mensen wil je uitnodigen? ");
        int aantalUitnodigingen = int.Parse(Console.ReadLine());
        for (int i = 0; i < aantalUitnodigingen; i++)
        {
            Console.WriteLine("Naam genodigde: ", i + 1);
            string genodigde = Console.ReadLine();
            genodigden.Add(genodigde);
        }
    }

    public void VerstuurUitnodigingen()
    {
        for(int i = 0; i < genodigden.Count; i++)
        {
            Console.WriteLine("Beste ," + genodigden[i] + " \n\nOp " + activity.DatumActiviteit + " ben je uitgenodigd voor een " + activity.NaamActiviteit + ". " + activity.Beschrijving + ": Kom je ook?\n");
            Console.WriteLine("Met vriendelijke groeten, ");
            Console.WriteLine(organisatorNaam);
        }
    }

    public void Run()
    {
        VoerGegevensIn();
        PlanActiviteit();
        UitnodigenMensen();
        VerstuurUitnodigingen();
    }

    static void Main(string[] args)
    {
        Uitnodiging uitnodiging = new Uitnodiging();
        uitnodiging.Run();
    }
}