namespace ConsoleGUI;
using Core;
public class ConsoleGUI
{
    int currentPage = 0;
    readonly int gamesForPage = 10;
    List<string> games;
    public ConsoleGUI()
    {
        games = [];
    }
    public void Menu()
    {
        // List Games
        while (true)
        {
            games = Core.GetGamesList();

            int selectedIndex = SelectGameIndex();

            Core.ExecuteGame(games[selectedIndex]);
        }
    }

    void ShowGameList()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Select a game typing the number of the list and pressing enter.");
        Console.WriteLine("Enter e for exit the program.");
        Console.ForegroundColor = ConsoleColor.Blue;
        for (int i = 0; i < GamesAtScreen(); i++)
        {
            Console.WriteLine($"{i}. {games[currentPage * gamesForPage + i]}");
        }
        Console.ResetColor();
        if (currentPage > 0)
        {
            Console.WriteLine("p. Previous page");
        }
        if (MoreGamesAvailable())
        {
            Console.WriteLine("n. Next page");
        }

    }

    int SelectGameIndex()
    {
        while (true)
        {
            ShowGameList();
            string? entry = Console.ReadLine();

            if (entry == "e")
            {
                Environment.Exit(0);
            }
            if (entry == "p" && currentPage > 0)
            {
                currentPage -= 1;
            }
            if (entry == "n" && MoreGamesAvailable())
            {
                currentPage += 1;
            }
            if (int.TryParse(entry, out int result) && InRange(result))
            {
                return result;
            }
            else
            {
                continue;
            }
        }
    }
    bool InRange(int result)
    {
        return result > -1 && result <= GamesAtScreen();
    }

    bool MoreGamesAvailable() => games.Count - currentPage * gamesForPage > gamesForPage;
    int GamesAtScreen()
    {
        int remaining = games.Count - currentPage * gamesForPage;
        if (remaining > gamesForPage)
        {
            return gamesForPage;
        }
        return remaining;
    }
}