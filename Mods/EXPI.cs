using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class EXPI
    {
        public static void resetturnspeed()
        {
            foreach (GorillaSnapTurn gorillaSnapTurn in (GorillaSnapTurn[])UnityEngine.Object.FindObjectsOfType(typeof(GorillaSnapTurn)))
            {
                gorillaSnapTurn.turnSpeed = 5f;
                gorillaSnapTurn.ChangeTurnMode("SMOOTH", 5);
            }



        }
        public static void FastTurnSpeed()
        {
            foreach (GorillaSnapTurn gorillaSnapTurn in (GorillaSnapTurn[])UnityEngine.Object.FindObjectsOfType(typeof(GorillaSnapTurn)))
            {
                gorillaSnapTurn.turnSpeed = 9999999f;
                gorillaSnapTurn.ChangeTurnMode("SMOOTH", 999999999);
            }
        }

        public static void Tracersmod()
        {
            if (PhotonNetwork.CurrentRoom == null) return;

            foreach (VRRig rig in GorillaParent.instance.vrrigs)
            {
                if (!rig.isOfflineVRRig)
                {
                    GameObject lines = new GameObject("Line");
                    LineRenderer lr = lines.AddComponent<LineRenderer>();

                    lr.startColor = lr.endColor = Color.green;
                    lr.startWidth = lr.endWidth = 0.01f;
                    lr.positionCount = 2;
                    lr.SetPositions(new Vector3[] { GorillaLocomotion.Player.Instance.rightControllerTransform.position, rig.transform.position });
                    lr.material.shader = Shader.Find("GUI/Text Shader");

                    GameObject.Destroy(lines, Time.deltaTime);
                }
            }
        }
    }
}
