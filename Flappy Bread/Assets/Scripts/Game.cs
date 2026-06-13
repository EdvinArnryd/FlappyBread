using System;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game _instance;

    public static event Action OnPauseGame;
    public static event Action OnStartGame;
    public static event Action OnEndGame;
    [SerializeField] private GameObject[] _startingObjects;

    void Awake()
    {
        _instance = this;
    }

    public static void PauseGame()
    {
        Time.timeScale = 0;

        OnPauseGame?.Invoke();
    }

    public static void StartGame()
    {
        Time.timeScale = 1;
        DeActivateObjects();
        ActivateObjects();
        OnStartGame?.Invoke();
    }

    public static void EndGame()
    {
        Time.timeScale = 1;
        OnEndGame?.Invoke();
    }

    public static void ActivateObjects()
    {
        foreach (var obj in _instance._startingObjects)
        {
            obj.gameObject.SetActive(true);
        }
    }

    public static void DeActivateObjects()
    {
        foreach (var obj in _instance._startingObjects)
        {
            obj.gameObject.SetActive(false);
        }
    }
}
