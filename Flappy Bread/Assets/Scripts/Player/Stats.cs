using System;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField] private PointsData _pointsData;
    private PlayerCollision _playerCol;

    void Awake()
    {
        _playerCol = GetComponent<PlayerCollision>();

        _playerCol.AddPoint += _pointsData.AddPoint;
    }
}
