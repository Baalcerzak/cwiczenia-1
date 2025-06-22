static double Srednia(int[] liczby)
{
    if (liczby == null || liczby.Length == 0) return 0;
    return liczby.Average();
}

int[] dane = { 2, 4, 6, 8 };
Console.WriteLine($"Średnia: {Srednia(dane)}");