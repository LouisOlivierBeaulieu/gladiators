using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class CharacterSelectReady : NetworkBehaviour
{
    public static CharacterSelectReady Instance { get; private set; }


    private Dictionary<ulong, bool> _playerReayDictionary;

    private void Awake()
    {
        Instance = this;
        _playerReayDictionary = new Dictionary<ulong, bool>();
    }

    public void SetPlayerReady()
    {
        SetPlayerReadyServerRpc();
    }

    [ServerRpc(RequireOwnership = false)]
    private void SetPlayerReadyServerRpc(ServerRpcParams serverRpcParams = default)
    {
        _playerReayDictionary[serverRpcParams.Receive.SenderClientId] = true;

        bool allClientsready = true;
        foreach (ulong clientId in NetworkManager.Singleton.ConnectedClientsIds)
        {
            if (!_playerReayDictionary.ContainsKey(clientId) || !_playerReayDictionary[clientId])
            {
                allClientsready = false;
                break;
            }
        }

        if (allClientsready)
        {
            SceneLoading.LoadNetwork(SceneLoading.Scene.GameScene);
        }
    }
}
