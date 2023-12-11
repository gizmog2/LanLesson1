using System.Collections;
using System.Collections.Generic;
//using UnityEngine.Networking;
using Unity.Netcode;
using Unity.Services.Multiplay;
using UnityEditor;
using UnityEngine;

public class PlayerHelper : NetworkBehaviour
{
    GameHelper gameHelper;

    // Start is called before the first frame update
    void Start()
    {
        gameHelper = GameObject.FindAnyObjectByType<GameHelper>();

        if ( IsLocalPlayer)
        {
            gameHelper.CurrentPlayer = this;
        }
    }

    public void Send(string message)
    {
        SendServerRpc(NetworkObjectId.ToString(), message);
    }

    [ServerRpc]
    public void SendServerRpc(string id, string message)
    {
        int rand = Random.Range(0, 100);

        Debug.Log("Send = " + message + " / " + id);
        SendClientRpc(id, message, rand);
    }

    [ClientRpc]
    public void SendClientRpc(string id, string message, int rand)
    {
        gameHelper.textBlock.text += System.Environment.NewLine + id + " : " + message + " / random = " + rand;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
