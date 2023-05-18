using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//가드, 스턴 , -hp값 추가, 일반 공격 특수 공격 구분
public class PlayerState
{
    public static bool HpType;
    public static float hp = 100; //읽기 전용

    private void Update() 
    {
        player_hp();
        player_hit();
    }
    
    public static void player_hp()
    {
        if(hp == 0.0f)
        {
            HpType = false;
        }
        else if(hp != 0.0f)
        {
            HpType = true;
        }
    }

    void player_stun()
    {

    }

    void player_guard()
    {
        if(Input.GetKey(KeyCode.A))
        {
            //애니메이션 불러오기

        }
    }

    private void player_hit()
    {
        // hitbox에 애니메이션 감지시 
        hp -= PlayerControll.Instance.offensePower;
    }

}