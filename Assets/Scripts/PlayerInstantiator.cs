using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerInstantiator : MonoBehaviourPunCallbacks
{

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerInfo.localPlayer == null)
        {
            GameObject playerObj = PhotonNetwork.Instantiate("Player", new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
            ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
            hashtable["viewID"] = playerObj.GetComponent<PhotonView>().ViewID;
            PhotonNetwork.LocalPlayer.SetCustomProperties(hashtable);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
