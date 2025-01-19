using System;
using UnityEngine;
using TMPro;
using Unity.Netcode;
using System.Linq.Expressions;

public class ConnectingResponseUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _connectingResponseMessage;

    private void Start()
    {
        GameMultiplayer.Instance.OnFailedToJoinGame += TestingLobbyUI_OnFailedToJoinGame;
        Hide();
    }

    private void TestingLobbyUI_OnFailedToJoinGame(object sender, EventArgs e)
    {
        if (NetworkManager.Singleton.DisconnectReason == "")
        {
            ShowMessage("Failed to connect");
        }
        else
        {
            ShowMessage(NetworkManager.Singleton.DisconnectReason);
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

    private void ShowMessage(string message)
    {
        Show();
        _connectingResponseMessage.text = message;
    }

    private void OnDestroy()
    {
        GameMultiplayer.Instance.OnFailedToJoinGame -= TestingLobbyUI_OnFailedToJoinGame;
    }
}

