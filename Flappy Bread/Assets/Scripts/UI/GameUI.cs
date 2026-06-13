using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    void Awake()
    {
        Game.OnStartGame += ActivateGameUI;
        Game.OnEndGame += DeActivateGameUI;
    }

    private void ActivateGameUI()
    {
        _panel.SetActive(true);
    }

    private void DeActivateGameUI()
    {
        _panel.SetActive(false);
    }
}
