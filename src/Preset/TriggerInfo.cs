namespace Preset;

/// <summary>
/// Represents a trigger in the xml preset
/// </summary>
public class TriggerInfo
{
    /// <summary>
    /// Represents the id of the button in the xml preset
    /// </summary>
    public GamePadActuator Id { get; set; }
    /// <summary>
    /// Represents the keyboard key of the trigger
    /// </summary>
    public string KeyboardKey { get; set; }

    public TriggerInfo(GamePadActuator id, string kKey)
    {
        Id = id;
        KeyboardKey = kKey;
    }
}