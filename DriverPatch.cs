using HarmonyLib;
using Sons.Gameplay;

namespace GolfCartSettings
{
    [HarmonyPatch(typeof(GolfCartController), "OnDriverInteraction")]
    internal static class GolfCartControllerSettingsPatch
    {
        private static void Postfix(ref GolfCartController __instance)
        {
            if (Config.DebugOutput.Value) ReportValues(__instance.Definition);
            SetValues(__instance.Definition);
            if (Config.DebugOutput.Value) ReportValues(__instance.Definition);

        }

        private static void ReportValues(GolfCartControllerDefinition __instance)
        {
            Console.WriteLine($"TorqueCurveMultiplier: {__instance.TorqueCurveMultiplier}");
            Console.WriteLine($"TorqueCurveBoostMultiplier: {__instance.TorqueCurveBoostMultiplier}");
            Console.WriteLine($"WheelProfileBaseSpeed: {__instance.WheelProfileBaseSpeed}");
            Console.WriteLine($"WheelProfileHighSpeed: {__instance.WheelProfileHighSpeed}");
            Console.WriteLine($"MaxBrakeTorque: {__instance.MaxBrakeTorque}");
            Console.WriteLine($"HandBrakeTorque: {__instance.HandBrakeTorque}");
            Console.WriteLine($"AccelerationBrakeTorque: {__instance.AccelerationBrakeTorque}");
            Console.WriteLine($"IdleBrakeTorqueFactor: {__instance.IdleBrakeTorqueFactor}");
            Console.WriteLine($"IdleBrakeSpeed: {__instance.IdleBrakeSpeed}");
            Console.WriteLine($"SteeringWheelRotationMax: {__instance.SteeringWheelRotationMax}");
            Console.WriteLine($"SteeringSmoothTime: {__instance.SteeringSmoothTime}");
            Console.WriteLine($"CenterSteeringSmoothTime: {__instance.CenterSteeringSmoothTime}");
            Console.WriteLine($"SteeringMaxSpeed: {__instance.SteeringMaxSpeed}");
            Console.WriteLine($"SteeringMaxAngle: {__instance.SteeringMaxAngle}");
            Console.WriteLine($"AccelerationSmoothTime: {__instance.AccelerationSmoothTime}");
            Console.WriteLine($"BrakingSmoothTime: {__instance.BrakingSmoothTime}");
            Console.WriteLine($"IdleBrakeDelayTime: {__instance.IdleBrakeDelayTime}");
            Console.WriteLine($"IdleAccelerationSmoothTime: {__instance.IdleAccelerationSmoothTime}");
            Console.WriteLine($"AccelerationMaxSpeed: {__instance.AccelerationMaxSpeed}");
            Console.WriteLine($"GravityForce: {__instance.GravityForce}");
            Console.WriteLine($"BushBreakerMinSpeed: {__instance.BushBreakerMinSpeed}");
            Console.WriteLine($"KnockdownDamageMinSpeed: {__instance.KnockdownDamageMinSpeed}");
            Console.WriteLine($"ShoveCooldownTimer: {__instance.ShoveCooldownTimer}");
            Console.WriteLine($"ShoveForce: {__instance.ShoveForce}");
            Console.WriteLine($"ShoveUpForce: {__instance.ShoveUpForce}");
            Console.WriteLine($"ShoveTorque: {__instance.ShoveTorque}");
            Console.WriteLine($"ShoveAccelerationFactor: {__instance.ShoveAccelerationFactor}");
            Console.WriteLine($"WheelAudioWaterLevel: {__instance.WheelAudioWaterLevel}");
            Console.WriteLine($"DeepWaterLevel: {__instance.DeepWaterLevel}");
            Console.WriteLine($"MaxPower: {__instance.MaxPower}");
            Console.WriteLine($"MinPowerUsage: {__instance.MinPowerUsage}");
            Console.WriteLine($"MaxPowerUsage: {__instance.MaxPowerUsage}");
            Console.WriteLine($"SolarRechargeMultiplier: {__instance.SolarRechargeMultiplier}");
            Console.WriteLine($"SolarRechargeMax: {__instance.SolarRechargeMax}");
            Console.WriteLine($"SolarRechargeMin: {__instance.SolarRechargeMin}");
            Console.WriteLine($"ImpactMinChangeInVelocity: {__instance.ImpactMinChangeInVelocity}");
            Console.WriteLine($"ImpactMaxChangeInVelocity: {__instance.ImpactMaxChangeInVelocity}");
        }

