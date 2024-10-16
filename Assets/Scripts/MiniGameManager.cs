using UnityEngine;

public class MiniGameManager : MonoBehaviour
{
    [SerializeField] private GameObject miniGamePrefab;

    public void StartMiniGame()
    {
        miniGamePrefab.SetActive(true);
    }
}
