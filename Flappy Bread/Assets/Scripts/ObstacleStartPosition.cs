using UnityEngine;

public class ObstacleStartPosition : MonoBehaviour
{
    private RectTransform _rectTransform;
    private float _startYPosition;
    private float _startXPosition;
    void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _startXPosition = _rectTransform.anchoredPosition.x;
    }

    void OnEnable()
    {
        _startYPosition = _rectTransform.anchoredPosition.y;
        _rectTransform.anchoredPosition = new Vector2(_startXPosition, _startYPosition);
    }
}
