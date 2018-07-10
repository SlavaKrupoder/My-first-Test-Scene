using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : Photon.MonoBehaviour
{
    public void Start()
    {
        PhotonNetwork.autoJoinLobby = false;
        PhotonNetwork.ConnectUsingSettings("version 1");
    }

    public void OnConnectedToMaster()
    {
        Debug.Log("Connect OK");
        Loading.Load(LoadingScane.Menu);
    }
}
