using RedLoader;
using SUI;

namespace GolfPlane;

public static class Config
{
    public static ConfigCategory Category { get; private set; }

    public static ConfigEntry<bool> DebugOutput { get; private set; }

    private static SettingsRegistry.SettingsEntry _settingsEntry;

    public static void Init()
    {
        Category = ConfigSystem.CreateFileCategory("GolfPlane", "GolfPlane", "GolfPlane.cfg");
        DebugOutput = Category.CreateEntry("DebugOutput", false, "Debug Output", "Logs debug output to console");
    }

    public static void OnSettingsUiClosed()
    {
    }
}