# First Person

Enjoy a smooth first-person view that follows where you look.

## Video demo

[Watch First Person in action on YouTube](https://youtu.be/B66x3Gc5Vbw).

## Highlights

- Toggle between first and third person camera with the default F6 key.
- F6 can be changed to another key or mouse button in the BepInEx config file.
- Automatically switch to third person during combat or manual camera zoom.
- Customize your field of view (FOV) in-game from 65 to 120.
- Add a separate first-person FOV bonus, set to 15 by default.
- Apply configuration changes without restarting the game.
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

The file `Landoria.FirstPerson.cfg` is created automatically in the config folder of the current BepInEx profile. Changes to this file are applied without restarting the game.

| Setting | Default | Description |
|---|---|---|
| `ToggleShortcut` | `F6` | First-person toggle shortcut. May be changed to `Mouse2` or `Mouse3` for example |
| `AutomaticReturnDelay` | `3` | Return delay in seconds after combat or manual camera zoom; `0` disables temporary third person |
| `SmoothAutomaticTransitions` | `false` | Use smooth automatic transitions instead of instant camera changes |
| `HeadBobStrength` | `2` | First-person head bob strength; `0` disables it |
| `FirstPersonEnabled` | `false` | Saved first-person state. Normally changed using F6. |
| `FieldOfView` | `65` | Saved camera FOV. Normally changed using the `fov` command in-game |
| `FirstPersonFieldOfViewBonus` | `15` | Additional FOV applied only in first person; accepts values from 0 to 50 |

## Contact

Report bugs through [GitHub Issues](https://github.com/landoria-gaming/Landoria.FirstPerson/issues).
