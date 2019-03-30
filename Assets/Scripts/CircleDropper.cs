﻿using System.Collections;
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
        photonView.RPC("NetworkedColorChange", RpcTarget.All);
    }

    [PunRPC]
    private void NetworkedColorChange()
    {
        Color color = PlayerInfo.localPlayer.playerColor;
        GetComponent<Image>().color = color;
    }
}
