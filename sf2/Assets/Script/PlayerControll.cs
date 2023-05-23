using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//player에 필요한 요소 관리, 통로 같은 역할
public class PlayerControll : MonoBehaviour
{ /*static float offensePower = 10;
    public float get_offensePower {get {return offensePower;}}*/

    Animator animator;
    [SerializeField]
    float maxSpeed = 5f;
    float moveX, moveY;
    private bool isMoving;
    void Start()
    {
        animator=GetComponent<Animator>();
    }
    private void Update() 
    {
        player_move();
        player_Nmove();
        player_attack();
        player_guard();
    }private void player_move() //다시
    {
        moveX = Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
        moveY = Input.GetAxis("Vertical") * maxSpeed * 2 *Time.deltaTime;

        if(moveX>0)
        {
            animator.Play("RYU Walk");
           
        }
        if(moveX==0)
        {
            animator.Play("RYU Idle");
        }
        if(moveX<0)
        {
            animator.Play("RYU Walk");
        }
        if(moveY<0)
        {
            animator.Play("RYU Sit");
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            animator.Play("RYU Jump");
        }
        
       

        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveY);
    }


    private void player_Nmove()
    {
        // if bool 값을 time에서 불러옴
        if (TimeManager.TimeType == false)
        {
            maxSpeed = 0.0f; //다음 라운드에서는 true로 전환되어 움직일 수 있는 코드 필요
            Debug.Log("player stop");
        }
        /*else if(PlayerState.player_hp(PlayerState.HpType) == false)
        {
            maxSpeed = 0.0f;
            Debug.Log("player stop");
        }*/
    }

    private void player_attack()
    {   //var a = Enum.GetNames(typeof(status))
    }

    void player_guard()
    {
        if(Input.GetKey(KeyCode.A))
        {
            //애니메이션 불러오기 
        }
    }
}
