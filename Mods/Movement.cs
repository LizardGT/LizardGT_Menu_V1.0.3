using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class Movement
    {
        private static GameObject Rplat = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        private static GameObject Lplat = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        private static bool IsNotHoldingR;
        private static bool IsSpawnedR;
        private static bool IsNotHoldingL;
        private static bool IsSpawnedL;
        public static void Platforms()
        {

            if (ControllerInputPoller.instance.rightGrab)
            {
                if (!IsNotHoldingR && !IsSpawnedR)
                {
                    Rplat.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.transform.position;
                    IsSpawnedR = true;
                }
                IsNotHoldingR = false;
                Rplat.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                Rplat.AddComponent<BoxCollider>();
            }
            else if (!ControllerInputPoller.instance.rightGrab)
            {
                Rplat.transform.position = new Vector3(0, 100, 0);
                IsNotHoldingR = true;
                IsSpawnedR = false;
            }

            if (ControllerInputPoller.instance.leftGrab)
            {
                if (!IsNotHoldingL && !IsSpawnedL)
                {
                    Lplat.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position;
                    IsSpawnedL = true;
                }
                IsNotHoldingL = false;
                Lplat.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                Lplat.AddComponent<BoxCollider>();
                Lplat.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.transform.position;
            }
            else if (!ControllerInputPoller.instance.leftGrab)
            {
                Lplat.transform.position = new Vector3(0, 100, 0);
                IsNotHoldingL = true;
                IsSpawnedL = false;
            }
        }

        public static void NoClip()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f)
            {
                {
                    MeshCollider[] array = Resources.FindObjectsOfTypeAll<MeshCollider>();
                    foreach (MeshCollider meshCollider in array)
                    {
                        meshCollider.enabled = false;
                    }
                }
            }
            else
            {
                {
                    MeshCollider[] array = Resources.FindObjectsOfTypeAll<MeshCollider>();
                    foreach (MeshCollider meshCollider in array)
                    {
                        meshCollider.enabled = true;
                    }
                }
            }
        }

        public static GameObject pointer;

        public static void TpGun()
        {

            if (ControllerInputPoller.instance.rightGrab)
            {
                if (ControllerInputPoller.instance.rightControllerIndexFloat == 1f)
                {
                    Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out var hitinfo);
                    pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    pointer.transform.position = hitinfo.point;
                    pointer.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    pointer.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
                    pointer.GetComponent<Renderer>().material.color = new Color32(0, 0, 128, 1);
                    GameObject.Destroy(pointer.GetComponent<BoxCollider>());
                    GameObject.Destroy(pointer.GetComponent<Rigidbody>());
                    GameObject.Destroy(pointer.GetComponent<Collider>());
                    if (ControllerInputPoller.instance.rightControllerIndexFloat >= 0.1)
                    {
                        GameObject.Destroy(pointer, Time.deltaTime);
                        pointer.GetComponent<Renderer>().material.color = new Color32(0, 255, 255, 1);
                        GorillaLocomotion.Player.Instance.transform.position = pointer.transform.position;
                        GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = pointer.transform.position;
                    }
                }
                if (pointer != null)
                {
                    GameObject.Destroy(pointer, Time.deltaTime);
                }

            }

        }

        public static void Fly()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += (GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                GorillaTagger.Instance.handTapVolume = 80;
            }
        }

        public static void LeftFly()
        {
            if (ControllerInputPoller.instance.leftControllerSecondaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += (GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                GorillaTagger.Instance.handTapVolume = 80;
            }
        }

        public static void TriggerFly()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.Player.Instance.transform.position += (GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                GorillaTagger.Instance.handTapVolume = 80;
            }
        }

        public static void GhostMonke()
        {
            bool Primary = ControllerInputPoller.instance.rightControllerSecondaryButton;
            {
                if (Primary == true)
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                }
            }
        }


    }
}
