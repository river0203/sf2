using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public static bool TimeType = true; //?
    [SerializeField]
    float MaxTime = 60;
    public static int first_time = 0;
    public static int last_time = 0;
    int CurrentTime = 0;
    
    
    private void Start()
    {
        CurrentTime = (int)MaxTime;
    }
    private void Update()
    {
        MaxTime -= Time.deltaTime;
        CurrentTime = (int)MaxTime;
        first_time = CurrentTime / 10;
        last_time = CurrentTime % 10;
    

        check_timeOut();
    }    

    void check_timeOut() //시간이 초과 되거나 시작 되지 않았을 때 false로 설정하여 움직임 차단
    {
        if(CurrentTime > MaxTime)
        {
            TimeType = false;
            Debug.Log($"{TimeType}");
        }
        else if(CurrentTime == 0)
        {
            TimeType = false;
            Debug.Log($"{TimeType}");
        }
    }
}