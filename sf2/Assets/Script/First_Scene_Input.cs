using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class First_Scene_Input : MonoBehaviour
{

    public InputManager button_bool;
    void Start()
    {
        button_bool+=ButtonType_check;
    }
   
    void Update()
    {

        if(button_bool==true)
        {
             SceneManager.LoadScene("Character Select");
        }
    
    }
}
