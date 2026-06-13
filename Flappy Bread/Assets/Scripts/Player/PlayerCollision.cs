using UnityEngine;
using System;

public class PlayerCollision : MonoBehaviour
{
    public event Action AddPoint;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            Game.PauseGame();
        }
        else if(collision.gameObject.tag == "Point")
        {
            AddPoint.Invoke();
        }
    }
}
