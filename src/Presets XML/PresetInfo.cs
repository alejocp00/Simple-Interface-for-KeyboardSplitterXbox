namespace Preset;

/// <summary>
/// Represents a preset
/// </summary>
public class PresetInfo
{
    /// <summary>
    /// The name of the preset
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The buttons in the preset
    /// </summary>
    public ButtonInfo[] Buttons { get; set; }
    /// <summary>
    /// The triggers in the preset
    /// </summary> 
    public TriggerInfo[] Triggers { get; set; }
    /// <summary>
    /// The axes in the preset
    /// </summary>
    public AxisInfo[] Axes { get; set; }

    public PresetInfo(string name, ButtonInfo[] buttons, TriggerInfo[] triggers, AxisInfo[] axes)
    {
        Name = name;
        Buttons = buttons;
        Triggers = triggers;
        Axes = axes;
    }
}