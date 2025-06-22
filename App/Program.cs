static double Srednia(int[] liczby)
{
    if (liczby == null || liczby.Length == 0) return 0;
    return liczby.Average();
}

int[] liczby = { 2, 4, 6, 8 };
Console.WriteLine($"Średnia: {Srednia(liczby)}");
Console.WriteLine($"Max: {Max(liczby)}");


static int Max(int[] liczby)
{
    if (liczby == null || liczby.Length == 0) return 0;
    return liczby.Max();
}
