using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    private float _worldXSpawnPoint = 1920;
    private float _worldXTeleportPoint = -1920;

    private float _allSpeedMultiplier = 5f;

    private RectTransform _rectTransform;

    void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    void LateUpdate()
    {
        if(_rectTransform.anchoredPosition.x <= _worldXTeleportPoint)
        {
            _rectTransform.anchoredPosition = new Vector3(_worldXSpawnPoint,_rectTransform.anchoredPosition.y,0);
        }
        _rectTransform.position += new Vector3(-_speed * Time.deltaTime * _allSpeedMultiplier,0,0);
    }
}
