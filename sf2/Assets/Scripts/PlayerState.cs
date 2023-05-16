using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerState
{
    public Action<bool> HpType;
    [SerializeField]
    float hp  = 100.0f;
    

    void player_hp(bool hp_check)
    {
        if(hp == 0.0f)
        {
            hp_check = false;
        }
        else if(hp != 0.0f)
        {
            hp_check = true;
        }
    }

}