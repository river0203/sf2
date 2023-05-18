using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour
{
    public InputManager button_bool;
    void Start() 
    {
        button_bool += ButtonType_check;
    }
    void Update()
    {
        if(button_bool == true) // press any key == true
        {
            SceneManager.LoadScene("Character Select"); //씬을 Charater Select 라는 씬으로 바꿈.
        }
    }
}