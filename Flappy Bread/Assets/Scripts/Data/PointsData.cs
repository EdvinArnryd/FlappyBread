using System;
using UnityEngine;

[CreateAssetMenu]
public class PointsData : ScriptableObject
{
    public int _points { get; private set; }
    public event Action<int> PointUpdate;

    public void AddPoint()
    {
        _points += 1;
        PointUpdate?.Invoke(_points);
    }

    void OnEnable()
    {
        _points = 0;
    }
}
