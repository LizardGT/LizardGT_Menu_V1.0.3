using GorillaTag;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class Cool
    {
        public static void CarMonke()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat >= 0.3f)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 15f;
                if (ControllerInputPoller.instance.rightGrab)
                {
                    GorillaLocomotion.Player.Instance.transform.position -= GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 20f;
                }
            }
        }

        public static void InvisMonke()
        {
            if (ControllerInputPoller.instance.leftControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = -180f;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 0f;
            }
        }



        public static void ForceTagFreeze()
        {
            GorillaLocomotion.Player.Instance.disableMovement = true;
        }

        public static void NoTagFreeze()
        {
            GorillaLocomotion.Player.Instance.disableMovement = false;
        }

        public static void LowGravity()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.up * (Time.deltaTime * (6.66f / Time.deltaTime)), ForceMode.Acceleration);
        }

        public static void ZeroGravity()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.up * (Time.deltaTime * (9.81f / Time.deltaTime)), ForceMode.Acceleration);
        }

        public static void HighGravity()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.down * (Time.deltaTime * (6.66f / Time.deltaTime)), ForceMode.Acceleration);
        }

        public static void ReverseGravity()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.up * (Time.deltaTime * (19.62f / Time.deltaTime)), ForceMode.Acceleration);
        }

        public static void FlipCharacter()
        {
            GorillaLocomotion.Player.Instance.transform.rotation = Quaternion.Euler(180f, 0f, 0f);
        }

        public static void UnflipCharacter()
        {
            GorillaLocomotion.Player.Instance.transform.rotation = Quaternion.identity;
        }

        public static void AntiRPCBan()
        {
            GorillaGameManager.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);
            GorillaGameManager.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);
            GorillaGameManager.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);


            /*NetworkSystem.OnLeftRoom();
            NetworkSystem.OnPreLeavingRoom();
            NetworkSystem.OnLeftLobby();*/


            GorillaGameManager.instance.OnMasterClientSwitched(PhotonNetwork.LocalPlayer);
            ScienceExperimentManager.instance.OnMasterClientSwitched(PhotonNetwork.LocalPlayer);
            GorillaGameManager.instance.OnMasterClientSwitched(PhotonNetwork.LocalPlayer);
            GorillaGameManager.instance.OnMasterClientSwitched(PhotonNetwork.LocalPlayer);

            try
            {
                GorillaNot.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);
                GorillaNot.instance.OnMasterClientSwitched(PhotonNetwork.LocalPlayer);
                GorillaNot.instance.OnLeftRoom();
                GorillaNot.instance.OnPreLeavingRoom();
                if (GorillaNot.instance != null)
                {
                    FieldInfo report = typeof(GorillaNot).GetField("sendReport", BindingFlags.NonPublic);
                    if (report != null)
                    {
                        report.SetValue(GorillaNot.instance, false);
                    }
                    report = typeof(GorillaNot).GetField("_sendReport", BindingFlags.NonPublic);
                    if (report != null)
                    {
                        report.SetValue(GorillaNot.instance, false);
                    }
                }
            }
            catch { }
            
            GorillaNot.instance.OnLeftRoom();
        }

        public static void NightTime()
        {
            BetterDayNightManager.instance.SetTimeOfDay(0);
        }

        public static void DayTime()
        {
            BetterDayNightManager.instance.SetTimeOfDay(1);
        }

        public static void FixHead()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.x = 0f;
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 0f;
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 0f;
        }

        public static void UpsideDownHead()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 180f;
        }

        public static void BackwardsHead()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 180f;
        }

        public static void SpinHeadX()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.x += 10f;
        }

        public static void SpinHeadY()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y += 10f;
        }

        public static void SpinHeadZ()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z += 10f;
        }

        public static void FixHandTaps()
        {
            GorillaTagger.Instance.handTapVolume = 0.1f;
        }

        public static void LoudHandTaps()
        {
            GorillaTagger.Instance.handTapVolume = int.MaxValue;
        }

        public static void SilentHandTaps()
        {
            GorillaTagger.Instance.handTapVolume = 0;
        }

        public static void EnableInstantHandTaps()
        {
            GorillaTagger.Instance.tapCoolDown = 0f;
        }

        public static void DisableInstantHandTaps()
        {
            GorillaTagger.Instance.tapCoolDown = 0.33f;
        }
    }
}
