using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//가드, 스턴 , -hp값 추가, 일반 공격 특수 공격 구분
public class PlayerState : MonoBehaviour
{
    BoxCollider2D boxCollider;
    public static bool HpType;
    private static float i_hp = 170.0f;
    public PlayerControll.status state;
    void Start()
    {
        state = GetComponent<PlayerControll>().state;
        boxCollider = GetComponent<BoxCollider2D>();
    }
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
            if(state == PlayerControll.status.middle_addaddaddugen)
            {
                i_hp -= 28;
            }
            if(state == PlayerControll.status.middle_adogen)
            {
                i_hp -= 11;
            }
            if(state == PlayerControll.status.strong_adogen)
            {
                i_hp -= 15;
            }
            if(state == PlayerControll.status.breaking_the_collarbone)
            {
                i_hp -= 14;
            }
            if(state == PlayerControll.status.pit_of_the_stomach)
            {
                i_hp -= 16;
            }
            if(state == PlayerControll.status.oryugen)
            {
                i_hp -= 24;
            }
            if(state == PlayerControll.status.strong_addaddaddugen)
            {
                i_hp -= 35;
            }
            if(state == PlayerControll.status.middle_addaddaddugen)
            {
                i_hp -= 28;
            }
            if(state == PlayerControll.status.middle_adogen)
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