using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class TestingCharacterSelectUI : MonoBehaviour
{
    [SerializeField] private Button _readyButton;
    private const int MIN_PLAYER = 2;
    private void Awake()
    {
        _readyButton.onClick.AddListener(() =>
        {   
            if(NetworkManager.Singleton.ConnectedClientsIds.Count >= MIN_PLAYER)
            {
                CharacterSelectReady.Instance.SetPlayerReady();
            }
        });
    }
}
