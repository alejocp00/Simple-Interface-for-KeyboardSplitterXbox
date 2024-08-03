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
                games.Add(reader.GetAttribute("Title")!);
            }
        }
        return games;
    }

    public static void ExecuteGame(string game)
    {
        Process.Start("KeyboardSplitter.exe", $"game=\"{game}\"");
    }
}

