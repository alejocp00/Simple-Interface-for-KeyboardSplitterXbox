using System.Diagnostics;
using System.Xml;

namespace Core;

public class Core
{

    public static List<string> GetGamesList()
    {
        XmlReader reader = XmlReader.Create("splitter_games.xml");

        List<string> games = [];

        while (reader.Read())
        {
            if (reader.Name == "Game")
            {
                string title = reader.GetAttribute("Title")!;
                if (!string.IsNullOrWhiteSpace(title))
                    games.Add(title);
            }
        }
        return games;
    }

    public static void ExecuteGame(string game)
    {
        // BUG: When the KeyboardSplitter is called from the app, it cannot find the game
        // Process.Start("KeyboardSplitter.exe", $"game=\"{game}\"");
        File.WriteAllText("start.bat", $"KeyboardSplitter.exe game=\"{game}\"");
    }
}

