using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//가드, 스턴 , -hp값 추가, 일반 공격 특수 공격 구분
public class PlayerState
{
    public static bool HpType;
    private static float i_hp = 170.0f;
    public PlayerControll.status state = PlayerControll.status.None;
    private void Update() 
    {
        player_hp(HpType);
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
    
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Player2_Attack")
        {
            if(state == PlayerControll.status.middleaddaddaddugen)
            {
                i_hp -= 28;
            }
            if(state == PlayerControll.status.middleadogen)
            {
                i_hp -= 11;
            }
            if(state == PlayerControll.status.strongadogen)
            {
                i_hp -= 15;
            }
            if(state == PlayerControll.status.breakingthecollarbone)
            {
                i_hp -= 14;
            }
            if(state == PlayerControll.status.pitofthestomach)
            {
                i_hp -= 16;
            }
            if(state == PlayerControll.status.oryugen)
            {
                i_hp -= 24;
            }
            if(state == PlayerControll.status.strongaddaddaddugen)
            {
                i_hp -= 35;
            }
            if(state == PlayerControll.status.middleaddaddaddugen)
            {
                i_hp -= 28;
            }
            if(state == PlayerControll.status.middleadogen)
            {
                i_hp -= 11;
            }
            if(state == PlayerControll.status.A)
            {
                i_hp -= 5;
            }
            if(state == PlayerControll.status.B)
            {
                i_hp -= 6;
            }
            if(state == PlayerControll.status.C)
            {
                i_hp -= 8;
            }
            if(state == PlayerControll.status.D)
            {
                i_hp -= 10;
            }
            if(state == PlayerControll.status._isGuarding)
            {
                return;
            }
        }

    }


}