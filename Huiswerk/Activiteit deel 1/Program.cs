string naam;
string email;

string titel;
DateOnly datum;
string beschrijving;
int aantalgenodigden;


string naamgenodigde;
string emailgenodigde;



Console.Write("Naam: "); naam = Console.ReadLine();
Console.Write("Email: "); email = Console.ReadLine();

Console.Write("Titel: "); titel = Console.ReadLine();
Console.Write("Datum: "); datum = DateOnly.Parse(Console.ReadLine());
Console.Write("Beschrijving: "); beschrijving = Console.ReadLine();
Console.Write("Aantal genodigden: "); aantalgenodigden = Convert.ToInt32(Console.ReadLine());
aantalgenodigden = aantalgenodigden + 1;

while (aantalgenodigden < 1)
{
    Console.WriteLine("Het aantal genodigden moet minstens 1 zijn.");
    Console.Write("Aantal genodigden: "); aantalgenodigden = Convert.ToInt32(Console.ReadLine());
}
while (aantalgenodigden > 1)
{
    Console.Write("Naam genodigde: "); naamgenodigde = Console.ReadLine();
    Console.Write("Email genodigde: "); emailgenodigde = Console.ReadLine();
    aantalgenodigden--;
}
Console.Clear();


Console.WriteLine("Beste gast ", "\n\nOp " + datum + " ben je uitgenodigd voor een " + titel + ". " + beschrijving + ": Kom je ook?\n");
Console.WriteLine("Met vriendelijke groeten, ");
Console.WriteLine(naam);