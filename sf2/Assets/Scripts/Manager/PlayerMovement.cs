using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// 좌표를 통한 캐릭터 이동
// 조건이 되었을 때 행동 차단 시간, HP
public class PlayerMovement : MonoBehaviour 
{
    [SerializeField]
    float maxSpeed = 5f;
    float moveX, moveY;
    
    private void Update() 
    {
        player_move();
        player_Nmove();
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
        if (/*TimeBool_type == False*/)
        {
            maxSpeed = 0.0f;
            Debug.Log("player stop");
        }

        else if(/*hp == 0*/)
        {
            maxSpeed = 0.0f;
            Debug.Log("player stop");
        }
    }

}