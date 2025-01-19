using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;


public class HostDisconnectedUI : NetworkBehaviour
{
    [SerializeField] private Button _backToMenuButton;

    private void Awake()
    {
        _backToMenuButton.onClick.AddListener(() => {
            SceneLoading.Load(SceneLoading.Scene.MenuScene);
        });
    }

    private void Start()
    {
        NetworkManager.Singleton.OnClientDisconnectCallback += NetworkManager_OnClientDisconnectCallback;
        Hide();
    }

    private void NetworkManager_OnClientDisconnectCallback(ulong clientId)
    {
        if (clientId == NetworkManager.ServerClientId)
        {
            Show();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
