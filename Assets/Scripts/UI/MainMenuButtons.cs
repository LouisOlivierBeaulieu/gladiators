using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void ToLobby()
    {
        SceneLoading.Load(SceneLoading.Scene.LobbyScene);
    }

    public void ToTraining()
    {
        SceneLoading.Load(SceneLoading.Scene.TrainingScene);
    }

    public void QuitGame()
    {
        Debug.Log("\nGame Quit");
        Application.Quit();
    }
}
