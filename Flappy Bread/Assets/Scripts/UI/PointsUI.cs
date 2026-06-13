using TMPro;
using UnityEngine;

public class PointsUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private PointsData _pointsData;

    void Awake()
    {
        _pointsData.PointUpdate += OnAddPoint;
        
        _text.text = 0.ToString();
    }

    private void OnAddPoint(int points)
    {
        _text.text = points.ToString();
    }

}
