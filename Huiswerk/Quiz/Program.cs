class Quiz
{
    static void Main(string[] args)
    {
        int score = 0;

        Console.WriteLine("Wat is de hoofdstad van Frankrijk?");
        Console.WriteLine("A) Lille");
        Console.WriteLine("B) Parijs");
        Console.WriteLine("C) Marseille");
        Console.WriteLine("D) Lyon");
        Console.Write("Typ hier je antwoord: "); string antwoord1 = Console.ReadLine();
        if (antwoord1 == "B" || antwoord1 == "b")
        {
            score = score + 5;
        }
        Console.Clear();

        Console.WriteLine("Wat is de hoofdstad van Nederland?");
        Console.WriteLine("A) Den Haag");
        Console.WriteLine("B) Rotterdam");
        Console.WriteLine("C) Amsterdam");
        Console.WriteLine("D) Utrecht");
        Console.Write("Typ hier je antwoord: "); string antwoord2 = Console.ReadLine();
        if (antwoord2 == "C" || antwoord2 == "C")
        {
            score = score + 5;
        }
        Console.Clear();

        Console.WriteLine("Wat is de hoofdstad van België?");
        Console.WriteLine("A) Antwerpen");
        Console.WriteLine("B) Brussel");
        Console.WriteLine("C) Gent");
        Console.WriteLine("D) Luik");
        Console.Write("Typ hier je antwoord: "); string antwoord3 = Console.ReadLine();
        if (antwoord3 == "B" || antwoord3 == "b")
        {
            score = score + 10;
        }
        Console.Clear();

        Console.WriteLine("Wat is de hoofdstad van Duitsland?");
        Console.WriteLine("A) Berlijn");
        Console.WriteLine("B) Hamburg");
        Console.WriteLine("C) München");
        Console.WriteLine("D) Keulen");
        Console.Write("Typ hier je antwoord: "); string antwoord4 = Console.ReadLine();
        if (antwoord4 == "A" || antwoord4 == "a")
        {
            score = score + 10;
        }
        Console.Clear();

        Console.WriteLine("Wat is de hoofdstad van Spanje?");
        Console.WriteLine("A) Madrid");
        Console.WriteLine("B) Barcelona");
        Console.WriteLine("C) Valencia");
        Console.WriteLine("D) Sevilla");
        Console.Write("Typ hier je antwoord: "); string antwoord5 = Console.ReadLine();
        if (antwoord5 == "A" || antwoord5 == "a")
        {
            score = score + 10;
        }
        Console.Clear();

        Console.WriteLine("Wat is de hoofdstad van Polen?");
        Console.WriteLine("A) Warschau");
        Console.WriteLine("B) Krakau");
        Console.WriteLine("C) Gdansk");
        Console.WriteLine("D) Wroclaw");
        Console.Write("Typ hier je antwoord: "); string antwoord6 = Console.ReadLine();
        if (antwoord6 == "A" || antwoord6 == "a")
        {
            score = score + 10;
        }
        Console.Clear();

        Console.WriteLine("Wat is de hoofdstad van Italië?");
        Console.WriteLine("A) Napels");
        Console.WriteLine("B) Milaan");
        Console.WriteLine("C) Rome");
        Console.WriteLine("D) Turijn");
        Console.Write("Typ hier je antwoord: "); string antwoord7 = Console.ReadLine();
        if (antwoord7 == "C" || antwoord7 == "c")
        {
            score = score + 10;
        }
        Console.Clear();

        Console.WriteLine("Wat is de hoofdstad van Portugal?");
        Console.WriteLine("A) Coimbra");
        Console.WriteLine("B) Porto");
        Console.WriteLine("C) Faro");
        Console.WriteLine("D) Lissabon");
        Console.Write("Typ hier je antwoord: "); string antwoord8 = Console.ReadLine();
        if (antwoord8 == "D" || antwoord8 == "d")
        {
            score = score + 20;
        }
        Console.Clear();

        Console.WriteLine("Wat is de hoofdstad van Amerika?");
        Console.WriteLine("A) New York");
        Console.WriteLine("B) Los Angeles");
        Console.WriteLine("C) Washington D.C.");
        Console.WriteLine("D) Chicago");
        Console.Write("Typ hier je antwoord: "); string antwoord9 = Console.ReadLine();
        if (antwoord9 == "C" || antwoord9 == "c")
        {
            score = score + 20;
        }
        Console.Clear();

        int cijfer = score / 10;

        if (score < 55)
        {
            Console.WriteLine("Helaas, je hebt een " + cijfer + ". Je bent gezakt.");
        }
        else if (score >= 55)
        {
            Console.WriteLine("Gefeliciteerd, je hebt een " + cijfer + ". Je bent geslaagd!");
        }
    }
}