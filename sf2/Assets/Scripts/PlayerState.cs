using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerState
{
    static public bool HpType;
    static float hp  = 100.0f;

    private void Update() 
    {
        player_hp();
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

}