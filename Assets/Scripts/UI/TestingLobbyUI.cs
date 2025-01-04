using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using System;
using UnityEngine.SceneManagement;

public class TestingLobbyUI : MonoBehaviour
{
    [SerializeField] private Button _createGameButton;
    [SerializeField] private Button _joinGameButton;

    private void Awake()
    {
        _createGameButton.onClick.AddListener(() =>
        {
            GameMultiplayer.Instance.StartHost();
            SceneLoading.LoadNetwork(SceneLoading.Scene.CharacterSelectScene);
        });

        _joinGameButton.onClick.AddListener(() =>
        {
            GameMultiplayer.Instance.StartClient();
        });
    }

    public void ToMenu()
    {
        SceneLoading.Load(SceneLoading.Scene.MenuScene);
    }
}
