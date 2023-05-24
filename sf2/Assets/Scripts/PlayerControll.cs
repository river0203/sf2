using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//player에 필요한 요소 관리, 통로 같은 역할
public class PlayerControll : MonoBehaviour
{
    public enum Key
    {
        none,
        db, // 사진의 1~9까지
        d,
        fd, 
        b, 
        f,
        ub,
        u,
        uf, 
        A, //약손
        B, //약발
        C, //강손
        D, //강발
        
    }
    public enum status
    {
        A = 5, //약손
        B = 6, //약발
        C = 8, //강손
        D = 10, //강발
        None,
        _isMoving,
        _isJumping,
        _isGuarding,
        _isSitting,
        //아도겐은 펀치의 강,중,약에 따라 날아가는 속도가 달라짐
        strongadogen = 15, //강파동권
        middleadogen = 11, //중파동권
        strongpiggybacking, //강 업어치기
        middlepiggybacking, //중 업어치기
        strongbackandflipping, //강 배대뒤치기
        middlebackandflipping, //중 배대뒤치기
        breakingthecollarbone = 14, //쇄골깨기
        pitofthestomach = 16, //명치부수기
        oryugen = 24, //승룡권
        //용권선풍각은 킥의 강,중 에 따라 거리가 달라짐
        strongaddaddaddugen = 35, //강용권선풍각
        middleaddaddaddugen = 28, //중용권선풍각
        airaddaddaddugen = 24, //공중 용권선풍각
    }
    public Key [] Move = {Key.b, Key.none, Key.db, Key.d, Key.fd, Key.f, Key.ub, Key.u, Key.uf};
    public Key [] _isSitting = {Key.d};
    public Key [] Jump = {Key.u};
    public Key [] strongadogen = {Key.d,Key.fd,Key.f,Key.C};
    public Key [] middleadogen = {Key.d,Key.fd,Key.f,Key.A};
    public Key [] strongaddaddaddugen = {Key.d,Key.db,Key.b,Key.D};        
    public Key [] middleaddaddaddugen = {Key.d,Key.db,Key.b,Key.B};
    public Key [] strongpiggybacking = {Key.b,Key.C};
    public Key [] middlepiggybacking = {Key.b,Key.A};
    public Key [] strongbackandflipping = {Key.b,Key.D};
    public Key [] middlebackandflipping = {Key.b,Key.B};
    public Key [] breakingthecollarbone = {Key.f,Key.A};
    public Key [] pitofthestomach = {Key.f,Key.C};
    public Key [] oryugen = {Key.f,Key.d,Key.fd,Key.C};        
    public Key [] weak_oryugen = {Key.f,Key.d,Key.fd,Key.A};
    public Key [] sinkuadogen = {Key.d,Key.fd,Key.f,Key.d,Key.fd,Key.f,Key.C};
    public Key [] weak_sinkuadogen = {Key.d,Key.fd,Key.f,Key.d,Key.fd,Key.f,Key.A};

    [SerializeField]
    float maxSpeed = 5f;
    float JumpForce = 2f;
    float moveX, moveUp;
    bool isJump;    
    public status state = status.None;

    Rigidbody2D rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update() 
    {
        player_move();
        player_Nmove();
        player_attack();
        player_guard();
    }
    private void player_move() //다시
    {
        moveX = Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W) && isJump == false)
        { 
            moveUp += (JumpForce * Time.deltaTime);
            isJump = true;
            rigid.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
        }
        transform.position = new Vector2(transform.position.x + moveX, transform.position.y + moveUp);

        //if(Input.GetKeyDown(Move[(int)Key.b]))
        {
            state  = status._isMoving;
        }
    }

    private void player_Nmove()
    {
        // if bool 값을 time에서 불러옴
        if (TimeManager.TimeType == false)
        {
            maxSpeed = 0.0f; //다음 라운드에서는 true로 전환되어 움직일 수 있는 코드 필요
            Debug.Log("player stop");//true 가 되면 hp 회복 
        }

        else if(PlayerState.player_hp(PlayerState.HpType) == false)
        {
            maxSpeed = 0.0f;
            Debug.Log("player stop");
        }
    }

    private void player_attack()
    {
        //var a = Enum.GetNames(typeof(status))

    }

    private void player_guard()
    {
        if(Input.GetKey(KeyCode.A))
        {
            state = status._isMoving;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isJump = false;
        }
    }
}

