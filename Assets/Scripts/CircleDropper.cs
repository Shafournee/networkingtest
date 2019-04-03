using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CircleDropper : MonoBehaviourPunCallbacks
{

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void colorize()
    {
        if(PlayerInfo.localPlayer.isActivePlayer)
            photonView.RPC("NetworkedColorChange", RpcTarget.All, PlayerInfo.localPlayer.playerColor.r, PlayerInfo.localPlayer.playerColor.g, PlayerInfo.localPlayer.playerColor.b);
    }

    [PunRPC]
    private void NetworkedColorChange(float r, float g, float b, PhotonMessageInfo info)
    {
        int sendersViewID = (int)info.Sender.CustomProperties["viewID"];
        foreach (Photon.Realtime.Player player in PhotonNetwork.PlayerList)
        {
            if(sendersViewID == (int)player.CustomProperties["viewID"])
            {
                PhotonView.Find(sendersViewID).GetComponent<PlayerInfo>().isActivePlayer = false;
            }
            else
            {
                PhotonView.Find((int)player.CustomProperties["viewID"]).GetComponent<PlayerInfo>().isActivePlayer = true;
            }
        }
        
        GetComponent<Image>().color = new Color(r, g, b);

    }
}
