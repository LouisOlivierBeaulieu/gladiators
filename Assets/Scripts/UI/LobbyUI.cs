using UnityEngine;
using UnityEngine.UI;

public class LobbyUI : MonoBehaviour
{
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private Button _createLobbyButton;
    [SerializeField] private Button _quickJoinButton;

    private void Awake()
    {
        _mainMenuButton.onClick.AddListener(() =>
        {
            SceneLoading.Load(SceneLoading.Scene.MenuScene);
        });

        _createLobbyButton.onClick.AddListener(() =>
        {

            GameLobby.Instance.CreateLobby("NewLobby", false);
        });

        _quickJoinButton.onClick.AddListener(() =>
        {

            GameLobby.Instance.QuickJoin();
        });
    }

    public void ToMenu()
    {
        SceneLoading.Load(SceneLoading.Scene.MenuScene);
    }
}
