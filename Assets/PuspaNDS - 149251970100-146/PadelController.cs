using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadelController : MonoBehaviour
{
    public Vector2 speed;
    public KeyCode upKey;
    public KeyCode downKey;
    BallController ball;

    private Rigidbody2D rig;
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }
    private void Update()
    {
        //Gerak pake Input 
        MoveObject(GetInput());
    }
    private Vector2 GetInput()
    {
        if(Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }

    public void ExtendPadel()
    {
        gameObject.transform.localScale += new Vector3(0, 2, 0);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        Debug.Log("LONG");
    }
    public void NormalPadel()
    {
        gameObject.transform.localScale -= new Vector3(0, 2, 0);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        Debug.Log("NORMAL");
    }
    public void IncreaseSpeed()
    {
        speed= speed*2;
        Debug.Log("SPEED UP");
    }
    public void NormalSpeed()
    {
        speed = speed / 2;
        Debug.Log("NORMAL SPEED");
    }
}
