static double Srednia(int[] liczby)
{
    if (liczby == null || liczby.Length == 0) return 0;
    return liczby.Average();
}

int[] numery = { 2, 4, 6, 8 };
Console.WriteLine($"Średnia: {Srednia(numery)}");


static int Max(int[] liczby)
{
    if (liczby == null || liczby.Length == 0) return 0;
    return liczby.Max();
}
