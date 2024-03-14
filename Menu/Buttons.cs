using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Disconect", method =() => Disconnect.DisconnectFromLobby(), toolTip = "Disconects you from the lobby"},
                new ButtonInfo { buttonText = "Speedboost [D]", method =() => SpeedBoostMODS.D_SpeedboostMOD(), toolTip = "Gives you a detected Speedboost"},
                new ButtonInfo { buttonText = "Lower speedboost [UN]", method =() => SpeedBoostMODS.UN_Speedboost(), toolTip = "Gives you a undetected Speedboost"},
                new ButtonInfo { buttonText = "Wierd Speedbost [KD]", method =() => SpeedBoostMODS.W_D_SpeedboostMOD(), toolTip = "Gives you a wierd speedboost"},
                new ButtonInfo { buttonText = "Reset Turn Speed [UN]", method =() => EXPI.resetturnspeed(), toolTip = "resets your snap/smooth turn"},
                new ButtonInfo { buttonText = "Fast Turn Speed [UN]", method =() => EXPI.FastTurnSpeed(), toolTip = "Gives you a fast turn speed"},
                new ButtonInfo { buttonText = "Quit GTAG [UN]", method =() => Disconnect.QUITGTAG(), toolTip = "Quit Gorilla tag"},
                new ButtonInfo { buttonText = "Car Monkey [BG]", method =() => Cool.CarMonke(), toolTip = "Car!"},
                new ButtonInfo { buttonText = "Invis Monkey [RSB]", method =() => Cool.InvisMonke(), toolTip = "Go invisible!"},
                new ButtonInfo { buttonText = "Fly [G]", method =() => Movement.Fly(), toolTip = "Fly!"},
                new ButtonInfo { buttonText = "Left Hand Fly [LSB]", method =() => Movement.LeftFly(), toolTip = "Fly With your left hand!"},
                new ButtonInfo { buttonText = "Trigger Fly [RT]", method =() => Movement.TriggerFly(), toolTip = "Fly With your Right Trigger hand!"},
                new ButtonInfo { buttonText = "Tp Gun [RT]", method =() => Movement.TpGun(), toolTip = "Teleport Gun"},
                new ButtonInfo { buttonText = "Platforms [G]", method =() => Movement.Platforms(), toolTip = "Platforms"},
                new ButtonInfo { buttonText = "Ghost Monkey [RSB?]", method =() => Movement.GhostMonke(), toolTip = "Be a ghost"},
                new ButtonInfo { buttonText = "No Clip [G?]", method =() => Movement.NoClip(), toolTip = "go trugh objects"},
                new ButtonInfo { buttonText = "Tracers [UN]", method =() => EXPI.Tracersmod(), toolTip = "know where every ones at"},
                new ButtonInfo { buttonText = "Force Tag Freeze[UN]", method =() => Cool.ForceTagFreeze(), toolTip = "Tag freeze"},
                new ButtonInfo { buttonText = "No tag Freeze[UN]", method =() => Cool.NoTagFreeze(), toolTip = "No tag freeze"},
                new ButtonInfo { buttonText = "Reverse Gravity[D]", method =() => Cool.ReverseGravity(), toolTip = "reverse gravity"},
                new ButtonInfo { buttonText = "Low Gravity", method =() => Cool.LowGravity(), toolTip = "Low gravity"},
                new ButtonInfo { buttonText = "Zero Gravity", method =() => Cool.ZeroGravity(), toolTip = "Zero gravity"},
                new ButtonInfo { buttonText = "Flip Character", method =() => Cool.FlipCharacter(), toolTip = "Flips your monke"},
                new ButtonInfo { buttonText = "High Gravity", method =() => Cool.HighGravity(), toolTip = "High Gravity"},
                new ButtonInfo { buttonText = "UnFlip Character", method =() => Cool.UnflipCharacter(), toolTip = "Unflips your monkey"},
                new ButtonInfo { buttonText = "Bug Gun [T]", method =() => HEHEHE.BugGun(), toolTip = "Spawns a Bug"},
                new ButtonInfo { buttonText = "Join Random Pub[UN]", method =() => Disconnect.JoinRandomPublic(), toolTip = "Joins a random public"},
                new ButtonInfo { buttonText = "Join a UE server", method =() => Disconnect.EUServers(), toolTip = "Join a EU server"},
                new ButtonInfo { buttonText = "Join a US server", method =() => Disconnect.USServers(), toolTip = "Join a US server"},
                new ButtonInfo { buttonText = "Join a US WEST SERVER", method =() => Disconnect.USWServers(), toolTip = "Join a US West server"},
                new ButtonInfo { buttonText = "Long arms", method =() => SpeedBoostMODS.longarms(), toolTip = "Gives you long arms"},
                new ButtonInfo { buttonText = "AntiRPCBan", method =() => Cool.AntiRPCBan(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Backwards Head", method =() => Cool.BackwardsHead(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Day Time", method =() => Cool.DayTime(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Night Time", method =() => Cool.NightTime(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Upside down head", method =() => Cool.UpsideDownHead(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Disable Insta Hand Taps", method =() => Cool.DisableInstantHandTaps(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Loud Hand taps", method =() => Cool.LoudHandTaps(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Silent hand taps", method =() => Cool.SilentHandTaps(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Spin Head [X]", method =() => Cool.SpinHeadX(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Spin Head [Y]", method =() => Cool.SpinHeadY(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Spin Head [Z]", method =() => Cool.SpinHeadZ(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Enable Instant Hand Taps", method =() => Cool.EnableInstantHandTaps(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Fix Hand Taps", method =() => Cool.FixHandTaps(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Fix Head", method =() => Cool.FixHead(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Join Random Pub", method =() => Disconnect.JoinRandomPublic(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Join Bot", method =() => Disconnect.AutoJoinRoomBOT(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Join DAISY", method =() => Disconnect.AutoJoinRoomDAISY(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Join Daisy09", method =() => Disconnect.AutoJoinRoomDAISY09(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Join PBBV", method =() => Disconnect.AutoJoinRoomPBBV(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Join RUN", method =() => Disconnect.AutoJoinRoomRUN(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Restart GTAG", method =() => Disconnect.RestartGame(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Force Lag Game", method =() => Fun.ForceLagGame(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Uncap FPS", method =() => Fun.UncapFPS(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Enable QUIT BOX", method =() => Fun.EnableQuitBox(), toolTip = "Description"},
                new ButtonInfo { buttonText = "EnableFPSBoost", method =() => Fun.EnableFPSBoost(), toolTip = "Description"},
                new ButtonInfo { buttonText = "EnablesAntiAFK", method =() => Fun.EnableAntiAFK(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Enables Network Triggers", method =() => Fun.EnableNetworkTriggers(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Disables QuitBox", method =() => Fun.DisableQuitBox(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Disables AntiAFK", method =() => Fun.DisableAntiAFK(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Disable FPS boost", method =() => Fun.DisableFPSBoost(), toolTip = "Description"},
                new ButtonInfo { buttonText = "JOIN THE DISCORD", method =() => Fun.JoinDiscord(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Uncap fps", method =() => Fun.UncapFPS(), toolTip = "Description"},
                new ButtonInfo { buttonText = "Speedboost [RG]", method =() => SpeedBoostMODS.GripSpeedBoost(), toolTip = "Gives you a detected Speedboost"},
                new ButtonInfo { buttonText = "Freeze Player", method =() => TEST.FreezeRigBody(), toolTip = "Freezes you ridgid body"},

            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
