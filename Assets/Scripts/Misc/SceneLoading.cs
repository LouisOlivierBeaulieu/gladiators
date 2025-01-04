using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoading
{

    public enum Scene
    {
        MenuScene,
        LobbyScene,
        CharacterSelectScene,
        GameScene,
        TrainingScene
    }

    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public static void LoadNetwork(Scene scene)
    {
        NetworkManager.Singleton.SceneManager.LoadScene(scene.ToString(), LoadSceneMode.Single);
    }
}