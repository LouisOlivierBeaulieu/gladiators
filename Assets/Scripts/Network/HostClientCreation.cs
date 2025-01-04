using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class HostClientCreation : MonoBehaviour
{
    [SerializeField] private Button hostButton;
    [SerializeField] private Button clientButton;

    private void Awake()
    {
        hostButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartHost();
            Debug.Log("Host created");
            Hide();
        });

        hostButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();
            Debug.Log("Client created");
            Hide();
        });
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
