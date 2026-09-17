# First Person

Enjoy a smooth first-person view that follows where you look.

## Video demo

[Watch First Person in action on YouTube](https://youtu.be/eExAEyoNsSs).

## Highlights

- Toggle between first and third person camera with the default F6 key.
- F6 can be changed to another key or mouse button in the BepInEx config file.
- Instantly switch between first and third person during combat.
- Customize your field of view (FOV) in-game from 65 to 120.
- Client-side mod; no server installation needed.

## Controls

| Control | Action |
|---|---|
| `F6` | Enable or disable first-person view |

## Commands

| Command | Action |
|---|---|
| `fov <degrees>` | Set the saved FOV, up to 120 (default 65) |
| `fov` | Show the current FOV |
| `fov reset` | Restore the default FOV of 65 |

## BepInEx Configuration

The file `Landoria.FirstPerson.cfg` is created automatically in the config folder of the bepinex current profile containing the following settings:

| Setting | Default | Description |
|---|---|---|
| `ToggleShortcut` | `F6` | First-person toggle shortcut. May be changed to `Mouse2` or `Mouse3` for example |
| `CombatReturnDelay` | `1` | Return to first person delay in seconds after combat ends; `0` disables temporary third person for combat |
| `ZoomReturnDelay` | `3` | Return to first person delay in seconds after camera zoom; `0` disables temporary third person for zoom |
| `HeadBobStrength` | `2` | First-person head bob strength; `0` disables it |
| `FirstPersonEnabled` | `false` | Saved first-person state. Normally changed using F6. |
| `FieldOfView` | `65` | Saved camera FOV. Normally changed using /fov command in-game. |

## Valheim compatibility

Current release: 1.0.x

## Snapshot builds

The **Snapshot build** GitHub Actions workflow builds `main`, pull requests, and manual runs.
The snapshot pipeline uses the reusable workflow in
[LandoriaModActions](https://github.com/landoria-gaming/LandoriaModActions), version `v2`.
FirstPerson keeps its local MSBuild packaging target. All opted-in Landoria mods
download the same Valheim/Unity and BepInEx/Harmony reference bundle from the private
`landoria-gaming/LandoriaModReferences` repository, using organization secret
`MOD_REFERENCES_TOKEN` (Actions read access to that private repository).
Only that central repository checks Steam daily and replaces obsolete reference bundles.
There is no mod-local dependency cache or update schedule. Fork PR builds are skipped
because they cannot access the private-reference secret.
It skips the build unless `AssemblyInformationalVersion` in `Properties/AssemblyInfo.cs`
and `version_number` in `manifest.json` are identical and end with `-snapshot`.
Download `Landoria.FirstPerson-snapshot-...` from the workflow run's artifacts for a
Release build with the package files and build metadata (retained for 30 days).
The separate `Landoria.FirstPerson-thunderstore-...` artifact contains
`Landoria-FirstPerson-<version>.zip`, packaged like LandoriaModsAutomation with
the DLL, icon, manifest, README, and optional changelog at the ZIP root.
Successful builds on `main` also replace the single [Snapshot prerelease](https://github.com/landoria-gaming/Landoria.FirstPerson/releases/tag/snapshot).
Pull requests and manual runs on other branches never publish a release.
The `snapshot` tag follows the compiled commit; older commits cannot replace the latest main snapshot.
Stable downloads: [Thunderstore ZIP](https://github.com/landoria-gaming/Landoria.FirstPerson/releases/download/snapshot/Landoria-FirstPerson-snapshot.zip)
and [snapshot with metadata](https://github.com/landoria-gaming/Landoria.FirstPerson/releases/download/snapshot/Landoria.FirstPerson-snapshot.zip).

Snapshots are development builds, not stable releases; the Thunderstore package manifest
version preserve the source version (for example `1.0.11-snapshot`); no suffix is added automatically.
Compilation downloads the latest successful shared reference bundle and validates
its SHA256 hashes. Snapshot builds never download the server or BepInExPack directly.
Reference DLLs are used only for compilation, never included in the mod ZIP.
The private central workflow republishes unchanged references daily to renew their
30-day artifact retention, and deletes previous bundles only after a successful replacement.
Build metadata records the selected reference versions and central workflow run.

To build the same Thunderstore ZIP locally (with `BepInExPath` and `ValheimGamePath` configured):

```powershell
dotnet build Landoria.FirstPerson.csproj -c Release -t:PackageThunderstore
```

The ZIP is written to `bin/thunderstore`; override it with `-p:ThunderstoreOutputPath=<directory>`.
Add `-p:SnapshotBuild=true` to enforce the same snapshot eligibility check locally.
If the versions do not match or lack `-snapshot`, compilation and packaging are skipped successfully.

## Contact

Report bugs through [GitHub Issues](https://github.com/landoria-gaming/Landoria.FirstPerson/issues).
