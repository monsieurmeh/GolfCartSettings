using RedLoader;
using SUI;

namespace GolfCartSettings;

public static class Config
{
    public static ConfigCategory Category { get; private set; }

    public static ConfigEntry<bool> DebugOutput { get; private set; }
    public static ConfigEntry<float> TorqueCurveMultiplier { get; private set; }
    public static ConfigEntry<float> TorqueCurveBoostMultiplier { get; private set; }
    public static ConfigEntry<float> MaxBrakeTorque { get; private set; }
    public static ConfigEntry<float> HandBrakeTorque { get; private set; }
    public static ConfigEntry<float> AccelerationBrakeTorque { get; private set; }
    public static ConfigEntry<float> IdleBrakeTorqueFactor { get; private set; }
    public static ConfigEntry<float> IdleBrakeSpeed { get; private set; }
    public static ConfigEntry<float> SteeringWheelRotationMax { get; private set; }
    public static ConfigEntry<float> SteeringSmoothTime { get; private set; }
    public static ConfigEntry<float> CenterSteeringSmoothTime { get; private set; }
    public static ConfigEntry<float> SteeringMaxSpeed { get; private set; }
    public static ConfigEntry<float> SteeringMaxAngle { get; private set; }
    public static ConfigEntry<float> AccelerationSmoothTime { get; private set; }
    public static ConfigEntry<float> BrakingSmoothTime { get; private set; }
    public static ConfigEntry<float> IdleBrakeDelayTime { get; private set; }
    public static ConfigEntry<float> IdleAccelerationSmoothTime { get; private set; }
    public static ConfigEntry<float> AccelerationMaxSpeed { get; private set; }
    public static ConfigEntry<float> GravityForce { get; private set; }
    public static ConfigEntry<float> WheelProfileBaseSpeed { get; private set; }
    public static ConfigEntry<float> WheelProfileHighSpeed { get; private set; }
    public static ConfigEntry<float> BushBreakerMinSpeed { get; private set; }
    public static ConfigEntry<float> KnockdownDamageMinSpeed { get; private set; }
    public static ConfigEntry<float> ShoveCooldownTimer { get; private set; }
    public static ConfigEntry<float> ShoveForce { get; private set; }
    public static ConfigEntry<float> ShoveUpForce { get; private set; }
    public static ConfigEntry<float> ShoveTorque { get; private set; }
    public static ConfigEntry<float> ShoveAccelerationFactor { get; private set; }
    public static ConfigEntry<float> AudioAccelerationMin { get; private set; }
    public static ConfigEntry<float> AudioAccelerationMax { get; private set; }
    public static ConfigEntry<float> AudioBrakingMin { get; private set; }
    public static ConfigEntry<float> AudioBrakingMax { get; private set; }
    public static ConfigEntry<float> AudioSpeedMin { get; private set; }
    public static ConfigEntry<float> AudioSpeedMax { get; private set; }
    public static ConfigEntry<float> AudioBeepMinTime { get; private set; }
    public static ConfigEntry<float> EngineLoadRpmThreshold { get; private set; }
    public static ConfigEntry<float> WheelAudioWaterLevel { get; private set; }
    public static ConfigEntry<float> AudioTractionSmoothDownFactor { get; private set; }
    public static ConfigEntry<float> AudioTractionSmoothUpFactor { get; private set; }
    public static ConfigEntry<float> DeepWaterLevel { get; private set; }
    public static ConfigEntry<float> DeepWaterThresholdIncreaseRate { get; private set; }
    public static ConfigEntry<float> MaxPower { get; private set; }
    public static ConfigEntry<float> MinPowerUsage { get; private set; }
    public static ConfigEntry<float> MaxPowerUsage { get; private set; }
    public static ConfigEntry<float> SolarRechargeMultiplier { get; private set; }
    public static ConfigEntry<float> SolarRechargeMax { get; private set; }
    public static ConfigEntry<float> SolarRechargeMin { get; private set; }
    public static ConfigEntry<float> ImpactMinChangeInVelocity { get; private set; }
    public static ConfigEntry<float> ImpactMaxChangeInVelocity { get; private set; }

    private static SettingsRegistry.SettingsEntry _settingsEntry;

