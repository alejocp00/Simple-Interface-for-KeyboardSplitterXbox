namespace Preset;

/// <summary>
/// Represents a button in the xml preset
/// </summary>
public class ButtonInfo
{
    /// <summary>
    /// Represents the id of the button in the xml preset
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Represents the keyboard key of the button
    /// </summary>
    public string KeyboardKey { get; set; }

    public ButtonInfo(string id, string kKey)
    {
        Id = id;
        KeyboardKey = kKey;
    }
}