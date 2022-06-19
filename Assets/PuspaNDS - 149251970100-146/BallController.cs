using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    public bool hitRP,hitLP;
    public bool isLonger,isFaster;
    public bool longLP,longRP;
    public bool speedLP, speedRP;
    public float durationLP,durationSP;
    public float timerLPR,timerLPL, timerSPL, timerSPR;
    public PadelController objRPadel,objLPadel;
    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }
    private void Update()
    {
            if(longRP == true)
            {
                timerLPR += Time.deltaTime; 
                if(timerLPR >=durationLP)
                {
                    longRP = false;
                    isLonger = false;
                    objRPadel.NormalPadel();
                    timerLPR = 0;
                }
            }
            if (longLP == true)
            {
                timerLPL += Time.deltaTime;
                if (timerLPL >= durationLP)
                {
                    longLP = false;
                    isLonger = false;
                    objLPadel.NormalPadel();
                    timerLPL = 0;
                }
            }
        if (speedRP == true)
        {
            timerSPR += Time.deltaTime;
            if (timerSPR >= durationSP)
            {
                speedRP = false;
                isFaster = false;
                objRPadel.NormalSpeed();
                timerSPR = 0;
            }
        }
        if (speedLP == true)
        {
            timerSPL += Time.deltaTime;
            if (timerSPL >= durationSP)
            {
                speedLP = false;
                isFaster= false;
                objLPadel.NormalSpeed();
                timerSPL = 0;
            }
        }
    }
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity*= magnitude;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "RightPadel")
        {
            hitRP = true;
            Debug.Log("RIGHT");
        }
        else if (collision.gameObject.tag == "LeftPadel")
        {
            hitLP = true;
            Debug.Log("LEFT");
        }
    }
    public void ActivePUPedal()
    {
        if (hitRP == true)
        {
            hitRP = false;
            isLonger = true;
            longRP = true;
            objRPadel.ExtendPadel();
        }
        else if (hitLP == true)
        {
            hitLP=false;    
            isLonger = true;
            longLP = true;
            objLPadel.ExtendPadel();
        }
    }
    public void ActiveSpeedPedal()
    {
        if (hitRP == true)
        {
            hitRP = false;
            isFaster = true;
            speedRP = true;
            objRPadel.IncreaseSpeed();
        }
        else if (hitLP == true)
        {
            hitLP = false;
            isFaster= true;
            speedLP= true;
            objLPadel.IncreaseSpeed();
        }
    }
}