        private static void SetValues(GolfCartControllerDefinition __instance)
        {
            __instance.TorqueCurveMultiplier = Config.TorqueCurveMultiplier.Value;
            __instance.TorqueCurveBoostMultiplier = Config.TorqueCurveBoostMultiplier.Value;
            __instance.WheelProfileBaseSpeed = Config.WheelProfileBaseSpeed.Value;
            __instance.WheelProfileHighSpeed = Config.WheelProfileHighSpeed.Value;
            __instance.MaxBrakeTorque = Config.MaxBrakeTorque.Value;
            __instance.HandBrakeTorque = Config.HandBrakeTorque.Value;
            __instance.AccelerationBrakeTorque = Config.AccelerationBrakeTorque.Value;
            __instance.IdleBrakeTorqueFactor = Config.IdleBrakeTorqueFactor.Value;
            __instance.IdleBrakeSpeed = Config.IdleBrakeSpeed.Value;
            __instance.SteeringWheelRotationMax = Config.SteeringWheelRotationMax.Value;
            __instance.SteeringSmoothTime = Config.SteeringSmoothTime.Value;
            __instance.CenterSteeringSmoothTime = Config.CenterSteeringSmoothTime.Value;
            __instance.SteeringMaxSpeed = Config.SteeringMaxSpeed.Value;
            __instance.SteeringMaxAngle = Config.SteeringMaxAngle.Value;
            __instance.AccelerationSmoothTime = Config.AccelerationSmoothTime.Value;
            __instance.BrakingSmoothTime = Config.BrakingSmoothTime.Value;
            __instance.IdleBrakeDelayTime = Config.IdleBrakeDelayTime.Value;
            __instance.IdleAccelerationSmoothTime = Config.IdleAccelerationSmoothTime.Value;
            __instance.AccelerationMaxSpeed = Config.AccelerationMaxSpeed.Value;
            __instance.GravityForce = Config.GravityForce.Value;
            __instance.BushBreakerMinSpeed = Config.BushBreakerMinSpeed.Value;
            __instance.KnockdownDamageMinSpeed = Config.KnockdownDamageMinSpeed.Value;
            __instance.ShoveCooldownTimer = Config.ShoveCooldownTimer.Value;
            __instance.ShoveForce = Config.ShoveForce.Value;
            __instance.ShoveUpForce = Config.ShoveUpForce.Value;
            __instance.ShoveTorque = Config.ShoveTorque.Value;
            __instance.ShoveAccelerationFactor = Config.ShoveAccelerationFactor.Value;
            __instance.DeepWaterLevel = Config.DeepWaterLevel.Value;
            __instance.MaxPower = Config.MaxPower.Value;
            __instance.MinPowerUsage = Config.MinPowerUsage.Value;
            __instance.MaxPowerUsage = Config.MaxPowerUsage.Value;
            __instance.SolarRechargeMultiplier = Config.SolarRechargeMultiplier.Value;
            __instance.SolarRechargeMax = Config.SolarRechargeMax.Value;
            __instance.SolarRechargeMin = Config.SolarRechargeMin.Value;
            __instance.ImpactMinChangeInVelocity = Config.ImpactMinChangeInVelocity.Value;
            __instance.ImpactMaxChangeInVelocity = Config.ImpactMaxChangeInVelocity.Value;
        }
    }
}
