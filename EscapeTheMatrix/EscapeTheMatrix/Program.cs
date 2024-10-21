namespace EscapeTheMatrix;

class Program
{
    static void Main(string[] args)
    {
        Day GameDay = new Day("21. October, 1999");
        bool gameRunning = true;
        while (gameRunning)
        {
            Console.WriteLine($"{GameDay}. Houston, TX\nDu vågner og kigger rundt i dit lille soveværelse, du har en underlig følelse i kroppen.");
        }
    }
}

