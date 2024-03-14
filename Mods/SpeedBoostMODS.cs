using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class SpeedBoostMODS
    {
        public static void D_SpeedboostMOD() //-BOX
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 13f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 13f;//-things inside the box
        }

        public static void longarms()
        {
            GorillaLocomotion.Player.Instance.maxArmLength = 0;
        }

        public static void UN_Speedboost()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 9f;
        }

        public static void W_D_SpeedboostMOD()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 10f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 15f;
        }

        public static Object rightGrab = ControllerInputPoller.instance.rightGrab;
        public static Object leftGrab = ControllerInputPoller.instance.leftGrab;
        public static Object rightPrimary = ControllerInputPoller.instance.rightControllerPrimaryButton;
        public static Object leftPrimary = ControllerInputPoller.instance.leftControllerPrimaryButton;


        public static void GripSpeedBoost()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
                GorillaLocomotion.Player.Instance.jumpMultiplier = 9f;
            }
        }
    }
}
