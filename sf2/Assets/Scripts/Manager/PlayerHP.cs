using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerHP
{
    [SerializeField]
    float hp  = 100.0f;
    public Action<bool> HpState;

    private void player_hp()
    {
        if(player_hp == 0.0)
        {
            HpType = false;
        }
    }


}