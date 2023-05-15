using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class First_Scene_Input : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) //스페이스바를 입력 시 
        {
            SceneManager.LoadScene("Character Select"); //씬을 Charater Select 라는 씬으로 바꿈.
        }
    }
}
