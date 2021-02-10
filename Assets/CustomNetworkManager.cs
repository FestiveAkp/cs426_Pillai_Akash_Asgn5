using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CustomNetworkManager : NetworkManager
{
    public bool hasHostConnected = false;

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        if (hasHostConnected)
        {
            GameObject prefab = spawnPrefabs[0];
            GameObject prefabInstance = Instantiate(prefab);
            NetworkServer.AddPlayerForConnection(conn, prefabInstance, playerControllerId);
        }
        else
        {
            GameObject prefab = spawnPrefabs[1];
            GameObject prefabInstance = Instantiate(prefab);
            NetworkServer.AddPlayerForConnection(conn, prefabInstance, playerControllerId);
            hasHostConnected = true;
        }
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        ClientScene.Ready(conn);
        if (hasHostConnected)
        {
            
            ClientScene.AddPlayer(conn, 0);
        }
        else
        {
            ClientScene.AddPlayer(conn, 0);
        }
    }
}
