using Photon.Realtime;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class TEST
    {
        public static System.Object rightPrimary = ControllerInputPoller.instance.rightControllerPrimaryButton;
        public static System.Object leftPrimary = ControllerInputPoller.instance.leftControllerPrimaryButton;


        public static void FreezeRigBody()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;

                GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.transform.position = GorillaTagger.Instance.rightHandTransform.position;

                GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
                GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;

                GorillaTagger.Instance.offlineVRRig.head.rigTarget.transform.rotation = GorillaTagger.Instance.headCollider.transform.rotation;

                GameObject l = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                UnityEngine.Object.Destroy(l.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(l.GetComponent<SphereCollider>());

                l.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                l.transform.position = GorillaTagger.Instance.leftHandTransform.position;

                GameObject r = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                UnityEngine.Object.Destroy(r.GetComponent<Rigidbody>());
                UnityEngine.Object.Destroy(r.GetComponent<SphereCollider>());

                r.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                r.transform.position = GorillaTagger.Instance.rightHandTransform.position;

               

                UnityEngine.Object.Destroy(l, Time.deltaTime);
                UnityEngine.Object.Destroy(r, Time.deltaTime);
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
    }
}