    public static void Init()
    {
        Category = ConfigSystem.CreateFileCategory("GolfCartSettings", "Golf Cart Settings", "GolfCartSettings.cfg");
        InstantiateConfigs();
        SetConfigRanges();
    }

    private static void InstantiateConfigs()
    {
        DebugOutput = Category.CreateEntry("DebugOutput", false, "Debug Output", "Logs debug output to console");
        TorqueCurveMultiplier = Category.CreateEntry("TorqueCurveMultiplier", 1000f, "Torque Curve Multiplier", "Scales base torque curve.");
        TorqueCurveBoostMultiplier = Category.CreateEntry("TorqueCurveBoostMultiplier", 1.8f, "Torque Boost Multiplier", "Additional torque boost multiplier.");
        MaxBrakeTorque = Category.CreateEntry("MaxBrakeTorque", 800f, "Maximum Brake Torque", "Maximum braking torque.");
        HandBrakeTorque = Category.CreateEntry("HandBrakeTorque", 1200f, "Handbrake Torque", "Torque applied by the handbrake.");
        AccelerationBrakeTorque = Category.CreateEntry("AccelerationBrakeTorque", 200f, "Acceleration Brake Torque", "Torque used for speed control during acceleration.");
        IdleBrakeTorqueFactor = Category.CreateEntry("IdleBrakeTorqueFactor", 0.2f, "Idle Brake Torque Factor", "Scale factor applied when idling.");
        IdleBrakeSpeed = Category.CreateEntry("IdleBrakeSpeed", 0.1f, "Idle Brake Speed", "Speed threshold for idle braking.");
        SteeringWheelRotationMax = Category.CreateEntry("SteeringWheelRotationMax", 50f, "Steering Wheel Max Rotation", "Maximum rotation angle of steering wheel.");
        SteeringSmoothTime = Category.CreateEntry("SteeringSmoothTime", 0.4f, "Steering Smooth Time", "Smoothing time for steering inputs.");
        CenterSteeringSmoothTime = Category.CreateEntry("CenterSteeringSmoothTime", 0.1f, "Center Steering Smooth Time", "Rate of recentering smoothing.");
        SteeringMaxSpeed = Category.CreateEntry("SteeringMaxSpeed", 10f, "Steering Max Speed", "Max steering rotation speed.");
        SteeringMaxAngle = Category.CreateEntry("SteeringMaxAngle", 40f, "Steering Max Angle", "Steering wheel maximum turning angle.");
        AccelerationSmoothTime = Category.CreateEntry("AccelerationSmoothTime", 1f, "Acceleration Smooth Time", "Smoothing time for acceleration input.");
        BrakingSmoothTime = Category.CreateEntry("BrakingSmoothTime", 0.1f, "Braking Smooth Time", "Smoothing time for braking input.");
        IdleBrakeDelayTime = Category.CreateEntry("IdleBrakeDelayTime", 1f, "Idle Brake Delay", "Delay before idle braking activates.");
        IdleAccelerationSmoothTime = Category.CreateEntry("IdleAccelerationSmoothTime", 0.6f, "Idle Accel Smooth Time", "Smoothing time for acceleration while idling.");
        AccelerationMaxSpeed = Category.CreateEntry("AccelerationMaxSpeed", 20f, "Acceleration Max Speed", "Max achievable acceleration speed.");
        GravityForce = Category.CreateEntry("GravityForce", 8f, "Gravity Force", "Additional gravity force multiplier.");
        WheelProfileBaseSpeed = Category.CreateEntry("WheelProfileBaseSpeed", 5f, "Wheel Base Speed", "Base wheel rotation speed.");
        WheelProfileHighSpeed = Category.CreateEntry("WheelProfileHighSpeed", 10f, "Wheel High Speed", "High-speed wheel rotation target.");
        BushBreakerMinSpeed = Category.CreateEntry("BushBreakerMinSpeed", 3f, "Bush Breaker Min Speed", "Minimum speed required to break bushes.");
        KnockdownDamageMinSpeed = Category.CreateEntry("KnockdownDamageMinSpeed", 7.25f, "Knockdown Min Speed", "Minimum speed to knock down obstacles.");
        ShoveCooldownTimer = Category.CreateEntry("ShoveCooldownTimer", 0.5f, "Shove Cooldown", "Time between shove actions.");
        ShoveForce = Category.CreateEntry("ShoveForce", 3f, "Shove Force", "Forward shove force.");
        ShoveUpForce = Category.CreateEntry("ShoveUpForce", 5f, "Shove Up Force", "Vertical shove force.");
        ShoveTorque = Category.CreateEntry("ShoveTorque", 0.05f, "Shove Torque", "Torque applied when shoving.");
        ShoveAccelerationFactor = Category.CreateEntry("ShoveAccelerationFactor", 0.1f, "Shove Acceleration Factor", "Multiplier on acceleration when shoving.");
        AudioAccelerationMin = Category.CreateEntry("AudioAccelerationMin", -330f, "Audio Accel Min", "Minimum audio pitch on acceleration.");
        AudioAccelerationMax = Category.CreateEntry("AudioAccelerationMax", 330f, "Audio Accel Max", "Maximum audio pitch on acceleration.");
        AudioBrakingMin = Category.CreateEntry("AudioBrakingMin", 0f, "Audio Brake Min", "Minimum audio pitch on braking.");
        AudioBrakingMax = Category.CreateEntry("AudioBrakingMax", 1f, "Audio Brake Max", "Maximum audio pitch on braking.");
        AudioSpeedMin = Category.CreateEntry("AudioSpeedMin", -330f, "Audio Speed Min", "Minimum audio pitch based on speed.");
        AudioSpeedMax = Category.CreateEntry("AudioSpeedMax", 330f, "Audio Speed Max", "Maximum audio pitch based on speed.");
        AudioBeepMinTime = Category.CreateEntry("AudioBeepMinTime", 2f, "Audio Beep Min Time", "Minimum interval between beeps.");
        EngineLoadRpmThreshold = Category.CreateEntry("EngineLoadRpmThreshold", 800f, "Engine Load RPM Threshold", "Engine load RPM threshold for audio/logic.");
        WheelAudioWaterLevel = Category.CreateEntry("WheelAudioWaterLevel", 0.001f, "Wheel Audio Water Level", "Water level at which special wheel audio plays.");
        AudioTractionSmoothDownFactor = Category.CreateEntry("AudioTractionSmoothDownFactor", 3f, "Audio Traction Down", "Smoothing downward traction audio.");
        AudioTractionSmoothUpFactor = Category.CreateEntry("AudioTractionSmoothUpFactor", 3f, "Audio Traction Up", "Smoothing upward traction audio.");
        DeepWaterLevel = Category.CreateEntry("DeepWaterLevel", 1f, "Deep Water Level", "Depth considered as deep water.");
        DeepWaterThresholdIncreaseRate = Category.CreateEntry("DeepWaterThresholdIncreaseRate", 0.5f, "Deep Water Threshold Rate", "Rate at which deep-water effects increase.");
        MaxPower = Category.CreateEntry("MaxPower", 1000f, "Max Power", "Maximum available power.");
        MinPowerUsage = Category.CreateEntry("MinPowerUsage", 0f, "Min Power Use", "Minimum passive power usage.");
        MaxPowerUsage = Category.CreateEntry("MaxPowerUsage", 4f, "Max Power Use", "Maximum power draw.");
        SolarRechargeMultiplier = Category.CreateEntry("SolarRechargeMultiplier", 0.1f, "Solar Recharge Multiplier", "Scales solar charging speed.");
        SolarRechargeMax = Category.CreateEntry("SolarRechargeMax", 1f, "Solar Recharge Max", "Upper solar recharge limit.");
        SolarRechargeMin = Category.CreateEntry("SolarRechargeMin", 0.5f, "Solar Recharge Min", "Minimum solar recharge amount.");
        ImpactMinChangeInVelocity = Category.CreateEntry("ImpactMinChangeInVelocity", 0.5f, "Impact Min ΔV", "Minimum velocity change for impacts.");
        ImpactMaxChangeInVelocity = Category.CreateEntry("ImpactMaxChangeInVelocity", 10f, "Impact Max ΔV", "Maximum velocity change for impacts.");

    }

    private static void SetConfigRanges()
    {
    }

    public static void OnSettingsUiClosed()
    {
    }
}
