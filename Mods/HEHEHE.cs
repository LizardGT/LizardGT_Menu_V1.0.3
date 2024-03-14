using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class HEHEHE
    {
        public static GameObject pointer;

        public static void BugGun()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out var hitInfo);
                pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                pointer.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 1);
                pointer.transform.position = hitInfo.point;
                GameObject.Destroy(pointer.GetComponent<BoxCollider>());
                GameObject.Destroy(pointer.GetComponent<Rigidbody>());
                GameObject.Destroy(pointer.GetComponent<Collider>());
                if (ControllerInputPoller.instance.rightControllerIndexFloat >= 0.3f)
                {
                    GameObject.Find("Floating Bug Holdable").transform.position = pointer.transform.position;
                }
            }
            if (pointer != null)
            {
                GameObject.Destroy(pointer, Time.deltaTime);
            }
        }
    }
}
