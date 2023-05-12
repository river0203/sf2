using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public Action PressButtonCheck;
    //key 입력을 bool 값으로 확인
    //확인된 정보를 다른 UI, character로 제공
    
    static void PressButton(bool ButtonKey) //Action 구현
    {
        if(Input.anyKeyDown)
        {
            Debug.Log("user press anykey");
            ButtonKey = true;
        }
    }

    private void Awake() 
    {
        PressButtonCheck += PressButton;
    }

}
