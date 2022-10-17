Random otal = new Random();
int y = otal.Next(1,100);
int gissning = 0;
Console.WriteLine("Gissa det okända talet mellan 1-100");
int summa = 1;
while (gissning != y)
{
    gissning = Int32.Parse(Console.ReadLine());
    if (gissning < y)
    {
        Console.WriteLine("Din gissning var för låg");
        summa++;
    }
    else if (gissning > y)
    {
        Console.WriteLine("Din gissning var för hög");
        summa++;
    }
}
Console.WriteLine("Du gissade rätt tal: " + y + " på " + summa + " försök");
