using System;
using UnityEngine;

public class ConnectingUI : MonoBehaviour
{
    private void Start()
    {
        GameMultiplayer.Instance.OnTryingToJoinGame += TestingLobbyUI_OnTryingToJoinGame;
        GameMultiplayer.Instance.OnFailedToJoinGame += TestingLobbyUI_OnFailedToJoinGame;
        Hide();
    }

    private void TestingLobbyUI_OnFailedToJoinGame(object sender, EventArgs e)
    {
        Hide();
    }

    private void TestingLobbyUI_OnTryingToJoinGame(object sender, EventArgs e)
    {
        Show();
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide() 
    {
        gameObject.SetActive(false);
    }
    private void OnDestroy()
    {
        GameMultiplayer.Instance.OnTryingToJoinGame -= TestingLobbyUI_OnTryingToJoinGame;
        GameMultiplayer.Instance.OnFailedToJoinGame -= TestingLobbyUI_OnFailedToJoinGame;
    }
}
