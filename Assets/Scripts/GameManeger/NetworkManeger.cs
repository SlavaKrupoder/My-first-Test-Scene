using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManeger : Photon.MonoBehaviour
{
	void Start ()
    {
        LoadMap();
        SpawnPlayer();
	}

    void Update()
    {
        if(PhotonNetwork.isMasterClient)
        {
            UpdateGameLogic();
        }
    }

    private void LoadMap()
    {
        if (PhotonNetwork.room != null && !PhotonNetwork.offlineMode)
        {
            PhotonNetwork.Instantiate("Map", new Vector3(0, 0, 0), Quaternion.identity, 0);
        }
        else
        {
            Debug.Log("Discinnect");
        }
    }

    private void SpawnPlayer()
    {
        if (PhotonNetwork.room != null && !PhotonNetwork.offlineMode)
        {
            PhotonNetwork.Instantiate("Player", new Vector3(0, 2, 0), Quaternion.identity, 0);
        }
        else
        {
            Debug.Log("Discinnect");
        }
    }

    private void UpdateGameLogic()
    {

    }
}
