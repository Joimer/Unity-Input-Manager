using UnityEngine;
using System.Collections.Generic;

public static class GameplayValues {

    public static Dictionary<GameCommand, KeyCode> defaultKeyboardConfig = new Dictionary<GameCommand, KeyCode>() {
        { GameCommand.A_BUTTON, KeyCode.Z },
        { GameCommand.B_BUTTON, KeyCode.X },
        { GameCommand.UP, KeyCode.UpArrow },
        { GameCommand.DOWN, KeyCode.DownArrow },
        { GameCommand.LEFT, KeyCode.LeftArrow },
        { GameCommand.RIGHT, KeyCode.RightArrow },
        { GameCommand.START, KeyCode.Return }
    };
    public static Dictionary<GameCommand, GamepadKey> defaultPadConfig = new Dictionary<GameCommand, GamepadKey>() {
        { GameCommand.A_BUTTON, new GamepadKey(KeyCode.JoystickButton1) },
        { GameCommand.B_BUTTON, new GamepadKey(KeyCode.JoystickButton2) },
        { GameCommand.UP, new GamepadKey(GamepadAxis.VERTICAL, true) },
        { GameCommand.DOWN, new GamepadKey(GamepadAxis.VERTICAL, false) },
        { GameCommand.LEFT, new GamepadKey(GamepadAxis.HORIZONTAL, false) },
        { GameCommand.RIGHT, new GamepadKey(GamepadAxis.HORIZONTAL, true) },
        { GameCommand.START, new GamepadKey(KeyCode.JoystickButton9) }
    };
}
