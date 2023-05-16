using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//player에 필요한 요소 관리, 통로 같은 역할
public class PlayerControll : MonoBehaviour
{
    public PlayerState hp_state;
    [SerializeField]
    float maxSpeed = 5f;
    float moveX, moveY;

    private void Start() 
    {
        hp_state.HpType += false; //?
    }

    private void Update() 
    {
        player_move();
        player_Nmove();

        //if(HpType.Invoke(false))
            //return;
    }
    private void player_move()
    {
        moveX = Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
        moveY = Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
    }

    private void player_Nmove()
    {
        // if bool 값을 time에서 불러옴
        if (TimeManager.TimeType == false)
        {
            maxSpeed = 0.0f;
            Debug.Log("player stop");
        }

        else if(/*HpState == true*/)
        {
            maxSpeed = 0.0f;
            Debug.Log("player stop");
        }
    }

}