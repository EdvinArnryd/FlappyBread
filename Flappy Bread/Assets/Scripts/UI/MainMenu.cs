using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    void Awake()
    {
        Game.OnStartGame += DeActivateMenu;
        Game.OnEndGame += ActivateMenu;
    }

    private void ActivateMenu()
    {
        _panel.SetActive(true);
    }

    private void DeActivateMenu()
    {
        _panel.SetActive(false);
    }
}
