using ConsoleGUI;
try
{
ConsoleGUI.ConsoleGUI menu = new();
menu.Menu();
}
catch (Exception e)
{
    File.WriteAllText("exception_log.txt", e.ToString());
}
