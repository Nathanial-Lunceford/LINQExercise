// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> faveGames = new List<string>();
        faveGames.Add("Dark Souls");
        faveGames.Add("Bloodborne");
        faveGames.Add("Borderlands 2");
        faveGames.Add("Ico");

        List<string> orderedGames = faveGames.OrderBy(x => x.Length).ToList();
        string darkSouls = faveGames.Where(x => x == "Dark Souls").ToString();
        List<string> firstTwo = orderedGames.Take(2).ToList();

        foreach(string s in orderedGames)
        {
            Console.WriteLine(s);
        }

    }
}