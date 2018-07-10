using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LoadingScane
{
    Menu,
    Game
}

public class Loading : Photon.MonoBehaviour
{
    private static LoadingScane _nextScene;

    private void Start()
    {
        if(_nextScene == LoadingScane.Menu)
        {
            StartCoroutine(JointLobby());
        }
    }

    private IEnumerator JointLobby()
    {
        while (PhotonNetwork.networkingPeer.State != PhotonNetwork.connectionStateDetailed)
            yield return new WaitForFixedUpdate();
        
        PhotonNetwork.networkingPeer.OpJoinLobby(TypedLobby.Default);
    }

    void OnJoinedLobby()
    {
       PhotonNetwork.LoadLevel(Config.SceneMenu);
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(Config.SceneGame);
    }

    public static void Load(LoadingScane nextScene)
    {
        _nextScene = nextScene;
        PhotonNetwork.LoadLevel(Config.SceneLoading);
    }
}
