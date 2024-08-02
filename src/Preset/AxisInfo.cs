namespace Preset;

/// <summary>
/// Represents an axis in the xml preset
/// </summary>
public class AxisInfo
{
    /// <summary>
    /// Represents the id of the axis
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Represents the value of the axis
    /// </summary>
    public string Value { get; set; }
    /// <summary>
    /// Represents the keyboard key of the axis
    /// </summary>
    public string KeyboardKey { get; set; }

    public AxisInfo(string id, string value, string kKey)
    {
        Id = id;
        Value = value;
        KeyboardKey = kKey;
    }
}