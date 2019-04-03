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
        photonView.RPC("NetworkedColorChange", RpcTarget.All, PlayerInfo.localPlayer.playerColor.r, PlayerInfo.localPlayer.playerColor.g, PlayerInfo.localPlayer.playerColor.b);
    }

    [PunRPC]
    private void NetworkedColorChange(float r, float g, float b)
    {
        GetComponent<Image>().color = new Color(r, g, b);
    }
}
