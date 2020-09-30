﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LobbyController : MonoBehaviourPunCallbacks
{

    public int roomSize;

    public void JoinRoom()
    {
        PhotonNetwork.JoinRandomRoom();
        print("Trying to join...");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        print("can't find room");
        CreateRoom();
    }

    void CreateRoom()
    {
        print("Creating room...");
        int randomRoomNumber = Random.Range(0, 100000);
        print(randomRoomNumber);

        RoomOptions options = new RoomOptions()
        {
            IsVisible = true,
            IsOpen = true,
            MaxPlayers = (byte)roomSize

        };

        PhotonNetwork.CreateRoom("Room" + randomRoomNumber, options);
    }


   

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
