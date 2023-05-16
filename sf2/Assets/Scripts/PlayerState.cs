using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerState
{
    public Action<bool> HpType;
    [SerializeField]
    float hp  = 100.0f;

    private void Update() 
    {
        player_hp();    
    }

    private void player_hp()
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

}