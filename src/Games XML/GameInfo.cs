namespace Game;

/// <summary>
/// Represents a game in the games xml
/// </summary>
class GameInfo
{
    /// <summary>
    /// The title of the game. This is used for invoking the game
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Any notes about the game
    /// </summary>
    public string Notes { get; set; }

    /// <summary>
    /// Path to the game executable
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// Whether to block keyboards from being used
    /// </summary>
    public string BlockKeyboards { get; set; }

    /// <summary>
    /// Whether to block mice from being used
    /// </summary>
    public string BlockMice { get; set; }

    /// <summary>
    /// The gamepad slots in the game
    /// </summary>
    public SlotInfo[] Slots { get; set; }

    public GameInfo(string title, string notes, string path, string blockKeyboards, string blockMice, SlotInfo[] slots)
    {
        Title = title;
        Notes = notes;
        Path = path;
        BlockKeyboards = blockKeyboards;
        BlockMice = blockMice;
        Slots = slots;
    }

}