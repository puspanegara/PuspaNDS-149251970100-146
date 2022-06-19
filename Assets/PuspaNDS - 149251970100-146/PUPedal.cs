using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPedal : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            Debug.Log("GET ITEM");
            ball.GetComponent<BallController>().ActivePUPedal();
            manager.RemovePowerUp(gameObject);
        }
    }
}
