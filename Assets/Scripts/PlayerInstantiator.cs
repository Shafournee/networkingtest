using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerInstantiator : MonoBehaviourPunCallbacks
{

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerInfo.localPlayer == null)
        {
            PhotonNetwork.Instantiate("Player", new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
