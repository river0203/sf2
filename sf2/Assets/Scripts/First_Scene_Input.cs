using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class First_Scene_Input : MonoBehaviour
{
    void Update()
    {

        if(Input.GetKey(KeyCode.Space))
        {
             SceneManager.LoadScene("Character_Select");
        }
    
    }
}
