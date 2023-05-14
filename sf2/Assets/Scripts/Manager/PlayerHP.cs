using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerHP 
{
    public Action<bool> HpState;
    [SerializeField]
    float hp  = 100.0f;

    private void player_hp()
    {
        if(player_hp == 0.0f)
        {
            HpType = false;
        }
        else if(player_hp != 0.0f)
        {
            HpType = true;
        }
    }

    private void Start() 
    {
        HpState += HpType;
    }
    private void Update() 
    {
        
    }


}