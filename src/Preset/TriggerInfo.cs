namespace Preset;

/// <summary>
/// Represents a trigger in the xml preset
/// </summary>
public class TriggerInfo
{
    /// <summary>
    /// Represents the id of the button in the xml preset
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Represents the keyboard key of the trigger
    /// </summary>
    public string KeyboardKey { get; set; }

    public TriggerInfo(string id, string kKey)
    {
        Id = id;
        KeyboardKey = kKey;
    }
}