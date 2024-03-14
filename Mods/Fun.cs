using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class Fun
    {
        public static void JoinDiscord()
        {
            Process.Start("https://discord.gg/UFGrRs4JVC");
        }

        public static void EnableAntiAFK()
        {
            PhotonNetworkController.Instance.disableAFKKick = false;
        }

        public static void DisableAntiAFK()
        {
            PhotonNetworkController.Instance.disableAFKKick = true;
        }

        public static void DisableNetworkTriggers()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab").SetActive(false);
        }

        public static void EnableNetworkTriggers()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab").SetActive(true);
        }

        public static void DisableQuitBox()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/ZoneTransitions_Prefab/QuitBox").SetActive(false);
        }

        public static void EnableQuitBox()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/ZoneTransitions_Prefab/QuitBox").SetActive(true);
        }

        public static void EnableFPSBoost()
        {
            QualitySettings.globalTextureMipmapLimit = 99999;
        }

        public static void DisableFPSBoost()
        {
            QualitySettings.globalTextureMipmapLimit = 1;
        }

        public static void ForceLagGame()
        {
            foreach (GameObject g in GameObject.FindObjectsByType<GameObject>(0)) { }
        }

        public static void UncapFPS()
        {
            Application.targetFrameRate = 9999;
        }

    }
}
