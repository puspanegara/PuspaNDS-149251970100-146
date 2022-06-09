using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadelController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
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
}
