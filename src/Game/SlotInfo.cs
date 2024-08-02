namespace Game;
using Preset;
/// <summary>
/// Represents a slot in the games xml
/// </summary>
public class SlotInfo
{
    /// <summary>
    /// The number of the slot
    /// </summary>
    public string Number { get; set; }
    /// <summary>
    /// The index of the gamepad controller in windows
    /// </summary>
    public string GamepadUserIndex { get; set; }
    /// <summary>
    /// Keyboard used for this gamepad
    /// </summary>
    public string Keyboard { get; set; }
    /// <summary>
    /// Mouse used for this gamepad
    /// </summary>
    public string Mouse { get; set; }
    /// <summary>
    /// Preset used for this gamepad
    /// </summary>
    public PresetInfo Preset { get; set; }

    public SlotInfo(string number, string gamepadUserIndex, string keyboard, string mouse, PresetInfo preset)
    {
        Number = number;
        GamepadUserIndex = gamepadUserIndex;
        Keyboard = keyboard;
        Mouse = mouse;
        Preset = preset;
    }


}