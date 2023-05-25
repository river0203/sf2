using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select_Scene_Input : MonoBehaviour
{
    void Start()
    {
        Invoke("ChangeScene", 3f); //3초 뒤에 ChangeScene 함수를 호출함.
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Game Scene"); //게임 씬으로 변경.
    }
}