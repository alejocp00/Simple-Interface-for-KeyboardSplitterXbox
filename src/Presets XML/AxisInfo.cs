namespace Preset;

/// <summary>
/// Represents an axis in the xml preset
/// </summary>
public class AxisInfo
{
    /// <summary>
    /// Represents the id of the axis
    /// </summary>
    public GamePadActuator Id { get; set; }

    /// <summary>
    /// Represents the value of the axis
    /// </summary>
    public AxisInfo Value { get; set; }
    /// <summary>
    /// Represents the keyboard key of the axis
    /// </summary>
    public string KeyboardKey { get; set; }

    public AxisInfo(GamePadActuator id, AxisInfo value, string kKey)
    {
        Id = id;
        Value = value;
        KeyboardKey = kKey;
    }
}