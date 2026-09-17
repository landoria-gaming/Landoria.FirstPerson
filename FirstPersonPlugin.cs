using BepInEx;
using HarmonyLib;

namespace Landoria.FirstPerson
{
    // Starts and stops the First Person mod.
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public sealed class FirstPersonPlugin : BaseUnityPlugin
    {
        private const string PluginGuid = "Landoria.FirstPerson";
        private const string PluginName = "Landoria.FirstPerson";
        private const string PluginVersion = "1.0.10";

        private Harmony _harmony;

        private void Awake()
        {
            Logger.LogInfo($"AssemblyVersion: {GetType().Assembly.GetName().Version}.");
            _harmony = new Harmony(PluginGuid);
            RegisterPatches();
            FirstPersonPreference.Initialize(Config);
            Logger.LogInfo($"{PluginName} {PluginVersion} is loaded.");
        }

        private void RegisterPatches()
        {
            _harmony.CreateClassProcessor(typeof(FirstPersonCameraAwakePatch)).Patch();
            _harmony.CreateClassProcessor(typeof(FirstPersonCameraUpdatePatch)).Patch();
            _harmony.CreateClassProcessor(typeof(FirstPersonTemporaryDistancePatch)).Patch();
            _harmony.CreateClassProcessor(typeof(FirstPersonCameraOffsetPatch)).Patch();
            _harmony.CreateClassProcessor(typeof(FirstPersonPlayerRotationPatch)).Patch();
            _harmony.CreateClassProcessor(typeof(FirstPersonLoadedObjectPatch)).Patch();
            _harmony.CreateClassProcessor(typeof(FirstPersonPlayerVisibilityPatch)).Patch();
            _harmony.CreateClassProcessor(typeof(FirstPersonVisualVisibilityPatch)).Patch();
            _harmony.CreateClassProcessor(typeof(FirstPersonHelmetLightLateUpdatePatch)).Patch();
            _harmony.CreateClassProcessor(typeof(FirstPersonFieldOfViewCommandPatch)).Patch();
            _harmony.CreateClassProcessor(typeof(FirstPersonPlayerSpawnPatch)).Patch();
            _harmony.CreateClassProcessor(typeof(FirstPersonDisconnectPatch)).Patch();
        }

        private void OnDestroy()
        {
            FirstPersonMode.Reset();
            _harmony?.UnpatchSelf();
            _harmony = null;
            Logger.LogInfo($"{PluginName} {PluginVersion} is unloaded.");
        }
    }
}
