using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : Photon.MonoBehaviour
{
    void Start()
    {
        Debug.Log("Menu OK");
        PhotonNetwork.JoinOrCreateRoom("TestrAena", new RoomOptions(), TypedLobby.Default);
        Loading.Load(LoadingScane.Game);
    }
}
