using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainingButtons : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
