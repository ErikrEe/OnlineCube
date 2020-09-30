using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class GameSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();
    }


    void CreatePlayer()
    {
        if(PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate("Player1", Vector3.zero, Quaternion.identity);
        }
        else
        {
            PhotonNetwork.Instantiate("Player2", Vector3.zero, Quaternion.identity);
        }

        print("Created players");

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
