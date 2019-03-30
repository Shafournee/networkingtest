using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerInfo : MonoBehaviourPunCallbacks
{
    public static PlayerInfo localPlayer;
    public Color playerColor;

    private void Awake()
    {
        if(photonView.IsMine)
        {
            localPlayer = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerColor = new Color(Random.value, Random.value, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
