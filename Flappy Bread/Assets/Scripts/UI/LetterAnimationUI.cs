using Unity.Mathematics;
using UnityEngine;

public class LetterAnimationUI : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private int _amplitude = 15;
    [SerializeField] private float _increment = 1;

    private Vector3 _startPos;

    void Awake()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        transform.position = _startPos + new Vector3(0,Mathf.Sin(_increment + Time.time * _speed)* _amplitude,0);
    }
}
