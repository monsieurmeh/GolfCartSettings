using SonsSdk;
using SUI;

namespace GolfPlane;

public class GolfCartSettings : SonsMod
{
    public GolfCartSettings()
    {
        HarmonyPatchAll = true;
    }

    protected override void OnInitializeMod()
    {
        Config.Init();
    }

    protected override void OnSdkInitialized()
    {
        SettingsRegistry.CreateSettings(this, null, typeof(Config));
    }

    protected override void OnGameStart()
    {
    }
}