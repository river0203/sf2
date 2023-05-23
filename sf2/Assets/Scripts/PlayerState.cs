using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//가드, 스턴 , -hp값 추가, 일반 공격 특수 공격 구분
public class PlayerState
{
    public static bool HpType;
    public static float i_hp = 170.0f; //읽기 전용
    public float stunPower {get; private set;}

    private void Update() 
    {
        player_hp(HpType);
        player_hit();
    }
    
    public static bool player_hp(bool B_Hp)
    {
        if(i_hp == 0.0f)
        {
            B_Hp = false;
        }
        else if(i_hp != 0.0f)
        {
            B_Hp = true;
        }

        return B_Hp;
    }

    void player_stun()
    {
        
    }

    private void player_hit()
    {
        // hitbox에 애니메이션 감지시 
    }

}