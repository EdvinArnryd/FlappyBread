using TMPro;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _gamePoints;

    [SerializeField] private GameObject _panel;
    [SerializeField] private TMP_Text _pointsText;

    [SerializeField] private PointsData _pointsData;

    void Awake()
    {
        Game.OnPauseGame += ActivatePauseMenu;
        Game.OnEndGame += DeActivatePauseMenu;
        _pointsData.PointUpdate += UpdatePoints;
    }

    private void ActivatePauseMenu()
    {
        _gamePoints.SetActive(false);
        _panel.SetActive(true);
    }

    private void DeActivatePauseMenu()
    {
        _gamePoints.SetActive(true);
        _panel.SetActive(false);
    }


    private void UpdatePoints(int points)
    {
        _pointsText.text = points.ToString();
    }
}
