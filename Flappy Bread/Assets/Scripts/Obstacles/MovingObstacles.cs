using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private float _anchoredXSpawnPoint = 1000;
    private float _anchoredXTeleportPoint = -1000;
    private int _obstacleYTop = 146;
    private int _obstacleYBottom = -420;
    private RectTransform _rectTransform;
    private float _xStartPos;

    void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _xStartPos = _rectTransform.anchoredPosition.x;
    }

    void Start()
    {
        _rectTransform.anchoredPosition = new Vector3(_rectTransform.anchoredPosition.x, RandomY(), 0);
    }

    void Update()
    {
        if(_rectTransform.anchoredPosition.x <= _anchoredXTeleportPoint)
        {
            _rectTransform.anchoredPosition = new Vector3(_anchoredXSpawnPoint, RandomY(), 0);
        }
        _rectTransform.position += new Vector3(-_speed * Time.deltaTime,0,0);
    }

    void OnEnable()
    {
        _rectTransform.anchoredPosition = new Vector2(_xStartPos, RandomY());
    }

    private int RandomY()
    {
        return Random.Range(_obstacleYBottom, _obstacleYTop);
    }
}