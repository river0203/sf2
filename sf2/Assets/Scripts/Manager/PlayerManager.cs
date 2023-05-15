using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//player에 필요한 요소 관리, 통로 같은 역할
public class PlayerManager : PlayerMovement
{
    public Action CheckHp;
    public Action a;
    //특정 씬에서만 
    /*private void Update() 
    {
        CheckHp += HpState;
    }*/

    private void Update() 
    {
        PlayerMovement.player_move();
        PlayerMovement.player_Nmove();
    }

}