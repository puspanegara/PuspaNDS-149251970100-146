using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedPadel : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            ball.GetComponent<BallController>().ActiveSpeedPedal();
            manager.RemovePowerUp(gameObject);
            Debug.Log("GREEN ITEM");
        }
    }
}
