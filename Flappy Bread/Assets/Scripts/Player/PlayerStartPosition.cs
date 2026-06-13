using UnityEngine;

public class PlayerStartPosition : MonoBehaviour
{
    private RectTransform _rectTransform;
    private Vector2 _startPosition;
    void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _startPosition = _rectTransform.anchoredPosition;
    }

    void OnEnable()
    {
        _rectTransform.anchoredPosition = _startPosition;
    }
}
