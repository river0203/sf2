/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager
{
    public Action<bool> ButtonType_check;
    //bool a;
    
    //key 입력을 bool 값으로 확인
    //확인된 정보를 다른 UI, character로 제공
    static void PressButton(bool ButtonKey) //Action 구현
    {
        if(Input.anyKeyDown)
        {
            ButtonKey = true;
            Debug.Log("user press anykey");
        }
    }
    private void Awake() 
    {
        ButtonType_check += PressButton;
    }

    private void Update() //FirstScene에 bool 값을 전달 하는가?
    {
        ButtonType_check.Invoke(true);
    }
}
*/