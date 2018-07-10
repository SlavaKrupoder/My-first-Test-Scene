using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerManeger : Photon.MonoBehaviour
{
    public Camera PlayerCamera;
    public RigidbodyFirstPersonController ScriptChacControl;
    Vector3 realPosition = Vector3.zero;
    Quaternion RealRotation = Quaternion.identity;
    public Animator Anim;

    void Start()
    {
        if(photonView.isMine)
        {
            gameObject.name = "Player";
        }
        else
        {
            PlayerCamera.enabled = false;
            PlayerCamera.enabled = false;
            gameObject.name = "OtherPlayer";
        }
    }
}
